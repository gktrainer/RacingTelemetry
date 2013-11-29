#include "helloword_xbee_main.h"
 
int contador = 0;
 
void setup() {
	Serial.begin(4800);
}
 
void loop() {	 
	contador++;
	String mensagem01 = "Te amo koozinha x " + String(contador) + " !!!";
	Serial.println(mensagem01);
	delay(1000);
}