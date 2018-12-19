/*
Crea un programa que multiplique dos números enteros de la siguiente forma:
 pedirá al usuario un primer número entero.
 Si el número que se que teclee es 0,
 escribirá en pantalla "El producto de 0 por cualquier número es 0".
 Si se ha tecleado un número distinto de cero,
 se pedirá al usuario un segundo número y se mostrará el producto de ambos.
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
	    Console.WriteLine("El producto de 0 por cualquier número es 0");
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