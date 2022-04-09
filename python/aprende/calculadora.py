



num1 = int(input("Ingrese el primero numero: "))

num2 = int(input("Ingrese el segundo numero: "))

print("las operaciones que se pueden realizar son: ",
"1. suma",
"2. resta",
"3. multiplicacion",
"4. division", sep="\n")

operacion = int(input("indique la operacion que desea realizar: "))


while (operacion < 1 or operacion > 4):
    print("elija un numero entre 1 y 4")
    operacion = int(input("indique la operacion que desea realizar: "))
else:
    if (operacion == 1):
        resultado = num1 + num2
        operando = "suma"
    elif (operacion == 2):
        resultado = num1 - num2
        operando = "resta"
    elif (operacion == 3):
        resultado = num1 * num2
        operando = "multiplicacion"
    elif (operacion == 4):
        resultado = num1 / num2
        operando = "division"
    

print("resultado de la ", operando, " es ", resultado)
