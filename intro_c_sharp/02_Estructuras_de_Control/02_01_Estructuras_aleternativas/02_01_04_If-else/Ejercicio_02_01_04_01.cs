/*
Mejora la solución al ejercicio 2.1.3.1, usando "else".
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
	else
	{
	    if(numeroUno != 0)
	    {
		Console.Write("Ingrese otro numero: ");
		numeroDos = Convert.ToInt32(Console.ReadLine());

		producto = numeroUno * numeroDos;
		Console.WriteLine("El producto entre {0} y {1} es: {2}", numeroUno, numeroDos, producto);
	    }

	}
    }
}