#Declaramos variables
numero1 = 0
numero2 = 0
SUMA = 0
RESTA = 0
MULTIPLICAION = 0
DIVISION = 0

#Pedimos los datos al usuario
print("Numero 1: ")
numero1 = int(input())

print("Numero 2: ")
numero2 = int(input())

#TRANSFORMAS LOS DATOS EN FORMA DE ENTEROS
numero1 = int(numero1)
numero2 = int(numero1)

#REALIZAMOS LAS OPERACIONES
SUMA = numero1 + numero2
RESTA = numero1 - numero2
DIVISION = numero1 / numero2
MULTIPLICAION = numero1 * numero2

#Creamos el mensaje
Mensaje = f""""
SUMA {SUMA}
RESTA {RESTA}
MULTIPLICACION {MULTIPLICAION}
DIVISION {DIVISION}"""

print(Mensaje)#imprimimos el mensaje
