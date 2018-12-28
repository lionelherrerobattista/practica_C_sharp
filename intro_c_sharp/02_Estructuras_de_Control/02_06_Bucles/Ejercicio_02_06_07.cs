/*
(2.6.7) Crea un programa que "dibuje" un triángulo creciente,
alineado a la derecha, con la altura que indique el usuario.
*/
using System;

public class Ejercicio_02_06_07
{
    public static void Main()
    {
	int alto;
	int contadorAlto;
	int contadorEspacio;
	int contadorAsterisco;
	
	Console.Write("Escriba el alto del triangulo: ");
	alto = Convert.ToInt32(Console.ReadLine());

	for(contadorAlto = alto; contadorAlto >= 1; contadorAlto--)
	{
	    //Dibujo los espacios en blanco:
	    for(contadorEspacio = contadorAlto - 1; contadorEspacio >= 1; contadorEspacio--) // -1 para dejar espacio a los asteriscos
	    { 
		Console.Write(" "); //Dejo los espacios para alinear el triangulo a la derecha
	    }

	    //Dibujo los asteriscos
	    for(contadorAsterisco = 0; contadorAsterisco <= alto - contadorAlto; contadorAsterisco++) //alto - los espacios en blanco
	    {
	        Console.Write("*");
	    }

	    Console.WriteLine(); //Paso a la siguiente linea
	}

    }
}