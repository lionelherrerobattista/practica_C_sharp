/*(4.1.4.2) Crea una variante del ejemplo anterior (04_01_04a)
que añada un dato introducido por el usuario al final
 de los datos existentes.*/
 
 using System;
 
 public class Ejercicio_4_1_4_2
 {
	 public static void Main()
	 {
		int[] datos = {10, 15, 12, 0, 0};
		int capacidad = 5;
		int cantidad = 3;
		int i;
		int datoUsuario;

		
		if(capacidad != cantidad)
		{
			Console.Write("Escriba el dato a añadir: ");
			datoUsuario = Convert.ToInt32(Console.ReadLine());
			
			
			datos[cantidad] = datoUsuario;
			cantidad++; //Siempre es 1 más que el indice,
			//por eso sumo despues
			
		}

        for (i = 0; i < cantidad; i++)
        {

            Console.WriteLine(datos[i]);
        }
		
	 }
 }
