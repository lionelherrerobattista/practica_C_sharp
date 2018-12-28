/*
(2.2.8.2) Crea un programa que pida al usuario el ancho (por ejemplo, 4)
y el alto (por ejemplo, 3)
y escriba un rectángulo formado
por esa cantidad de asteriscos, como en el ejercicio 2.2.6.2.
Deberás usar las variables "ancho" y "alto" para los datos
que pidas al usuario, y las variables "filaActual" y "columnaActual"
(declaradas en el "for") para el bloque repetitivo.
*/
using System;

public class Ejercicio_02_02_08_02
{
    public static void Main()
    {
	int ancho;
	int alto;

	Console.Write("Escriba el ancho del rectangulo: ");
	ancho = Convert.ToInt32(Console.ReadLine());

	Console.Write("Escriba el alto del rectangulo: ");
	alto = Convert.ToInt32(Console.ReadLine());

	for(int filaActual = alto; filaActual>0; filaActual--)
	{
	    for(int columnaActual = ancho; columnaActual > 0; columnaActual--)
	    {
		Console.Write("*");
	    }
	
	    Console.WriteLine();


	}

    }
}