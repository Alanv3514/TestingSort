# Evaluación de Algoritmos de Ordenamiento

Este proyecto desarrolla una aplicación de consola en C# para comparar el rendimiento de distintos algoritmos de ordenamiento sobre diferentes tipos de datos. El enfoque está orientado a evaluar la eficiencia de los métodos clásicos sobre grandes volúmenes de datos, siguiendo los lineamientos académicos de la carrera Técnico Superior en Programación de la UTN - Facultad Regional Paraná.

## Objetivos

* Implementar métodos estáticos de ordenamiento:
  * BubbleSort
  * MergeSort (recursivo)
  * QuickSort (recursivo)
  * QuickSort (iterativo)
  * SelectionSort 

* Probar dichos métodos sobre:

  * Enteros de 32 y 64 bits
  * Reales de 32 bits (`float`) y 128 bits (`decimal`)
  * Strings de 8 y 32 caracteres de longitud
* Medir el tiempo de ejecución para:

  * 100.000 elementos
  * 500.000 elementos
  * 1.000.000 elementos
  * 5.000.000 elementos

## Detalles de Ejecución

* La muestra a ordenar se genera aleatoriamente con una semilla fija para garantizar condiciones homogéneas.
* Cada método de ordenamiento se ejecuta sobre una copia de los datos originales.
* El tiempo de ejecución se mide usando `DateTime.Now`.

## Estructura de Salida

Los resultados se muestran en consola en formato de tabla:

```
Tipo de Dato | Método            | Tiempo (ms)
-------------+-------------------+------------\
String 32    | BubbleSort        |      46970
String 32    | MergeSort         |         30
String 32    | Quick Recursivo   |         34
String 32    | Quick Iterativo   |         35
String 32    | SelectionSort     |      12908
...
```

## Características del Sistema

Al finalizar, se imprimen detalles del entorno:

* Sistema operativo
* Cantidad de procesadores
* Memoria RAM estimada disponible

## Ejecución

Compilar y ejecutar el proyecto con cualquier entorno .NET compatible:

```bash
> dotnet build
> dotnet run
```

## Requisitos

* .NET Core SDK 6.0 o superior
* Sistema operativo Windows, Linux o macOS

## Autores
* [Ansa, Santiago](https://github.com/santiansaa)
* [Vinzon, Alan](https://github.com/Alanv3514)
* [Torrilla, Agustin](https://github.com/Agus-Torri05)

Proyecto realizado como parte de la asignatura Programación 1 - T.U.P. UTN F.R. Paraná, 2025.
