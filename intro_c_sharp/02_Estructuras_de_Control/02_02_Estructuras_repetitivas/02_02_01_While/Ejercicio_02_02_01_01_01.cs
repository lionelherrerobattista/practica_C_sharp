/*
Crea un programa que pida al usuario su contrase�a (num�rica).
Deber� terminar cuando introduzca como contrase�a el n�mero 1111,
pero volv�rsela a pedir tantas veces como sea necesario
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
    	    Console.Write("Escriba su contrase�a (1111 para salir): ");
	    password = Convert.ToInt32(Console.ReadLine());

	}
    }
}