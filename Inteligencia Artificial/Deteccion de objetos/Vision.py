# Visión 1.0v by Carlos Eduardo.
import numpy as np #declaracion de la libreria numpy
import cv2 , serial #declaracion de las librerias opencv y pyserial

## metodos______________________
def nothing(x):
    pass
#animacion de movimiento de arduino.
def movimiento(x,y):
    if(x>=0 and x<=200):
        print("X: ",x)
        arduino.write(b"l")

    elif(x>500):
        print("X: ",x)        
        arduino.write(b"r")  

    if(y<200):
        print("Y: ",y)
        arduino.write(b"u")

    elif(y>360):
        print("Y: ",y)
        arduino.write(b"d")

# Creamos una variable de camara y asigamos la primera camara disponible
# cv2.VideoCapture(de pendiendo la camara que se encuentra conectada )
# en este caso es la numero 1.
cap = cv2.VideoCapture(1)
cv2.namedWindow('Colores')
#configuracion arduino esto varia de pendiendo del COMX de la arduino.
arduino = serial.Serial('COM3', 9600)

# Crearemos los controles para indicar el color que seguiremos

cv2.createTrackbar ('H min', 'Colores', 0,256,nothing)
cv2.createTrackbar ('H max', 'Colores', 0,256,nothing)
cv2.createTrackbar ('S min', 'Colores', 0,256,nothing)
cv2.createTrackbar ('S max', 'Colores', 0,256,nothing)
cv2.createTrackbar ('V min', 'Colores', 0,256,nothing)
cv2.createTrackbar ('V max', 'Colores', 0,256,nothing)

# Iniciamos el bucle de captura, en el que leemos cada frame de la captura
detectar=False

while(True):
    ret, frame = cap.read()
    hsv = cv2.cvtColor(frame, cv2.COLOR_BGR2HSV) #Convertimos imagen a HSV

    # Asignamos las variables del rango de color que seguiremos
    #Modelo de color H indica el matiz del color.
    Hmin = cv2.getTrackbarPos('H min', 'Colores')
    Hmax = cv2.getTrackbarPos('H max', 'Colores')

    #Modelo de color S indica la saturacion del color.
    Smin = cv2.getTrackbarPos('S min', 'Colores')
    Smax = cv2.getTrackbarPos('S max', 'Colores')
    
    #Modelo V indicamos el brillo de dicho color.
    Vmin = cv2.getTrackbarPos('V min', 'Colores')
    Vmax = cv2.getTrackbarPos('V max', 'Colores')

    # Aqui mostramos la imagen en blanco o negro segun el rango de colores.
    bn_img = cv2.inRange(hsv, np.array((Hmin,Smin,Vmin)), np.array((Hmax,Vmax,Smax)))

    # Limpiamos la imagen de imperfecciones con los filtros erode y dilate
    bn_img = cv2.erode (bn_img,cv2.getStructuringElement(cv2.MORPH_RECT,(3,3)),iterations = 1)
    bn_img = cv2.dilate (bn_img,cv2.getStructuringElement(cv2.MORPH_RECT,(5,5)),iterations = 1)
    # Localizamos la posicion del objeto
    M = cv2.moments(bn_img)
    if M['m00']>50000:
        cx = int(M['m10']/M['m00'])
        cy = int(M['m01']/M['m00'])
    # Mostramos un circulo verde en la posicion en la que se encuentra el objeto
        cv2.circle (frame,(cx,cy),20,(0,255,0), 2)
        if detectar==True:
            print("X: ",cx," Y: ",cy) #imprimimos las coordenadas del objeto.
            movimiento(cx,cy)

    # Creamos las ventanas de salida y configuracion
    cv2.imshow('Salida', frame)
    cv2.imshow('Rango de Colores', bn_img)

    if cv2.waitKey(1) & 0xFF == ord('q'): # Indicamos que al pulsar "q" el programa se cierre
        break
    elif cv2.waitKey(1) & 0xFF == ord('i'):# indicamos que la deteccion sea iniciada
        detectar=True
        print("Segimiento de objeto - iniciado")
    elif cv2.waitKey(1) & 0xFF == ord('p'):# indicamos que la deteccion sea pausada
        detectar=False
        print("Segimiento de objeto - pausado")
print("Cerrando arduino..")
#Cierre de la conexion de arduino.
arduino.close() 
print("Bye (^_^)^")
cap.release()
cv2.destroyAllWindows()