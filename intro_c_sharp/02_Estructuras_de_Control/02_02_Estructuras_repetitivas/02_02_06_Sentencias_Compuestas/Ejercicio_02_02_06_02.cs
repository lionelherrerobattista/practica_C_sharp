/*
(2.2.6.2) Crea un programa que pida al usuario el ancho (por ejemplo, 4)
 y el alto (por ejemplo, 3) y escriba un rectángulo formado
 por esa cantidad de asteriscos:
 ****
 ****
 ****
*/

using System;

public class Ejercicio_02_02_06_02
{
    public static void Main()
    {
	int ancho;
	int alto;
	int i;
	int j;

	Console.Write("Escriba el ancho: ");
	ancho = Convert.ToInt32(Console.ReadLine());

	Console.Write("Escriba el alto: ");
	alto = Convert.ToInt32(Console.ReadLine());

	for(i=alto; i>0; i--) //Le paso a i el valor que le dio el usuario
	{
	    for(j=ancho; j>0; j--) //Le paso a j el valor que dio el usuario
	    {
	        Console.Write("*");
	    }

	    Console.WriteLine(); //Paso a la nueva linea
	}

    }

}