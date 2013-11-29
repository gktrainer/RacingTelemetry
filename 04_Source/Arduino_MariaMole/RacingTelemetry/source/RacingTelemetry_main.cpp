/*************************************************************
project: Racing Telemetry
author: Anderson Antonio Lopes Rodrigues
description: Algoritmo para coleta de informações do veículo
*************************************************************/
 
#include "RacingTelemetry_main.h"
#include "SoftwareSerial.h"
#include "SD.h"
 
#define PMTK_SET_NMEA_UPDATE_10HZ "$PMTK220,100*2F"
#define PMTK_SET_NMEA_OUTPUT_RMCONLY "$PMTK314,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0*29"
 
#define rxPin 2
#define txPin 3
#define sdChipSelect 10
 
SoftwareSerial gpsSerial(rxPin, txPin);
File dataFile;
unsigned long lastSave;
 
void setup()
{
	Serial.begin(9600);
	gpsSerial.begin(9600);
	 
	// Seta para recuperar somente sentenças NMEA RMC
	gpsSerial.println(PMTK_SET_NMEA_OUTPUT_RMCONLY);
	 
	// Seta a frequencia de funcionamento do GPS para 10HZ/seg
	gpsSerial.println(PMTK_SET_NMEA_UPDATE_10HZ);
	 
	pinMode(txPin, OUTPUT);
	 
	if (!SD.begin(sdChipSelect)) {
		Serial.println("Cartão falhou, ou não está presente");
		delay(3000);
		return;
	}
	 
	dataFile = SD.open("LogData.log", FILE_WRITE);
	Serial.println("Cartão SD OK!");
	delay(3000);
}
 
void loop()
{
	 
	// Captura os dados do GPS a cada 0,1 segundo
	for (unsigned long start = millis(); millis() - start < 100;)
	{
		while (gpsSerial.available())
		{
			//Recupera dados do GPS
			char c = gpsSerial.read();
			//Transmite para o receptor
			Serial.write(c);
			 
			//Caso esteja ok a gravação de dados no cartão SD, escreve os dados no arquivo
			if (dataFile) {
				dataFile.write(c);
				 
				//A cada 1 segundo, grava as informações do buffer no arquivo texto
				if(millis() - lastSave > 1000) {
					dataFile.flush();
				}
			}
			 
			lastSave = millis();
		}
	}
}
 
 
 
 
 
 
 
 
 
 
