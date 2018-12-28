/*
(2.6.5) Crea un programa que "dibuje" un triángulo decreciente,
con la altura que indique el usuario
*/
using System;

public class Ejercicio_02_06_05
{
    public static void Main()
    {
	int altura;
	int contadorAlto;
	int contadorAncho;

	//Pido la altura del triángulo:
	Console.Write("Escriba la altura del triangulo: ");
	altura = Convert.ToInt32(Console.ReadLine());

	//Dibujo el triangulo
	for(contadorAlto = altura; contadorAlto >= 1; contadorAlto--)
	{
	    for(contadorAncho = contadorAlto; contadorAncho >= 1; contadorAncho--) //el ancho es = al contadorAltura que siempre decrece en 1
	    {
		Console.Write("*");
	    }
		
	    Console.WriteLine();
	}


    }
}