/*
Crea un programa que use el operador condicional
para mostrar un el valor absoluto de un número de la siguiente forma:
si el número es positivo,
se mostrará tal cual; si es negativo, se mostrará cambiado de signo.
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