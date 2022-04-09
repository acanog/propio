


juegue = 1

while (juegue==1):
    opcion = input("""ingrese una opcion
        1) salude.
        2) haga algo.
        3) fuimonos
        """)

    if opcion=="1":
        print ("Hola Pianola")
    elif opcion=="2":
        n1= (int(input("Ingrese primero numero:     ")))
        n2= (int(input("Ingrese segundo numero:     ")))
        print("el resultado es {}".format(n1+n2))
    elif opcion=="3":
        print("nospi")
        juegue = 0
        #o break
    else:
        print("metalo bien")


