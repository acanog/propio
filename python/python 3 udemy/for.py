

#for con lista

indice=0

numeros = [0,1,2,3,4,5,6,7,8,9,10]

ind = int(input("ingrese la posicion en la que va a iniciar"));

for c in numeros[ind:]:

    numeros[c] *= 10
  #  ind += 1

print(numeros)