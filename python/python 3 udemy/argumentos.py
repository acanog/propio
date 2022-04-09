


def duplicar_seq(numeros):
    for i,n in enumerate(numeros):
        numeros[i] *= 2
    return numeros

notas_a = list(range(5))
notas_b = duplicar_seq(notas_a[:])

print (notas_a, notas_b)