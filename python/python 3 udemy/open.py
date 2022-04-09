

dato1 = input ("ingrese alguna pendejada")

dato2 = input ("ingrese otra pendejada")

with open("D:\python\guardados\primero.txt", 'w') as f:
    f.write(dato1)
    f.write(dato2)
    f.write("a que chimba, una mas")
    

with open("D:\python\guardados\primero.txt", 'r') as e:
    print(e.read())



print ("pepe grillo")