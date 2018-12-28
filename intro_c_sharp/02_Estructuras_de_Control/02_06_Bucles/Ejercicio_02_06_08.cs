/*
(2.6.8) Crea un programa que devuelva el cambio de una compra,
utilizando monedas (o billetes) del mayor valor posible.
Supondremos que tenemos una cantidad ilimitada de monedas
(o billetes) de 100, 50, 20, 10, 5, 2 y 1, y que no hay decimales.
La ejecución podría ser algo como:
Precio? 44
Pagado? 100
Su cambio es de 56: 50 5 1
*/
using System;

public class Ejercicio_02_06_08
{
    public static void Main()
    {
	int precio;
	int pago;
	int vuelto;

	//Pido el precio y cuanto pagó el cliente:
	Console.Write("Precio?");
	precio = Convert.ToInt32(Console.ReadLine());

	Console.Write("Pago?");
	pago = Convert.ToInt32(Console.ReadLine());	
	
	//Calculo el vuelto
	vuelto = pago - precio;
	Console.Write("El vuelto es de {0}: ", vuelto);

	//Descuento el tamaño del billete mayor y lo escribo
	//hasta que el vuelto sea == 0:
	while(vuelto > 0)
	{
	    if(vuelto - 100 >= 0)
	    {
		Console.Write("100 "); //Escribo el billete que uso
		vuelto = vuelto - 100; //Descuento al vuelto
	    }
	    else
	    {
		if(vuelto - 50 >= 0)
		{
		    Console.Write("50 ");
		    vuelto = vuelto - 50;
		}
		else
		{
		    if(vuelto - 20 >= 0)
		    {
			Console.Write("20 ");
			vuelto = vuelto - 20;
		    }
		    else
		    {	
			if(vuelto - 10 >= 0)
			{
			    Console.Write("10 ");
			    vuelto = vuelto - 10;
			}
			else
			{
			    if(vuelto - 5 >= 0)
			    {
			        Console.Write("5 ");
			        vuelto = vuelto - 5;
			    }
			    else
			    {
				if(vuelto - 2 >= 0)
				{
  			            Console.Write("2 ");
			            vuelto = vuelto - 2;

				}
				else
				{
				    //Si no puedo descontar nada
				    Console.Write("1 ");
				    vuelto = vuelto - 1;
				}

			    }
			    
			}
		    }

		}
	    }


	}
	
    }
}