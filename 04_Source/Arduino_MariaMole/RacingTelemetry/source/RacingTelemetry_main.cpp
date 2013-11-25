/*************************************************************
project: <type project name here>
author: <type your name here>
description: <type what this file does>
*************************************************************/
 
#include "RacingTelemetry_main.h"
#include "SoftwareSerial.h"

#define PMTK_SET_NMEA_UPDATE_1HZ "$PMTK220,1000*1F"
#define PMTK_SET_NMEA_UPDATE_5HZ "$PMTK220,200*2C"
#define PMTK_SET_NMEA_UPDATE_10HZ "$PMTK220,100*2F"
#define PMTK_SET_NMEA_OUTPUT_RMCONLY "$PMTK314,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0*29"
#define PMTK_SET_NMEA_OUTPUT_ALLDATA "$PMTK314,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0*28"
 
SoftwareSerial gpsSerial(2, 3); 

void setup()
{
  Serial.begin(9600);
  gpsSerial.begin(9600);
  
   // uncomment this line to turn on only the "minimum recommended" data for high update rates!
  gpsSerial.println(PMTK_SET_NMEA_OUTPUT_RMCONLY);
  
  // uncomment this line to turn on all the available data - for 9600 baud you'll want 1 Hz rate
  //gpsSerial.println(PMTK_SET_NMEA_OUTPUT_ALLDATA);
  
  // Set the update rate
  // 1 Hz update rate
  //gpsSerial.println(PMTK_SET_NMEA_UPDATE_1HZ);
  // 5 Hz update rate- for 9600 baud you'll have to set the output to RMC only (see above)
  //gpsSerial.println(PMTK_SET_NMEA_UPDATE_5HZ); 
  // 10 Hz update rate - for 9600 baud you'll have to set the output to RMC only (see above)
  gpsSerial.println(PMTK_SET_NMEA_UPDATE_10HZ);
}

void loop() 
{
  // For one second we parse GPS data and report some key values
  for (unsigned long start = millis(); millis() - start < 200;)
  {
    while (gpsSerial.available())
    {
      char c = gpsSerial.read();
      Serial.write(c); // uncomment this line if you want to see the GPS data flowing
      
    }
  }
}