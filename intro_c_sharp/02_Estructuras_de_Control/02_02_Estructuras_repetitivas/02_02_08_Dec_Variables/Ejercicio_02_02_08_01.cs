/*
(2.2.8.1) Crea un programa que escriba 6 l�neas de texto,
 cada una de las cuales estar� formada por los n�meros del 1 al 7.
 Debes usar dos variables
 llamadas "linea" y "numero", y ambas deben estar declaradas en el "for".
*/

using System;

public class Ejercicio_02_02_08_01
{
    public static void Main()
    {
	for(int linea=1; linea<=6; linea++) //Declaro la variable dentro del for
	{
	    for(int numero=1; numero<=7; numero++) //idem
	    {
		Console.Write("{0} ", numero);
	    }

	    Console.WriteLine();
	}
    }
}