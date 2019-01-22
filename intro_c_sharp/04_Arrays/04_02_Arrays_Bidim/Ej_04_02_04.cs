/*(4.2.4) Un programa que calcule el determinante de una matriz de 2x2.
 */
 using System;
 
 public class Ejercicio_4_2_4
 {
	 public static void Main()
	 {
		 int[,] matriz = new int[2,2];
		 int i;
		 int j;
		 int determinante;
		 
		 Console.WriteLine("Ingrese los datos de la matriz 2*2" +
		  " para calcular su determinante");
		 
		 //columnas
		 for(i = 0; i < 2; i++)
		 {
			 //filas
			 for(j = 0; j < 2; j++)
			 {
				 Console.Write("Ingrese el elemento a{0}{1}: ", i+1,j+1);
				 matriz[i,j] = Convert.ToInt32(Console.ReadLine());
			 }
		 }
		 
		 //Calculo la determinante
		 determinante = (matriz[0,0] * matriz [1,1]) - (matriz[0,1] *
		   matriz[1,0]);
		   
		 Console.WriteLine("La determinante es: {0}", determinante);
		 
	 }
 }
