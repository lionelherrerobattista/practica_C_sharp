/*
Crea un programa que pida al usuario un número entero
y responda si no es múltiplo de 2 ni de 3
*/
using System;

public class Ejercicio_02_01_05_04
{
    public static void Main()
    {
	    int numeroUno;

	    Console.Write("Escriba un numero: ");
	    numeroUno = Convert.ToInt32(Console.ReadLine());
	
	    if(numeroUno % 2 != 0 && numeroUno % 3 != 0)
	    {
	        Console.WriteLine("No es multiplo de 2 ni de 3.");	
	    }
    }

}