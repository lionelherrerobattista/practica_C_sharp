/*
Crea un programa que pida al usuario su contraseña (numérica).
Deberá terminar cuando introduzca como contraseña el número 1111,
pero volvérsela a pedir tantas veces como sea necesario
*/

using System;

public class Ejercicio_02_02_01_01_01
{
    public static void Main()
    {
	int password;

	Console.Write("Escriba su password (1111 para salir): ");
	password = Convert.ToInt32(Console.ReadLine());

	while (password != 1111)
	{
    	    Console.Write("Escriba su contraseña (1111 para salir): ");
	    password = Convert.ToInt32(Console.ReadLine());

	}
    }
}