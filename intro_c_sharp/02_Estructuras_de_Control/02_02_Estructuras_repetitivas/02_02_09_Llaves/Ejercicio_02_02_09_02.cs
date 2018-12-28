/*
(2.2.9.2) Crea un programa que pida al usuario dos números
y escriba sus divisores comunes. Debes usar llaves
en todas las estructuras de control,
aunque sólo incluyan una sentencia.
*/

using System;

public class Ejercicio_02_02_09_02
{
    public static void Main()
    {
	int numeroUno;
	int numeroDos;
	int divisor;

	Console.Write("Escriba un numero: ");
	numeroUno = Convert.ToInt32(Console.ReadLine());

	Console.Write("Escriba otro numero: ");
	numeroDos = Convert.ToInt32(Console.ReadLine());


	Console.Write("Sus divisores comunes son:");

	for(divisor=1; divisor <= numeroDos; divisor++)
	{
	    if((numeroUno % divisor == 0) && (numeroDos % divisor == 0))
	    {
		Console.Write("{0} ", divisor);

	    }

	}
    }



}