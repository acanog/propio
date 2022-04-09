
#Sacar la media muestral del siguiente ejercicio
print("ejercicio 1")
"""num1 = int (input("ingrese el primero numero: "))
num2 = int (input("ingrese el segundo numero: "))
num3 = int (input ("ingrese el tercero numero: "))

media = (num1+num2+num3)/3; 
print ("la media mmuestral es ", media)

"""

#en la siguiente matriz la suma de los 3 primeros elementos suman el cuarto. corregir el cuarto usand indexacion

print ("ejercicio 2")
matriz = [
    [1,1,1,3],
    [2,2,2,7],
    [3,3,3,9],
    [4,4,4,13]
]

matriz[1][-1]= sum (matriz[1][:-1])

matriz[-1][-1]= sum (matriz[-1][:-1])

print (matriz)