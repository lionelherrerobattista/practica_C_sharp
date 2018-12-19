/*
Crea un programa que multiplique dos n�meros enteros de la siguiente forma:
 pedir� al usuario un primer n�mero entero.
 Si el n�mero que se que teclee es 0,
 escribir� en pantalla "El producto de 0 por cualquier n�mero es 0".
 Si se ha tecleado un n�mero distinto de cero,
 se pedir� al usuario un segundo n�mero y se mostrar� el producto de ambos.
*/

using System;

public class Ejercicio_02_01_03_01
{
    public static void Main()
    {
        int numeroUno;
	int numeroDos;
	int producto;
	
	Console.Write("Ingrese un numero: ");
	numeroUno = Convert.ToInt32(Console.ReadLine()); 

	if(numeroUno == 0)
	{
	    Console.WriteLine("El producto de 0 por cualquier n�mero es 0");
	}

	if(numeroUno != 0)
	{
	    Console.Write("Ingrese otro numero: ");
	    numeroDos = Convert.ToInt32(Console.ReadLine());

	    producto = numeroUno * numeroDos;
	    Console.WriteLine("El producto entre {0} y {1} es: {2}", numeroUno, numeroDos, producto);

	}
    }
}