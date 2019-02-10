
#include <DHT.h>
int SENSOR=2;//conectamos al serial N°2 de la placa arduino
int temp, humedad;

DHT dht(SENSOR, DHT11);

void setup(){
  Serial.begin(9600);
  dht.begin();
  Serial.println("Temperatura y humedad actual dia 29 de noviembre 2018 en cosamaloapan de carpio veracruz");
 }

void loop(){
  //capura el valor de temperatura y la humedad esto de pende del
  //tipo de sensor que utilizes.
  //cabe a destacar que algunos sensores te dan la temperatura en °F,°e y °C.
  humedad =dht.readHumidity();
  temp = dht.readTemperature();
  Serial.print("Temperatura: ");
  Serial.print(temp);
  Serial.print("C Humedad: ");
  Serial.print(humedad);
  Serial.println("%");

  //El metodo delay indica cada cuanto va tomar los valeres del sensor es decir
  //indica un tiempo de respuesta para consultar los datos del sensor.
  delay(500);
 }
