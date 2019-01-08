/*
 * (4.1.1.1) Un programa que pida al usuario 4 números,
 *  los memorice (utilizando un array), calcule su media aritmética
 *  y después muestre en pantalla la media y los datos tecleados.
 */
 using System;
 
 public class Ejercicio_4_1_1_1
 {
	 public static void Main()
	 {
		 int[] numeros = new int[4]; //declaro el array y le doy el tamaño
		 int indice;
		 int acumuladorNumeros=0;//Guardo la sumatoria
		 int contadorNumeros=0; //Cuento la cantidad de nros. ingresados
		 float media;
		 
		 Console.WriteLine("Escriba 4 numeros para saber su media: ");
		 
		 //Cargo el array con los datos
		 for(indice = 0; indice < 4; indice++)
		 {
			 Console.Write("Numero {0}: ", indice+1);
			 numeros[indice]= Convert.ToInt32(Console.ReadLine());
			 
			 acumuladorNumeros += numeros[indice];
			 contadorNumeros++;
		 }
		 
		 //Casteo a float para que tome la parte decimal
		 media = (float)acumuladorNumeros / contadorNumeros;
		 
		 Console.Write("Los datos ingresados son: ");
		 
		 //Recorro el array
		 for(indice = 0; indice < 4; indice++)
		 {
			 Console.Write("\"{0}\" ", numeros[indice]);
		 }
		 
		 Console.WriteLine();
		 Console.WriteLine("La media es {0}", media.ToString("N2"));//Muestro con dos decimales

		 
		 
	 }
 }
