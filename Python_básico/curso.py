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
    
    
 
    
    



    


    

