/*
(2.6.9) Crea un programa que "dibuje" un cuadrado formado por cifras sucesivas,
con el tamaño que indique el usuario, hasta un máximo de 9.
*/
using System;

public class Ejercicio_02_06_09
{
    public static void Main()
    {
	int tam; //Tamaño del cuadrado
	int contadorAncho;
	int contadorAlto;

	Console.Write("Escriba el tamano del cuadrado: ");
	tam = Convert.ToInt32(Console.ReadLine());

	for(contadorAlto = 1; contadorAlto <= tam; contadorAlto++)
	{
	    for(contadorAncho = 1; contadorAncho <= tam; contadorAncho++)
	    {
		Console.Write("{0}", contadorAlto); //Uso la variable contadorAlto para escribir los numeros
	    }

	    Console.WriteLine(); //Paso a la siguiente linea
	}

    }
}