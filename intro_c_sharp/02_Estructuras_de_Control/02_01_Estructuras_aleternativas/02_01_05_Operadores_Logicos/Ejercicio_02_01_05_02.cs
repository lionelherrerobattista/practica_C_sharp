/*
Crea un programa que pida al usuario un n�mero entero
y responda si es m�ltiplo de 2 y de 3 simult�neamente.
*/
using System;

public class Ejercicio_02_01_05_02
{
    public static void Main()
    {
	    int numeroUno;

	    Console.Write("Escriba un numero: ");
	    numeroUno = Convert.ToInt32(Console.ReadLine());
	
	    if(numeroUno % 2 == 0 && numeroUno % 3 == 0)
	    {
	        Console.WriteLine("Es multiplo de 2 y de 3 simultaneamente");	
	    }


    }



}