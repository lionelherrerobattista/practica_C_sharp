/*El usuario teclear� dos n�meros (a y b), y el programa mostrar� el resultado de la operaci�n (a+b)*(a-b)
 y el resultado de la operaci�n a^2-b^2.*/
using System;

public class Ejercicio_1_11_1
{
	public static void Main()
	{
		int a;
		int b;
		int resultadoUno;
		int resultadoDos;
		
		Console.Write("Escriba un numero: ");
		a= Convert.ToInt32(Console.ReadLine());

		Console.Write("Escriba otro numero: ");
		b = Convert.ToInt32(Console.ReadLine());

		resultadoUno = (a+b)*(a-b);
		resultadoDos = a*a-b*b;

		Console.WriteLine("El primer resultado es {0} y el segundo {1}.",
		 resultadoUno, resultadoDos);
	
	}
}