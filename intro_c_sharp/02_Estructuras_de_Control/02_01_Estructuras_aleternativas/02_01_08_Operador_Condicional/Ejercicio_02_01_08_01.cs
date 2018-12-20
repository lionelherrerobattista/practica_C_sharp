/*
Crea un programa que use el operador condicional
para mostrar un el valor absoluto de un n�mero de la siguiente forma:
si el n�mero es positivo,
se mostrar� tal cual; si es negativo, se mostrar� cambiado de signo.
*/
using System;

public class Ejercicio_02_01_08_01
{
    public static void Main()
    {
	int numero;
	int valorAbsoluto;

	Console.Write("Ingrese un numero: ");
	numero = Convert.ToInt32(Console.ReadLine());
	
	valorAbsoluto =	numero > 0 ? numero : (-1) * numero; //Si es positivo valorAbsoluto = numero sino lo paso a positivo

	Console.WriteLine("El valor absoluto es {0}", valorAbsoluto);
    }


}