/*
Usa el operador condicional para calcular el menor de dos números
*/

using System;

public class Ejercicio_02_01_08_02
{
    public static void Main()
    {
	int numeroUno;
	int numeroDos;
	int menor;

	Console.Write("Escriba un numero: ");
	numeroUno = Convert.ToInt32(Console.ReadLine());

	Console.Write("Escriba un numero: ");
	numeroDos = Convert.ToInt32(Console.ReadLine());

	menor = numeroUno < numeroDos ? numeroUno : numeroDos;

	Console.WriteLine("El menor es {0}", menor);


    }

}