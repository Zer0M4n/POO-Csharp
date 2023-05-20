#Unciclo while vaerifica si la premicia es cierta 
#y si es asi se hace el ciclo

#Verificar si el numero es impar y para hasta que se lo encuentre y agrgar un contador de intentos

Verificador = True
Number = int()
i = 0

while Verificador == True:
    i = i + 1
    print("Intentos " , i)
    print("Numero: ")
    Number = int(input())

    if Number % 2 == 0:
        print("Es par")
    else:
        print("Es impar")
        Verificador = False