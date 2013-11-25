#include <SoftwareSerial.h>
#include <TinyGPS.h>

#define rxPin 2
#define txPin 3
#define PMTK_SET_NMEA_UPDATE_1HZ "$PMTK220,1000*1F"
#define PMTK_SET_NMEA_UPDATE_5HZ "$PMTK220,200*2C"
#define PMTK_SET_NMEA_UPDATE_10HZ "$PMTK220,100*2F"
#define PMTK_SET_NMEA_OUTPUT_RMCONLY "$PMTK314,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0*29"
#define PMTK_SET_NMEA_OUTPUT_ALLDATA "$PMTK314,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0*28"

SoftwareSerial gpsSerial(rxPin, txPin);
TinyGPS gps;

void setup()
{
   Serial.begin(115200);
   gpsSerial.begin(9600);
   
   pinMode(13, OUTPUT);
   
   //GPS
  // uncomment this line to turn on only the "minimum recommended" data for high update rates!
  gpsSerial.println(PMTK_SET_NMEA_OUTPUT_RMCONLY);
  
  // uncomment this line to turn on all the available data - for 9600 baud you'll want 1 Hz rate
  //gpsSerial.println(PMTK_SET_NMEA_OUTPUT_ALLDATA);
  
  // Set the update rate
  // 1 Hz update rate
  //gpsSerial.println(PMTK_SET_NMEA_UPDATE_1HZ);
  // 5 Hz update rate- for 9600 baud you'll have to set the output to RMC only (see above)
  //gpsSerial.println(PMTK_SET_NMEA_UPDATE_5HZ); 
  //10 Hz update rate - for 9600 baud you'll have to set the output to RMC only (see above)
  gpsSerial.println(PMTK_SET_NMEA_UPDATE_10HZ);
}

void loop() {

  bool newdata = false;
  unsigned long start = millis();

  // Every 5 seconds we print an update
  while (millis() - start < 100)
  {
    if (feedgps())
      newdata = true;        
  }

//  if (checkKeyDebounce() == 4)
//    showNavigationMenu();

  if (newdata)
  {
    Serial.println("Acquired Data");
    Serial.println("-------------");
    gpsdump(gps);
    Serial.println("-------------");
    Serial.println();
  }
  else {
    Serial.println("No data");
  } 

}

bool feedgps()
{
  while (gpsSerial.available())
  {
    char gpsData = gpsSerial.read();
    Serial.print(gpsData);
    if (gps.encode(gpsData))
      return true;
  }
  return false;
}

void gpsdump(TinyGPS &gps)
{
  float flat, flon;
  unsigned long age;
  int year;
  byte month, day, hour, minute, second, hundredths;

  feedgps(); // If we don't feed the gps during this long routine, we may drop characters and get checksum errors

    gps.f_get_position(&flat, &flon, &age);

  Serial.print("Lat/Long(float): "); 
  Serial.print(flat, 5); 
  Serial.print(", "); 
  Serial.println(flon, 5);
  Serial.print(" Fix age: "); 
  Serial.print(age); 
  Serial.println("ms.");
}
