/*
(2.6.6) Crea un programa que "dibuje" un rectángulo hueco,
cuyo borde sea una fila (o columna) de asteriscos y cuyo interior esté formado por espacios en blanco,
con el ancho y el alto que indique el usuario. 
*/
using System;

public class Ejercicio_02_06_06
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
		if(contadorAncho == 1 || contadorAncho == ancho)
		{
		    Console.Write("*"); //Escribo los * en los bordes
		}
		else
		{
		    if((contadorAltura != alto) && (contadorAltura != 1))
		    {
		        Console.Write(" ");//Espacio en blanco en el medio
		    }
		    else
		    {
			Console.Write("*");//En los bordes superiores tambien completo con *
		    }
		}
		
	    }
	
	    Console.WriteLine(); //Paso a la siguiente linea
	}
    }
}


