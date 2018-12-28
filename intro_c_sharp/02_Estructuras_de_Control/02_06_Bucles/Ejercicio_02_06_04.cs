/*
(2.6.4) Crea un programa que "dibuje" un rectángulo formado por asteriscos,
con el ancho y el alto que indique el usuario, usando dos "for" anidados.
*/

using System;

public class Ejercicio_02_06_04
{
    public static void Main()
    {
	int alto;
	int ancho;
	int contadorAncho;
	int contadorAltura;

	//Pido al usuario el ancho y el alto:
	Console.Write("Escriba el alto del rectangulo: ");
	alto = Convert.ToInt32(Console.ReadLine());

	Console.Write("Escriba el ancho del rectangulo: ");
	ancho = Convert.ToInt32(Console.ReadLine());	

	//Dibujo el cuadrado:
	for(contadorAltura = 1; contadorAltura <= alto; contadorAltura++)
	{
	    for(contadorAncho = 1; contadorAncho <= ancho; contadorAncho++)
	    {

		Console.Write("*"); //Escribo los * según el ancho elegido
	    }
	
	    Console.WriteLine(); //Paso a la siguiente linea
	}
    }


}