#include "config.h"

#include <Servo.h>

#define SERVO_PIN D1
#define SERVO2_PIN D2
#define SERVO3_PIN D5
#define SERVO4_PIN D5
#define SERVO5_PIN 13

Servo servo;
Servo servo2;
Servo servo3;
Servo servo4;
Servo servo5;

AdafruitIO_Feed *servo_feed = io.feed("servo");
AdafruitIO_Feed *servo2_feed = io.feed("servo2");
AdafruitIO_Feed *servo3_feed = io.feed("servo3");
AdafruitIO_Feed *servo4_feed = io.feed("servo4");
AdafruitIO_Feed *servo5_feed = io.feed("servo5");

void setup() {

  Serial.begin(115200);

  while(! Serial);

  servo.attach(SERVO_PIN);
  servo2.attach(SERVO2_PIN);
  servo3.attach(SERVO3_PIN);
  servo4.attach(SERVO4_PIN);
  servo5.attach(SERVO5_PIN);
  
  Serial.print("Connecting to Adafruit IO");
  io.connect();

  servo_feed->onMessage(handleMessage);
  servo2_feed->onMessage(handleMessage2);
  servo3_feed->onMessage(handleMessage3);
  servo4_feed->onMessage(handleMessage4);
  servo5_feed->onMessage(handleMessage5);

  while(io.status() < AIO_CONNECTED) {
    Serial.print(".");
    delay(500);
  }

  Serial.println();
  Serial.println(io.statusText());
  servo_feed->get();

}

void loop() {
  
  io.run();
  
}

void handleMessage(AdafruitIO_Data *data) {

  int angle;

  Serial.print("received <- ");

  if(data->toPinLevel() == HIGH)
  {
    Serial.println("90_1");
    angle = 90;
  }
  else
  {
    Serial.println("0_1");
    angle = 0;
  }

  servo.write(angle);
}

void handleMessage2(AdafruitIO_Data *data) {

 int angle2;

  Serial.print("received <- ");

  if(data->toPinLevel() == HIGH)
  {
    Serial.println("90_2");
    angle2 = 90;
  }
  else
  {
    Serial.println("0_2");
    angle2 = 0;
  }

  servo2.write(angle2);

}
void handleMessage3(AdafruitIO_Data *data) {

  int angle3;

  Serial.print("received <- ");

  if(data->toPinLevel() == HIGH)
  {
    Serial.println("90_3");
    angle3 = 90;
  }
  else
  {
    Serial.println("0_3");
    angle3 = 0;
  }

  servo3.write(angle3);

}
void handleMessage4(AdafruitIO_Data *data) {

   int angle4;

  Serial.print("received <- ");

  if(data->toPinLevel() == HIGH)
  {
    Serial.println("90_4");
    angle4 = 90;
  }
  else
  {
    Serial.println("0_4");
    angle4 = 0;
  }

  servo4.write(angle4);

}
void handleMessage5(AdafruitIO_Data *data) {

   int angle5;

  Serial.print("received <- ");

  if(data->toPinLevel() == HIGH)
  {
    Serial.println("90_5");
    angle5 = 90;
  }
  else
  {
    Serial.println("0_5");
    angle5 = 0;
  }

  servo5.write(angle5);

}
