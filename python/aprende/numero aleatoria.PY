
from random import randrange

#numero aleatorio


numero = int(randrange(10))
#print(numero)




print("adivine el numero que viene entre 0 y 10")
n_usuario = int(input("Ingrese el numero que crea: "))

if (numero==n_usuario):
    print("Le atinó")
else:
    print("no fué")

print(f"""el numero aleatorio fue {numero}  y el que ud eligio fue {n_usuario}""")

