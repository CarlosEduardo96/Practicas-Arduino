int op=0;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(8,OUTPUT); //Indica la salida digital del pin 13
  
}

void loop() {
  if(Serial.available()>0){
    op=Serial.parseInt();
    delay(100);
    if(op==1){
     digitalWrite(8,HIGH); //Se activa el led
     Serial.println("Led encendido");
    }
    if(op==0){
      digitalWrite(8,LOW);
      Serial.println("Led apagado");
    }
  }
}
