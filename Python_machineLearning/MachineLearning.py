import statistics as stats
import math
##Ejercio encontrar la media
def media():
   
    lista=[]
    i=0
    h=0
    num=0
    suma=0
    media=0
    num=int(input("cuantos números vas a ingresar?: "))
    print("Se sacará la media de ",num, "números")
    while(i<num):
        a=int(input("Ingrese los números para sacar la media: "))
        lista.append(a)
        i+=1
    while(h<len(lista)):
        suma+=lista[h]
        
        h+=1
    media=suma / len(lista)
    print("la media es : ",media)
##Ejercicio de moda
def moda():
    lista=[]
    listaModa=[]
    i=0
    repeticiones=0
    
    
    num=int(input("cuantos números vas a ingresar?: "))
    print("Se sacará la moda de ",num, "números")
    while(i<num):
        a=int(input("Ingrese los números para sacar la moda: "))
        lista.append(a)
        i+=1
    for i in lista:
        ##la función count devuelve el numero de veces que se repite x o i en nuestro caso
        apariciones=lista.count(i)
        if(apariciones>repeticiones):
            repeticiones=apariciones
    for i in lista:
        apariciones=lista.count(i)
        if(apariciones==repeticiones and  i not in listaModa):
            listaModa.append(i)
    
    print ("Moda: ",listaModa)

##Ejercicio de mediana
def mediana():
    lista=[]
    
    i=0
    num=int(input('cuantos números vas a ingresar?: '))
    print("Se sacará la moda de  ", num,"números")
    while(i<num):
        a=int(input('Ingrese los números: '))
        lista.append(a)
        
        i+=1
    lista.sort()
    for i in lista:
        print(i)
    if (len(lista)%2==0):
        n=len(lista)
        #tenemos que colocar el operador / de division de la siguiente manera
        # // porque en python 3 esto indica que se puede esperar un resultado flotante sin truncar
        # mientras que poner  / limitará el resultado a un entero
        mediana=(lista[n // 2 - 1]+ lista[n //2])//2
    else:
        mediana=lista[len(lista)//2]
    
    print("La mediana es: ",mediana)



    
##Ejercicio media, moda y mediana usando libreria para obtener estadísticos
def functionMedia():
    i=0
    lista=[]
    num=int(input("cuantos números vas a ingresar?: "))
    print("Se sacará la media de  ", num,"números")
    while(i<num):
        a=int(input("Ingrese los números: "))
        lista.append(a)
        i+=1
    print("La media es: ",stats.mean(lista))
def functionModa():
    i=0
    lista=[]
    num=int(input("cuantos números vas a ingresar?: "))
    print("Se sacará la moda de  ", num,"números")
    while(i<num):
        a=int(input("Ingrese los números: "))
        lista.append(a)
        i+=1
    print("La moda es: ",stats.mode(lista))
#L funcion median ordena los datos automaticamente de meno a mayor
def functionMediana():
    i=0
    lista=[]
    num=int(input("cuantos números vas a ingresar?: "))
    print("Se sacará la mediana de  ", num,"números")
    while(i<num):
        a=int(input("Ingrese los números: "))
        lista.append(a)
        i+=1
    print("La mediana es: ",stats.median(lista))        
    
#Ejercicio de varianza
def varianza():
    i=0
    lista=[]
    suma=0
    media=0
    num=int(input("Cuantos números vas a ingresar?: "))
    print("Se calculará la varianza de un grupo de ",num,"datos")
    while(i<num):
        a=int(input("Ingresa el número: "))
        lista.append(a)
        
        suma+=lista[i]
        i+=1
    #recuerda que la funcion mean calcula la media o promedio    
    media=stats.mean(lista)
    round(media,2)
    print ("El promedio es: ",round(media,2))
    print()
    listaDif=[]
    #cargar la listaDif con los datos restados por el promedio 
    for i in lista:
        listaDif.append(i-media)
    #imprimir datos restados por la media
    print("--------------cada elemento restado por el promedio--------------")
    for i in listaDif:
        print (i)
    listaPow=[]
    #cargar la listaPow con cada dato elevado al cuadrado de la listaDif
    for i in listaDif:
        listaPow.append(math.pow(i,2))
    #imprimir cada elemento elevado al cuadrado
    print("--------------cada elemento restado elevado al cuadrado----------")
    for i in listaPow:
        print(i)
    sumaPow=0
    for i in listaPow:
        sumaPow+=i
        
    print("La sumatoria de los datos elevados al cuadrado es: ", sumaPow)
    print("-------------------------")
    print("La varianza es: " ,round((sumaPow/num),2))
#ahora haremos el mismo ejercicio pero usando la libreria de estadísticas
def varianzaLib():
    i=0
    lista=[]
    num=int(input("Cuantos números vas a ingresar?: "))
    print("Se calculará la varianza de un grupo de ",num,"datos")
    while(i<num):
        a=int(input("Ingresa el número: "))
        lista.append(a)
        i+=1
    print("La varianza es: ")
    return stats.pvariance(lista)
#Ejercicio de desviación estándar solo hay que sacarle la raiz cuadrada a la varianza
def desviacionEstandar():
    
    desviacion=varianzaLib()
    print("La desviacion estandar es: ",math.sqrt(desviacion))
    
