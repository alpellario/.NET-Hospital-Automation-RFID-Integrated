#include <SPI.h>
#include <MFRC522.h>

int yesil_led = 7;
int kirmizi_led = 8;

int buzzer = 6;

int RST_PIN = 9;
int SS_PIN = 10;

MFRC522 rfid(SS_PIN, RST_PIN);

void setup() {
  pinMode(buzzer, OUTPUT);
  pinMode(yesil_led, OUTPUT);
  pinMode(kirmizi_led, OUTPUT);
  Serial.begin(9600);
  SPI.begin();
  rfid.PCD_Init();

}

void loop() {
  if (Serial.available()) {
    int a = Serial.read();
    if (a == '1') {
      digitalWrite(yesil_led, HIGH);
      tone(buzzer, 6000);
      delay(300);
      noTone(buzzer);
      digitalWrite(yesil_led, LOW);
    }
    else if (a == '0') {
      digitalWrite(kirmizi_led, HIGH);
      tone(buzzer, 2000);
      delay(300);
      noTone(buzzer);
      digitalWrite(kirmizi_led, LOW);
    }
  }
  if (!rfid.PICC_IsNewCardPresent())
    return;
  if (!rfid.PICC_ReadCardSerial())
    return;

  ekranaYazdir();

  rfid.PICC_HaltA();
}

void ekranaYazdir() {
  digitalWrite(yesil_led, HIGH);
  //tone(buzzer, 5000);
  delay(300);
  //noTone(buzzer);
  digitalWrite(yesil_led, LOW);

  for (int sayac = 0; sayac < 4; sayac++) {
    Serial.print(rfid.uid.uidByte[sayac]);

  }

  

}
