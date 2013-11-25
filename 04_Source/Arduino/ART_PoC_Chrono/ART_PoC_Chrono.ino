unsigned long lastTime;
unsigned long lapTime;
unsigned long beginTime;
unsigned long totalTime;
unsigned long partialTime;

int Lap;

String formatTimeString(unsigned long tempTime) {

   int millisec; int second; int minute; int hour;
   
   millisec = tempTime % 1000;
   second = (tempTime / 1000) % 60;
   minute = ((tempTime / 1000) / 60) % 60;
   hour = ((tempTime / 1000) / 60 / 60);
   
   String result = formatNumber(hour, 2) + ":" + formatNumber(minute, 2) + ":" + formatNumber(second, 2) + "." + formatNumber(millisec, 3);
      
   return result;
}

String formatNumber(int value, int qtd){
  String number = String(value);
  for(int x = number.length(); x < qtd; x++) {
    if(x <= qtd) {
      number = "0" + number;
    }
  }
  return number;
}

void setup() {
  Serial.begin(9600);
}

void loop() {
  char serialRead;
  
  if(Serial.available()) {
    serialRead = Serial.read();
    delay(1);      
    if(serialRead == '0') {
      //Stop Chrono
      Serial.print("Lap: "); Serial.println(++Lap);
      lapTime = millis();
      Serial.print("Total time: "); Serial.println(formatTimeString(lapTime - beginTime));
      Serial.print("Lap time: "); Serial.println(formatTimeString(lapTime - lastTime));
    } else if (serialRead == '1') {
      //Start Chrono
      beginTime = millis();
      lastTime = beginTime;
      Lap = 0;
    } else if (serialRead == '2') {
      //Lap Chrono
      Serial.print("Lap: "); Serial.println(++Lap);
      lapTime = millis();
      Serial.print("Partial time: "); Serial.println(formatTimeString(lapTime - beginTime));
      Serial.print("Lap time: "); Serial.println(formatTimeString(lapTime - lastTime));
      lastTime = lapTime;
    }
  } 
    
}


