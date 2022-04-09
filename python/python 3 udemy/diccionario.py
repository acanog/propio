

colores = {'azul':'blue', 'negro':'black', 'rosado':'pink'}

propiedades = {1:'nombre', 2:'apellido', 3:'profesion', 4:'region'}

#print (colores, propiedades)


colorele = colores['azul']

print(colorele)

colores['azul']='bluecito'

colorele = colores['azul']

print(colorele)

colores['anaranjado']='orange'

print (colores)

edades = {'albert':24, 'johel':24, 'roque':26, 'victor':27}

edades['johel']+=1;

print (edades)

edades['guilia']=edades['albert']+edades['victor']

print (edades['guilia'])


#       2DA PARTE!!!!!

print ('2DA PARTE!!!!!')

for c,v in edades.items():
    print (c,v)

    
del(edades['guilia'])
print (edades)


#          FINAL DICCIONARIO

print ('final diccionario!!!')

equipo=[]
personajes={'nombre':'goku',
'clase':'peleador',
'nacion':'japon'}
equipo.append(personajes);


personajes={'nombre':'any',
'clase':'mascota',
'nacion':'colombia'}
equipo.append(personajes);

personajes={'nombre':'pelota',
'clase':'juguete',
'nacion':'por ahi'}

equipo.append(personajes);
print(equipo)

for e in equipo:
    print(e['nombre'],',', e['clase'], 'oriundo de ', 2['nacion']);
