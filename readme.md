# Evaluaci�n de Algoritmos de Ordenamiento

Este proyecto desarrolla una aplicaci�n de consola en C# para comparar el rendimiento de distintos algoritmos de ordenamiento sobre diferentes tipos de datos. El enfoque est� orientado a evaluar la eficiencia de los m�todos cl�sicos sobre grandes vol�menes de datos, siguiendo los lineamientos acad�micos de la carrera T�cnico Superior en Programaci�n de la UTN - Facultad Regional Paran�.

## Objetivos

* Implementar m�todos est�ticos de ordenamiento:
  * BubbleSort
  * MergeSort (recursivo)
  * QuickSort (recursivo)
  * QuickSort (iterativo)
  * SelectionSort 

* Probar dichos m�todos sobre:

  * Enteros de 32 y 64 bits
  * Reales de 32 bits (`float`) y 128 bits (`decimal`)
  * Strings de 8 y 32 caracteres de longitud
* Medir el tiempo de ejecuci�n para:

  * 100.000 elementos
  * 500.000 elementos
  * 1.000.000 elementos
  * 5.000.000 elementos

## Detalles de Ejecuci�n

* La muestra a ordenar se genera aleatoriamente con una semilla fija para garantizar condiciones homog�neas.
* Cada m�todo de ordenamiento se ejecuta sobre una copia de los datos originales.
* El tiempo de ejecuci�n se mide usando `DateTime.Now`.

## Estructura de Salida

Los resultados se muestran en consola en formato de tabla:

```
Tipo de Dato | M�todo            | Tiempo (ms)
-------------+-------------------+------------\
String 32    | BubbleSort        |      46970
String 32    | MergeSort         |         30
String 32    | Quick Recursivo   |         34
String 32    | Quick Iterativo   |         35
String 32    | SelectionSort     |      12908
...
```

## Caracter�sticas del Sistema

Al finalizar, se imprimen detalles del entorno:

* Sistema operativo
* Cantidad de procesadores
* Memoria RAM estimada disponible

## Ejecuci�n

Compilar y ejecutar el proyecto con cualquier entorno .NET compatible:

```bash
> dotnet build
> dotnet run
```

## Requisitos

* .NET Core SDK 6.0 o superior
* Sistema operativo Windows, Linux o macOS

## Autores
* Ansa, Santiago (@santiansaa)
* Vinzon, Alan (@Alanv3514)
* 
Proyecto realizado como parte de la asignatura Programaci�n 1 - T.U.P. UTN F.R. Paran�, 2025.
