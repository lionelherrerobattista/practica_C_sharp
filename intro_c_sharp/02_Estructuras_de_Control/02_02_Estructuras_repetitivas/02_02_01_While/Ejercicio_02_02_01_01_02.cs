/*
Crea un "calculador de cuadrados": pedir� al usuario un n�mero
y mostrar� su cuadrado. Se repetir�
mientras el n�mero introducido no sea cero (usa "while" para conseguirlo).
*/
using System;

public class Ejercicio_02_02_01_01_02
{
    public static void Main()
    {
	int numero;
	int cuadrado;

	Console.Write("Escriba un numero para calcular su cuadrado (0 para salir): ");
	numero = Convert.ToInt32(Console.ReadLine());
	cuadrado = numero * numero;
	Console.WriteLine("El cuadrado de {0} es {1}.", numero, cuadrado);

	while(numero != 0)
	{
	    Console.Write("Escriba un numero para calcular su cuadrado (0 para salir): ");
	    numero = Convert.ToInt32(Console.ReadLine());
	    cuadrado = numero * numero;
	    Console.WriteLine("El cuadrado de {0} es {1}.", numero, cuadrado);

	}

    }



}

