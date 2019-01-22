/*(4.2.5) Un programa que calcule el determinante de una matriz de 3x3.
 */
 using System;
 
 public class Ejercicio_4_2_5
 {
	 public static void Main()
	 {
		 int[,] matriz = new int[3,3];
		 int i;
		 int j;
		 int determinante;
		 
		 Console.WriteLine("Ingrese los datos de la matriz 3*3" +
		  " para calcular su determinante");
		 
		 //columnas
		 for(i = 0; i < 3; i++)
		 {
			 //filas
			 for(j = 0; j < 3; j++)
			 {
				 Console.Write("Ingrese el elemento a{0}{1}: ", i+1,j+1);
				 matriz[i,j] = Convert.ToInt32(Console.ReadLine());
			 }
		 }
		 
		 //Calculo la determinante
		 determinante = (matriz[0,0] * matriz [1,1] * matriz[2,2]) +
		  (matriz[1,0] * matriz[2,1] * matriz[0,2]) +
		   (matriz[0,1] * matriz[1,2] * matriz[2,0]) - 
		   (matriz[0,2] * matriz[1,1] * matriz[2,0]) -
		    (matriz[1,2] * matriz[2,1] * matriz[0,0]) -
		     (matriz[1,0] * matriz[0,1] * matriz[2,2]);  
		   
		 Console.WriteLine("La determinante es: {0}", determinante);

	 }
 }
