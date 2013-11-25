#include <Adafruit_GFX.h>
#include <Adafruit_PCD8544.h>

//SCLK/DIN/DC/CS/RST
Adafruit_PCD8544 display = Adafruit_PCD8544(8, 9, 10, 11, 12);

void setup() {
  Serial.begin(9600);

  display.begin();
  display.setTextSize(1);
  display.setTextColor(BLACK);
  display.setCursor(0,0);
  display.println("Hello, world!");
  
}

void loop() {
  
}
