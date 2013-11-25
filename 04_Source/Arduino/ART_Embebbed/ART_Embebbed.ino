/*
  Menu - OK
  
  Circuito
    Capturar satelites - OK
    Recuperar velocidade - OK
    Tempo total de sessão - OK
    Implementar algoritmo de passagem na linha de chegada
    Tempo da volta
    Expor na tela - OK
    Gravar log no txt
    
  Trilha
    Capturar satelites - OK
    Recuperar velocidade - OK
    Tempo total de sessão - OK
    Expor na tela - OK
    Gravar log no txt
*/
//Include
#include <SD.h>
#include <SoftwareSerial.h>
#include <LiquidCrystal.h>
#include <TinyGPS.h>

//Define
//SD Card
#define sdPin 10
// GPS
#define rxPin 2
#define txPin 3
#define PMTK_SET_NMEA_UPDATE_1HZ "$PMTK220,1000*1F"
#define PMTK_SET_NMEA_UPDATE_5HZ "$PMTK220,200*2C"
#define PMTK_SET_NMEA_UPDATE_10HZ "$PMTK220,100*2F"
#define PMTK_SET_NMEA_OUTPUT_RMCONLY "$PMTK314,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0*29"
#define PMTK_SET_NMEA_OUTPUT_ALLDATA "$PMTK314,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0*28"
//Botões
#define btnRIGHT  0
#define btnUP     1
#define btnDOWN   2
#define btnLEFT   3
#define btnSELECT 4
#define btnNONE   5
// Linha de largada
#define MIN(x, y)                     (((x) < (y)) ? (x) : (y))
#define MAX(x, y)                     (((x) > (y)) ? (x) : (y))

struct point_ {
  long latitude;
  long longitude;
} previousPos, currentPos;

struct startFinishLine_ {
  point_ pointA;
  point_ pointB;
} startFinish;

struct sessionInfo_ {
  unsigned long beginTime;
  unsigned long lastTime;
  unsigned long totalTime;
  float currentSpeed;
  unsigned long age;
  int satCount;
} sessionInfo;

struct lapInfo_ {
  unsigned long lapTime;
  int currentLap;
} lapInfo;

// Variaveis globais
File gpsFile;
TinyGPS gps;
LiquidCrystal lcd(8, 9, 4, 5, 6, 7); 
bool statusLogging;

// Variaveis Globais de controle
static char gpsFileName[13];
static bool fileOpened = false;
static int menu = -1;
static int posMenu = -1;
char* menuPrincipal[2] = {"Modo Circuito", "Modo Trilha"};
int lcd_key     = 0;
int adc_key_in  = 0;

SoftwareSerial gpsSerial(rxPin, txPin);
 
// read the buttons
int read_LCD_buttons()
{
 adc_key_in = analogRead(0);      // read the value from the sensor 
 // my buttons when read are centered at these valies: 0, 144, 329, 504, 741
 // we add approx 50 to those values and check to see if we are close
 if (adc_key_in > 1000) return btnNONE; // We make this the 1st option for speed reasons since it will be the most likely result
 if (adc_key_in < 50)   return btnRIGHT;  
 if (adc_key_in < 195)  return btnUP; 
 if (adc_key_in < 380)  return btnDOWN; 
 if (adc_key_in < 555)  return btnLEFT; 
 if (adc_key_in < 790)  return btnSELECT;   
 return btnNONE;  // when all others fail, return this...
}

//setup
void setup() {
  // Iniciando serials
  Serial.begin(115200);   
  gpsSerial.begin(9600);
  
  //Setando pinagem do SD
  pinMode(sdPin, OUTPUT);
  if (SD.begin(sdPin)) {
    fileOpened = openGPSFile();
  }
  
  pinMode(13, OUTPUT);

  // LCD
  lcd.begin(16, 2);
  lcd.clear();
  
  showSplashScreen();
  
  //GPS
  // uncomment this line to turn on only the "minimum recommended" data for high update rates!
  gpsSerial.println(PMTK_SET_NMEA_OUTPUT_RMCONLY);
  
  // uncomment this line to turn on all the available data - for 9600 baud you'll want 1 Hz rate
  //gpsSerial.println(PMTK_SET_NMEA_OUTPUT_ALLDATA);
  
  // Set the update rate
  // 1 Hz update rate
  //gpsSerial.println(PMTK_SET_NMEA_UPDATE_1HZ);
  // 5 Hz update rate- for 9600 baud you'll have to set the output to RMC only (see above)
  gpsSerial.println(PMTK_SET_NMEA_UPDATE_5HZ); 
  //10 Hz update rate - for 9600 baud you'll have to set the output to RMC only (see above)
  //gpsSerial.println(PMTK_SET_NMEA_UPDATE_10HZ);
  
  statusLogging = false;
  
  startFinish.pointA.latitude = -23956103;
  startFinish.pointA.longitude = -46374495;
  startFinish.pointB.latitude = -23956115;
  startFinish.pointB.longitude = -46374428;
}

void loop () {
  
  lcd_key = read_LCD_buttons();
  feedgps();
  
  if(menu == 0 || menu == 1) {
    generateInfoPainel();
  } else {
    generateMenu();
  }
  
//  static int byteCount = 0;
//  static unsigned long lastTime = 0;
//  
//  if (!gpsSerial.available()) return;
//  char c = gpsSerial.read();
//  
//  if(fileOpened) {
//    gpsFile.write(c); 
//    if (++byteCount >= 1024) {
//        // flush to file every 1KB
//        gpsFile.flush();
//        byteCount = 0;
//    }
//  }
}

void generateMenu() {
  if(lcd_key == btnLEFT) {
    if(posMenu == 1) posMenu--;
  } else if (lcd_key == btnRIGHT) {
    if(posMenu == 0) posMenu++;
  } else if (lcd_key == btnSELECT) {
    menu = posMenu; 
    delay(1000);
  }
  
  if(lcd_key == btnLEFT || lcd_key == btnRIGHT || posMenu == -1) {
    if(posMenu == -1) posMenu = 0;
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Selecione < >");
    lcd.setCursor(0, 1);
    lcd.print(menuPrincipal[posMenu]);
  } 
}

void generateInfoPainel() {
  
  bool newData = false;
  unsigned long start = millis();
  
  while (millis() - start < 200)
  {
    if (feedgps())
      newData = true;   
  }
  
  if (lcd_key == btnSELECT) {
     statusLogging = statusLogging == true ? false : true;
     if(statusLogging) {
       sessionInfo.beginTime = millis();
       lapInfo.currentLap = 0;
     }
  }
  
  if(newData) {
    if (statusLogging) {
      previousPos.latitude = currentPos.latitude;
      previousPos.longitude = currentPos.longitude;
      gps.get_position(&currentPos.latitude, &currentPos.longitude, &sessionInfo.age);
      sessionInfo.satCount = gps.satellites() == TinyGPS::GPS_INVALID_SATELLITES ? 0 : gps.satellites();
      if(sessionInfo.satCount > 0) {
        if(crossLine(previousPos.latitude, previousPos.longitude, currentPos.latitude, currentPos.longitude)) {
          lapInfo.currentLap++;
        }
        sessionInfo.lastTime = millis();
        sessionInfo.currentSpeed = gps.f_speed_kmph() == TinyGPS::GPS_INVALID_F_SPEED ? 0 : gps.f_speed_kmph();
        sessionInfo.totalTime = sessionInfo.lastTime - sessionInfo.beginTime;
        if(menu == 0) {
          lapInfo.currentLap = lapInfo.currentLap;
          lapInfo.lapTime = sessionInfo.lastTime - sessionInfo.beginTime;
        }
      }            
    } else {
       lcd.clear();
       lcd.setCursor(0, 0);
       lcd.print("INICIAR?");
       lcd.setCursor(10, 0);
       lcd.print("SAT=");
       lcd.print(gps.satellites() == TinyGPS::GPS_INVALID_SATELLITES ? 0 : gps.satellites());
       lcd.setCursor(0, 1);
       lcd.print("APERTE SELECT");
     }
  }

  if(statusLogging) {
      lcd.clear();
      //Mostra a velocidade
      lcd.setCursor(0, 0);
      printFloat(sessionInfo.currentSpeed, TinyGPS::GPS_INVALID_F_SPEED, 3, 1);
      //Mostra o tempo total
      lcd.setCursor(6, 0);
      lcd.print(formatTotalTimeString(sessionInfo.totalTime));  
      if(menu == 0) {
        //Voltas
        lcd.setCursor(0, 1);
        lcd.print(formatNumber(lapInfo.currentLap, 3));
        //Tempo de volta
        lcd.setCursor(6, 1);
        lcd.print(formatLapTimeString(lapInfo.lapTime)); 
      }
  }  
}

void showSplashScreen() {

  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Arduino");
  lcd.setCursor(0, 1);
  lcd.print("Kart Telemetry");

  delay(3000);

}

bool feedgps()
{
  while (gpsSerial.available())
  {
    char gpsData = gpsSerial.read();
    if (gps.encode(gpsData)) {
      return true;
    }
  }
  return false;
}

bool openGPSFile()
{
    // open log file
    for (unsigned int index = 0; index < 65535; index++) {
        sprintf(gpsFileName, "GPS%05d.TXT", index);
        if (!SD.exists(gpsFileName)) {
            gpsFile = SD.open(gpsFileName, FILE_WRITE);
            if (gpsFile) {
                return true;
            }
            break;
        }
    }
    return false;
}

static void printFloat(float val, float invalid, int len, int prec)
{
  char sz[32];
  if (val == invalid)
  {
    strcpy(sz, "*******");
    sz[len] = 0;
        if (len > 0) 
          sz[len-1] = ' ';
    for (int i=7; i<len; ++i)
        sz[i] = ' ';
    lcd.print(sz);
  }
  else
  {
    lcd.print(val, prec);
    int vi = abs((int)val);
    int flen = prec + (val < 0.0 ? 2 : 1);
    flen += vi >= 1000 ? 4 : vi >= 100 ? 3 : vi >= 10 ? 2 : 1;
    for (int i=flen; i<len; ++i)
      lcd.print(" ");
  }
  feedgps();
}

static void printInt(unsigned long val, unsigned long invalid, int len)
{
  char sz[32];
  if (val == invalid)
    strcpy(sz, "*******");
  else
    sprintf(sz, "%ld", val);
  sz[len] = 0;
  for (int i=strlen(sz); i<len; ++i)
    sz[i] = ' ';
  if (len > 0) 
    sz[len-1] = ' ';
  lcd.print(sz);
  feedgps();
}

String formatLapTimeString(unsigned long tempTime) {

   int millisec; int second; int minute; int hour;
   
   millisec = tempTime % 1000;
   second = (tempTime / 1000) % 60;
   minute = ((tempTime / 1000) / 60) % 60;
   
   String result = formatNumber(minute, 2) + ":" + formatNumber(second, 2) + "." + formatNumber(millisec, 3);
      
   return result;
}

String formatTotalTimeString(unsigned long tempTime) {

   int millisec; int second; int minute; int hour;
   
   millisec = tempTime % 1000;
   second = (tempTime / 1000) % 60;
   minute = ((tempTime / 1000) / 60) % 60;
   hour = ((tempTime / 1000) / 60 / 60);
   
   String result = formatNumber(hour, 2) + ":" + formatNumber(minute, 2) + ":" + formatNumber(second, 2) + "." + formatNumber(millisec, 1);
      
   return result;
}

String formatNumber(int value, int qtd){
  String number = String(value);
  if(number.length() >= qtd) {
    number = number.substring(0, qtd);
  } else {
    for(int x = number.length(); x < qtd; x++) {
      if(x <= qtd) {
        number = "0" + number;
      }
    }
  }
  return number;
}

bool crossLine(float previousLatitude, float previousLongitude, float currentLatitude, float currentLongitude) {
  // Store the values for fast access and easy
  // equations-to-code conversion
  float x1 = previousLatitude, x2 = currentLatitude, x3 = startFinish.pointA.latitude, x4 = startFinish.pointB.latitude;
  float y1 = previousLongitude, y2 = currentLongitude, y3 = startFinish.pointA.longitude, y4 = startFinish.pointB.longitude;
  float d = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);
  
  // If d is zero, there is no intersection
  if (d == 0) return false;
  
  // Get the x and y
  float pre = (x1 * y2 - y1 * x2), post = (x3 * y4 - y3 * x4);
  float x = (pre * (x3 - x4) - (x1 - x2) * post) / d;
  float y = (pre * (y3 - y4) - (y1 - y2) * post) / d;

  // Check if the x and y coordinates are within both lines
  if (x < MIN(x1, x2) || x > MAX(x1, x2) || x < MIN(x3, x4) || x > MAX(x3, x4)) return false;
  if (y < MIN(y1, y2) || y > MAX(y1, y2) || y < MIN(y3, y4) || y > MAX(y3, y4)) return false;

  // Return the point of intersection
  return true;
}
