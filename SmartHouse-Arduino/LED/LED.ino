// Adafruit IO Digital Output Example
// Tutorial Link: https://learn.adafruit.com/adafruit-io-basics-digital-output
//
// Adafruit invests time and resources providing this open source code.
// Please support Adafruit and open source hardware by purchasing
// products from Adafruit!
//
// Written by Todd Treece for Adafruit Industries
// Copyright (c) 2016 Adafruit Industries
// Licensed under the MIT license.
//
// All text above must be included in any redistribution.

/************************** Configuration ***********************************/

// edit the config.h tab and enter your Adafruit IO credentials
// and any additional configuration needed for WiFi, cellular,
// or ethernet clients.
#include "config.h"

/************************ Example Starts Here *******************************/

// digital pin 5
#define LED_PIN D1

#define LED2_PIN D2

#define LED3_PIN D5

#define LED4_PIN D6

// set up the 'digital' feed
AdafruitIO_Feed *digital = io.feed("digital");
AdafruitIO_Feed *led2 = io.feed("led2");
AdafruitIO_Feed *led3 = io.feed("led3");
AdafruitIO_Feed *led4 = io.feed("led4");

void setup() {
  
  pinMode(LED_PIN, OUTPUT);

  pinMode(LED2_PIN, OUTPUT);

  pinMode(LED3_PIN, OUTPUT);

  pinMode(LED4_PIN, OUTPUT);
  
  // start the serial connection
  Serial.begin(115200);

  // wait for serial monitor to open
  while(! Serial);

  // connect to io.adafruit.com
  Serial.print("Connecting to Adafruit IO");
  io.connect();

  // set up a message handler for the 'digital' feed.
  // the handleMessage function (defined below)
  // will be called whenever a message is
  // received from adafruit io.
  digital->onMessage(handleMessage);
  led2->onMessage(handleMessage2);
  led3->onMessage(handleMessage3);
  led4->onMessage(handleMessage4);
  
  // wait for a connection
  while(io.status() < AIO_CONNECTED) {
    Serial.print(".");
    delay(500);
  }

  // we are connected
  Serial.println();
  Serial.println(io.statusText());
  digital->get();

}

void loop() {

  // io.run(); is required for all sketches.
  // it should always be present at the top of your loop
  // function. it keeps the client connected to
  // io.adafruit.com, and processes any incoming data.
  io.run();

}

// this function is called whenever an 'digital' feed message
// is received from Adafruit IO. it was attached to
// the 'digital' feed in the setup() function above.
void handleMessage(AdafruitIO_Data *data) {

  Serial.print("received <- ");

  if(data->toPinLevel() == HIGH)
    Serial.println("HIGH1");
  else
    Serial.println("LOW1");

  digitalWrite(LED_PIN, data->toPinLevel());
}

void handleMessage2(AdafruitIO_Data *data){

  Serial.print("received <- ");

  if(data->toPinLevel() == HIGH)
    Serial.println("HIGH2");
  else
    Serial.println("LOW2");

  
  digitalWrite(LED2_PIN, data->toPinLevel());
}

void handleMessage3(AdafruitIO_Data *data){

  Serial.print("received <- ");

  if(data->toPinLevel() == HIGH)
    Serial.println("HIGH3");
  else
    Serial.println("LOW3");
    
  digitalWrite(LED3_PIN, data->toPinLevel());
}

void handleMessage4(AdafruitIO_Data *data){

    Serial.print("received <- ");

  if(data->toPinLevel() == HIGH)
    Serial.println("HIGH4");
  else
    Serial.println("LOW4");
    
  digitalWrite(LED4_PIN, data->toPinLevel());
}
