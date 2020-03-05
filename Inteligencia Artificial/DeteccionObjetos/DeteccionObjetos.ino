#include <Servo.h>
Servo servo1;
Servo servo2;
int op=1;
int g=0;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  servo1.attach(9);
  servo2.attach(11);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()>0){
    op=Serial.parseInt(); //Seleccionamos que servo motor queremos mover.
    delay(100);
    switch(op){
      case 1:        
        g=Serial.parseInt();//Asignamos los grados a rotar        
        if( g>=0 && g<=180){
          servo1.write(g);
          Serial.println(g);
        }
        else{
            Serial.println("Servomotor 1 Fuera del rango");
        }
        break;
      case 2: 
        
        g=Serial.parseInt();        
        if(g>=0 && g<=160 ){
          servo2.write(g);
          Serial.println(g);
        }
        else{
          Serial.println("Servo motor 2 Fuera del rango");
        }
        break;
      default: Serial.println("Not found"); break;
    }
  }
}
