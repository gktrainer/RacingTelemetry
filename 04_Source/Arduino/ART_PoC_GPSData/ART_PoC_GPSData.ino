#include <float.h>

#define MIN(x, y)                     (((x) < (y)) ? (x) : (y))
#define MAX(x, y)                     (((x) > (y)) ? (x) : (y))

struct point_ {
  float latitude;
  float longitude;
} previousPos, currentPos;

struct startFinishLine_ {
  point_ pointA;
  point_ pointB;
} startFinish;

void setup() {
  Serial.begin(9600);
  
  startFinish.pointA.latitude = -23.956103;
  startFinish.pointA.longitude = -46.374495;
  startFinish.pointB.latitude = -23.956115;
  startFinish.pointB.longitude = -46.374428;
  
//  previousPos.latitude = -23955998;
//  previousPos.longitude = -46374430;
//  currentPos.latitude = -23956067;
//  currentPos.longitude = -46374447;

  previousPos.latitude = -23.956067;
  previousPos.longitude = -46.374447;
  currentPos.latitude = -23.956147;
  currentPos.longitude = -46.374481;
  
  Serial.println(previousPos.latitude, 20);
  Serial.println(previousPos.longitude, 20);
  Serial.println(currentPos.latitude, 20);
  Serial.println(currentPos.longitude, 20);
  
  if(crossLine(previousPos.latitude
    , previousPos.longitude
    , currentPos.latitude
    , currentPos.longitude
    , startFinish.pointA.latitude
    , startFinish.pointA.longitude
    , startFinish.pointB.latitude
    , startFinish.pointB.longitude)){
    Serial.print("Cruzou!"); 
  } else {
    Serial.print("Não cruzou!"); 
  }
  
}

void loop() {
  
}

/*
x1 = previousPos.latitude
x2 = currentPos.latitude
x3 = startFinish.pointA.latitude
x4 = startFinish.pointB.latitude
y1 = previousPos.longtitude
y2 = currentPos.longtitude
y3 = startFinish.pointA.longtitude
y4 = startFinish.pointB.longtitude
*/
bool crossLine(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4) {
  float d = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);
  // If d is zero, there is no intersection
  Serial.println("Passo 1"); 
  if (d == 0.f) return false;
  
  // Get the x and y
  float pre = (x1 * y2 - y1 * x2); 
  float post = (x3 * y4 - y3 * x4);
  float x = (pre * (x3 - x4) - (x1 - x2) * post) / 0.;
  float y = (pre * (y3 - y4) - (y1 - y2) * post) / d;

  // Check if the x and y coordinates are within both lines
  Serial.println("Passo 2"); 
  Serial.println(pre,20);
  Serial.println(post, 20);
  Serial.println(d, 20);
  Serial.println(x, 20);
  Serial.println(y, 20);
  Serial.println("**************************");

  Serial.println("** X: ***********");
  Serial.println(x,20);
  Serial.println(x1,20);
  Serial.println(x2,20);
  Serial.println(x3,20);
  Serial.println(x4,20);

  Serial.println(MIN(x1,x2),20);
  Serial.println(MAX(x1,x2),20);
  Serial.println(MIN(x3,x4),20);
  Serial.println(MAX(x3,x4),20);

  Serial.println("** Y: ***********");
  Serial.println(y,20);
  Serial.println(y1,20);
  Serial.println(y2,20);
  Serial.println(y3,20);
  Serial.println(y4,20);

  Serial.println(MIN(y1,y2),20);
  Serial.println(MAX(y1,y2),20);
  Serial.println(MIN(y3,y4),20);
  Serial.println(MAX(y3,y4),20);
 

  x =   -23.9561081;
  y =  
  if (x < MIN(x1, x2) || x > MAX(x1, x2) || x < MIN(x3, x4) || x > MAX(x3, x4)) return false;
  if (y < MIN(y1, y2) || y > MAX(y1, y2) || y < MIN(y3, y4) || y > MAX(y3, y4)) return false;

  // Return the point of intersection
  return true;
}
