/*********************************************************************
 **  Description:                                                    **
 **  This file is a sample code for your reference.                  **
 **                                                                  **
 **  Copyright (C) 2011 ElecFreaks Corp.                             **
 **  Created by ElecFreaks Robi.W /29 Sep 2011                      **
 **                                                                  **
 **  http://www.elecfreaks.com                                       **
 *********************************************************************/
#include <SoftwareSerial.h>

#define rxPin 2
#define txPin 3

SoftwareSerial mySerial(rxPin, txPin);
 
void setup()
{
   // define pin modes for tx, rx pins:
   pinMode(rxPin, INPUT);
   pinMode(txPin, OUTPUT);
   Serial.begin(9600);
   mySerial.begin(9600);
}
 
void loop()
{
  int i = 0;
  char someChar[32] = {0};
  // when characters arrive over the serial port...
  if(Serial.available()) {
    do{
      someChar[i++] = Serial.read();
      //As data trickles in from your serial port you are grabbing as much as you can, 
      //but then when it runs out (as it will after a few bytes because the processor 
      //is much faster than a 9600 baud device) you exit loop, which then restarts, 
      //and resets i to zero, and someChar to an empty array.So please be sure to keep this delay 
      delay(3);                  
 
    }while (Serial.available() > 0);
 
    mySerial.println(someChar);
    Serial.println(someChar);
  }
 
  while(mySerial.available()) 
      Serial.print((char)mySerial.read());    
}