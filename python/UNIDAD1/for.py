#For es un cilo que tiene un cierto rango

#Intertar 10 veses si un numero es par  y en caso de no imprimir que no se pudo 
#Agregar un contador

number = int()
i = 0
verificador = False

for number in range(10):
    i = i + 1

    print("INTENTO NUMERO ", i)
    print("NUMERO: ")
    number = int(input())

    if number % 2 == 0:
        print("Es primo")
        verificador = True
        break
    else:
        print("EL NUMERO NO ES PAR")

if  verificador == False:
    print("NO SE ENCONTRO EL NUMERO PAR")

else:
    print("SE ENCONTRO EL NUMERO PAR")
