import math
##usando variables globales

var_global=5
##usando la palabra reservada global no se le puede asignar un valor
global var_global2


nombre="hola barry"
print (nombre)
type(nombre)
##funcion de prueba
def  suma(a,b):
    c=a +b
    return(c)
def multiplicacion(a,b):
    c=a*b
    return c
def exp(a,b):
    return (a**b)
##ejemplo de agregar funciones dentro de otras
def ejemplo(a,b,c):
    return (suma(suma(a,b),c))
##ejemplo sin usar funciones anidadas
def hipotenusa(co,ca):
    a=math.pow(co,2)
    b=math.pow(ca,2)
    x=a+b
    hip=math.sqrt(x)
    return hip
##creamos una funcion que contendra otroas funciones que le ayuden a hacer su trabaja

def hipotenusa_(co,ca):
    a=exp(co,2)
    b=exp(ca,2)
    x=suma(a,b)
    hip=math.sqrt(x)
    return hip

##usando la variable global

def variableglobal():
    var_global=10
    print (var_global)
##una variable global inicializada con algun valor se le podra modificar
##el valor solo dentro de una funcion o método

def ejemplovar1():
    print(var_global)
def ejemplovar2():
    var_global=10
    print(var_global)

##operadores condicionales similares en todos los lenguajes
def conjucionFalse(a,b):
    x=(a>b) and (a<b)
    print(x)
def conjucionTrue(a,b):
    x=(a==b) and (a>=b)
    print(x)
##disyuncion usando el operador or si una de loa dos o mas condiciones se cumple
##sera verdad, a dierencia de and que requiere las dos condiciones verdaderas

def disyuncion(a,b):
    x=(a>b)or(a==b)
    return x
##conjuncion y disyuncion unidos en una consulta anidados se podría decir
def disy_conjun(a,b):
    x=(a>b or a==b) and (a<b or a>b)
    return x
##operador de negación
def negacion(a,b):
    x=not(a==b)
    return x
##usando condicionales if
##primero una condicion simple

def condicional_1(a,b):
    if (a==b):
        print("los numeros son iguales")
    else:
        print ("estos números son diferentes")
##condicional if con operación matemática
def restaPositivos(a,b):
    if(a>b):
        return a-b
    if(b>a):
        return b-a
##la misma operación pero con un else tu ya lo sabes viejo pero, lo regitraremos
def restaPositivos_(a,b):
    if(a>b):
        return a-b
    else:
        return b-a
##retornar cual es el mayor
def mayor(a,b):
    if(a>b):
        print(a , "es mayor que" , b)
    else:
        return (b , "es mayor que" , a)

##otra funcion usando condiciones anidadas y elseif,al concatenar string se usa +
##y como la variable a mostrar es numerica se la convierte en string von str(variable)
##o si no como lo hiciste arriba, vamos a darle
def mayor_(a,b):
    if(a>b):
        print(str(a)+" es mayor que " + str(b))
    else:
        if(a==b):
            print(str(a)+ " Es igual que "+ str(b))
        else:
            print(str(b) +" es mayor que "+ str(a))
##usando elif que es el elseif de phyton

def mayor_1(a,b):
    if(a>b):
        print(str(a)+" es mayor que " + str(b))
    elif(a==b):
        print(str(a)+ " Es igual que "+ str(b))
    elif(b>a):
        print(str(b) +" es mayor que "+ str(a))

def numero_par(a):
    if(a%2==0):
        print("el número es par")
    else:
        print("número impar")
##ejemplo de condicionales sin usar else solo usando if, esto ya lo hiciste
def numero_par2(a):
    if(a%2==0):
        a*=2
        
    if(a>10):
        a+=20
        
    if(a<50):
        a-=25
        return a
##ejemplo de ingresar datos por consola teclado
def tunombre():
    a=input("Escribe tu nombre: " + " ")
    print ("Hola, buen trabajo "  + a )

def calculadora():
    print("Menu  ")
    print("Multiplicar: 1 ")
    print("Dividir: 2")
    print("Sumar: 3")
    print("Restar: 4")
    op=int(input("ingrese el numero de la operación a realizar: " ))
    a=int(input("Ingrese el primer numero: "))
    b=int(input("Ingrese el segundo numero: "))
    if(op==1):
       
        result=a*b
        
    if(op==2):
       
        result=a/b
        
    if(op==3):
       
        result=a+b
        
    if(op==4):
       
        result=a-b
    return int(result)


def divisible(a,b):
    if(type(a)==type(0) and type(b)==type(0) ):
        if(a%b==0):
            print(a,"Es divisible por",b)
        else:
            print (str(a) + " no es divisible po " + str(b))
  
    
    else:
        print("ha ingresado un dato no numérico")
    
    return
##sin usar la libreria math 
def calcGeometrica():

    print ("calculadorora geométrica")
    print("Área del círculo: 1")
    print("Área de un triángulo: 2")
    print("Area de un cuadrado: 3")
    op = int (input("Escoja la operación que desea realizar: "))
    if(op==1):
        d=int(input("Ingrese el diametro del circulo: "))
        pi=3.14
        r=d/2
        a=(r**2)*pi
        print ("el area del circulo es:",a)
    elif(op==2):
        b=int(input("ingrese la base del triángulo: "))
        a=int(input("ingrese la altura del triángulo:"))
        ar=(b*a)/2
        print ("el area del triángulo es: ",ar)
    elif(op==3):
        l=int(input("ingrese la medida del lado del cuadrado: "))
        ar=l**2
        print("el área del cuadrado es:",ar)
    else:
        print("todavia no implementado")
        return
##usando la libreria math y validando si los datos ingresados son enteros y flotantes
def area():
    print ("calculadorora geométrica")
    print("Área del círculo: 1")
    print("Área de un triángulo: 2")
    print("Area de un cuadrado: 3")
    op = int(input("Escoja la operación que desea realizar: "))
    if(op==1):
        d=input("Ingrese el diametro del circulo: ")
        if(type(int(d)) == type(0) or type(int(d))==type(0.0)):
            diametro=int(d)
            a=((diametro/2)**2)* math.pi
           ## print ("el area del circulo es:",a)
            return a
        else:
            print("Ha ingresado datos erróneos")
    elif(op==2):
        b=input("ingrese la base del triángulo: ")
        a=input("ingrese la altura del triángulo:")
        if((type(int(b))==type(0) or type(int(b))==type(0.0)) and (type(int(a))==type(0) or type(int(a))==type(0.0))):
            ar=(int(b)*int(a))/2
            print ("el area del triángulo es: ",ar)
        else:
            print("Ha ingresado datos erróneos")
        
    elif(op==3):
        l=input("ingrese la medida del lado del cuadrado: ")
        if(type(int(l))==type(0) or type(int(l))==type(0.0)):
            ar=int(l)**2
            print("el área del cuadrado es:",ar)
        else:
            print("Ha ingresado los datos erróneos")
    else:
        print("todavia no implementado")
        return
##revisar el método este de arriba la validacion no es completa

##Ciclo While ejemplos
def tablaMultiplicarWhile(n):
    i=0
    print("Tabla de multiplicar del: ",n )
    while(i<=12):
        a=n*i
        print(n,"X",i,"=",a)
        i+=1
    
##imprimir todos los números pares hasta "n" usando ciclo while y condicionales if
def imprimirPares(n):
    i=0
    while(i<=n):
        if(i%2==0):
            print(i,"Es par")
        i+=1
##imprimir la potencia de un número hasta "n"
def imprimirPotencia(n):
    
    i=0
    while(i<=n):
        a=math.pow(i,2)
        print (int(a))
        i+=1
##imprimir potencia mejorado
def Potencia_n():
    a=int(input("Hasta que número quiere obtener sus potencias: "))
    b=int(input("Ahora ingrese el valor para la potenciación: "))
    i=0
    while(i<=a):
        c=math.pow(i,b)
        print (i,"Potencia :",b,"=", int(c))
        i+=1
##imprimir tablas de multiplicar
def tablasDeMultiplicar():
    a=int(input("Ingrese hasta que tabla de multiplicar desea imprimir: "))
    i=1
    
    while(i<=a):
        h=0
        print("------------------")
        while(h<=12):
        
            b=h*i
            
            print(i,"X",h,"=",b)
            h+=1
        
        i+=1
        
    print("------------------")    
        
        
    
##imprimir tablas de multiplicar usando una funcion anidada
def tablaMultiplicarV2():
    a=int(input("ingrese hasta que tabla de multiplicar desea imprimir: "))
    i=1
    while(i<=a):
        b=tablaMultiplicarWhile(i)
        print (b)
        i+=1
        
##imprimir multiplos de 3 desde 100 hasta 200
def multiplosDeN():
    
    a=int(input("Ingrese el valor para devolver sus múltiplos: "))
    b=int(input("Ahora ingrese desde que número: "))
    c=int(input("Finalmente Hasta que número: "))
    while(b<=c):
        if(b%a==0):
            print(b, "Es múltiplo de", a)
        b+=1
##imprime los multiplos de cinco desde 1 a100 luego multiplos de  2 de 100 a 200
def multiplosDe5y2():
    i=1
    print("multiplos de cinco")
    print("--------------")
    while(i<=100):
        if(i%5==0):
            print(i)
        i+=1
    print("Multiplos de 2")
    print("--------------")
    while(i>=100 and i<=200):
        if(i%2==0):
            print(i)
        i+=1
def multiplosDe5y2_v2():
    i=1
    print("Multiplos de cinco y dos")
    print("------------------")
    while(i<=200):
    
    
        if(i>=1 and i<=100):
            if(i%5==0):
                print(i)

        if(i>=100 and i<=200):
            if(i%2==0):
                print(i)
        i+=1
        
## iterador reiniciado a cero cada vez que llegue a cinco
def estados():
    i=0
    while(True):
        print(i+1)
        i+=1
        if(i==5):
            i=0
##Trabajando con cadenas
##para saber la longitud de una cadena usar la funcion len(variableString)           
##para imprimir una letra poniendo su posicion se escribe print(cadenaa[0]) donde cero
##es la posición y para obtener la última letra de una cadena le hacemos con este truco
##ponemos print(cadena[len(cadena)-1])  así imprimirá el ultimo caracter restado a la longitud de la cadena,
def separandoCadena():
    n=input("Ingrese la palabra para separarla: ")
    i=0
    while(i<int(len(n))):
        print("posicion:",i,n[i])
        i+=1
##imprimir frase al revés con while
def cadenaAlReves():
    n=input("Ingrese la cadena para imprimirla al revés: ")
    i=len(n)-1
    while(i>=0):
        print(n[i])
        i-=1
##imprimir cadena con for, el for en python no te da control del índice
def cadenaFor():
    n=input("Ingrese la cadena para imprimirla: ")
    for i in n:
        print(i)
##imprimir concatenación de cadenas
def combinarCadena():
    a=input("Ingresa la base de la cadena: ")
    b=input("Ahora ingrese las letras lara adicionar a la base: ")
    for i in b:
        print(i+a)
##imprimiendo cadena separada por comas de forma muy simple
def segmentarCadena():
    
    a=str(input("Ingrese una serie de palabras separadas por comas: "))
    n =''
    for i in a:
        if(i=="," or i=="."):
            print(n)
            n=''
        else:
            n+=i
##imprimir cadenas por posiciones determinadas es ejem cadena[0:5] donde ceroes desde la posicion cero
##a la posicion cinco, tambien al comparar cadenas las analiza alfabéticamente ejm
##"banana"=="banana" da verdadero contando las coincidencias de las letras, diferenciando entre mayúsculas y minúsculas
##si comparamos "banana"<"Zapato" da false porque el ordenamiento es que las mayúsculas van primero y si
##no las primeras letras del alfabeto se consideran menores

##Más ejercicios con cadenas
def contarLetras():
    n=''
    a=input("Ingresa la palabra a examinar: ")
    b=input("Que letra quieres que el programa cuente: ")
    for i in a:
        if(i==b):
            
            n=n + i
    print("la cadena: ",a , "tiene", len(n),b)

##otra forma sencilla
def contarLetras1():
    temp=0
    a=input("Ingresa la palabra a examinar: ")
    b=input("Que letra quieres que el programa cuente: ")
    for i in a:
        if(i==b):
            temp+=1
    return temp
    
##trabajando con listas, las listas se escriben así  - variable=[1,2,3,"cadena",0.2] - ,
##como en todos los demas lenguajes es una lista ordenada que acepta sobreescritura, agregacion de datos,
##entre otros, el tamaño de una lista se obtiene con - len(lista) -

def imprimirLista():
    lista=["posición0","posición1","posición3"]
    i=0
    while(i<len(lista)):
        print(lista[i])
        i+=1
#lista que duplica el valor de cada número, sin usar métodos propiod de las listas
def listaDoble():
    i=1
    lista=[1,2,3,4,5,6]
    while(i<=len(lista)):
        a=i+i
        lista2=[a]
        print(lista2)
        i+=1
#la misma función de devolver el doble del valor ingresado en una lista pero mas elaborado
def listaDoble2(lista):
    listaDoble=[]
    i=0
    while(i<len(lista)):
        listaDoble(lista[i]*2)
        i +=1
    return b

def ejerciciosLista():
    lista=[1,2,3,4,2]
    i=0
    a=int(input("ingrese un número para agregarlo a la lista: "))
    lista.append(a)
    print ("La lista contiene: ",lista)
    while(i<len(lista)):
        print("indice-> ",i,"contiene->",lista[i])
        i+=1
    print()
    print("Ahora se ingresará un número antes del índice indicado por ud")
    b=int(input("primero ingrese el índice: "))
    c=int(input("Ahora ingrese el número que desee:"))
    lista.insert(b,c)
    h=0
    while(h<len(lista)):
        print("indice-> ",h,"contiene->",lista[h])
        h+=1
    print()
    e=int(input("Ahora último se removerá la primera coincidencia, escriba el número a remover de la lista: "))
    lista.remove(e)
    j=0
    while(j<len(lista)):
        print("indice-> ",j,"contiene->",lista[j])
        j+=1
    print()
    print("Por último removeremos un número en la posición que indiques")
    x=int(input("Ingresa el número que quiere eliminar: "))
    y=int(input("Ahora la posición de la coincidencia del número a eliminar: "))
    count=0
    z=0
    listaVacia=[]
    while(z<len(lista)):
        if(lista[z]==x):
            count+=1
            if(count!=y):
                
                listaVacia.append(lista[z])
        else:
            listaVacia.append(lista[z])
        z+=1
    w=0
    while(w<len(listaVacia)):
          
        print("indice-> ",w,"contiene->",listaVacia[w])
        w+=1
def listaPares(lista):
    for i in lista:
        
        if(i%2==0):
            print(i)
##pasarle toda una lista a otra que está vacía sin enlazarlas, para que un cambio en una no afecte
##a la otra lista_1=[1,2,3]-> lista_vacia=[] entonces lista_vacia=lista_1[:]
##Donde ":" significa un copiado de todo el contenido
def sumatoriaLista(lista):
    suma=0
    for i in lista:
        suma +=i
    return suma
def multiplicarLista(lista):
    mult=1
    for i in lista:
        mult *=i
    return mult
def sumarDosListas(lista1, lista2):
    suma=0
    for i in lista1:
        suma+=i
    for i in lista2:
        suma+=i
    return suma
##listas anidadad ejemLista=[1,2,3,[4,5,6]], si quiero acceder a una posicion de la lista anidada
## le digo así ejemLista[3][0], posicion 3, de la list principal y posicion 0 de la lista
## anidada me devuelve =4
##imprimirndo lista anidada
def listaAnidada():
    listaAnidada=[1,2,3,["a","b","c"]]
    for i in listaAnidada:
        if(type(i)!=type([])):
            print (i)
        elif(type(i)==type([])):
            for j in i:
                print(j)
##Matrices matriz=[[1,2,3],[4,5,6],[7,8,9]], como los arreglos multidimensionales
def imprimirMatriz():
    matriz=[[1,2,3],[4,5,6],[7,8,9]]
    for i in matriz:
        for j in i:
            print(j)

##Leer matriz pero con un ciclo while
def imprimirMatrizWhile():
    matriz=[[1,2,3],[4,5,6],[7,8,9]]
    h=0
    
    while(h<len(matriz)):
        i=0
        while(i<len(matriz[h])):
            print(matriz[h][i])
            i+=1
        h+=1
    
##operaciones con cadenas y listas - cadena="esto es un ejemplo", usar split()
##cadena.split() -> si no le ponemos nada nos lo traslada a una lista como esta
##['esto','es','un','ejemplo'], en split("") podemos poner el caracter por el cual
##queremos que nos divida la cadena
def splitMatriz():
    
    a=str(input("ingrese la frase o palabra que quiere mostrar en lista: "))
    b=a
    return b.split()
    
        
            


    


    

