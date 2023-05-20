#Crear una calculadora donde uses funciones y puedas escoger que quieres usa

#Declarar variables
Numero1 = int()
Numero2 = int()
Resultado = 0
opc = str()
Verificador = True

#Hacer funciones
def SUMA(Numero1,Numero2,Resultado):
    Resultado = Numero1 + Numero2
    return Resultado
def MULTIPLICACION(Numero1,Numero2,Resultado):
    Resultado = Numero1 * Numero2
    return Resultado
def DIVISION(Numero1,Numero2,Resultado):
    Resultado = Numero1 / Numero2
    return Resultado
def RESTA(Numero1,Numero2,Resultado):
    Resultado = Numero1 - Numero2
    return Resultado

while Verificador  == True:
    print("Numero 1: ")
    Numero1 = int(input())
    print("Numero 2: ")
    Numero2 = int(input())

    print("Que desea calcular? (SUMA, RESTA , MULTIPLICACION , DIVISION)")
    opc = str(input())

    if opc == "SUMA":
        print(SUMA(Numero1,Numero2,Resultado))
    elif opc == "RESTA" :
        print(RESTA(Numero1,Numero2,Resultado))
    elif opc == "MULTIPLICACION":
        print(MULTIPLICACION(Numero1,Numero2,Resultado))
    elif opc == "DIVISION":
        print(DIVISION(Numero1,Numero2,Resultado))
    else:
        print("ESCRIBA BIEN PORFAVOR , SE REPITARA")

    print("Desea repetir el programa ? [S] [N] ")
    opc = str(input())

    if opc == "N":
        Verificador = False
    else:
        print("REPETICION ")

print("FIN DEL PROGRAMA")

    

