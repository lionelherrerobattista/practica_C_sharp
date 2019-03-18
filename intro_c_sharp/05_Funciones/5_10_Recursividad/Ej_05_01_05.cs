/* (5.10.5) Crea un programa que emplee recursividad
 * para calcular el mayor de los elementos de un vector.
 * El planteamiento será muy similar al del ejercicio anterior.
 */
 using System;
 
 public class Ejercicio_5_10_5
 {
	 public static int MayorVector(int[] v, int desde, int hasta)
	 {
		 int mayor;

		 if(desde == hasta)//Salida, empiezo desde el caso trivial
		 {
			 mayor = v[hasta];
		 }
		 else
		 {
			mayor = MayorVector(v, desde+1, hasta);
			//va de atrás para adelante
			//desde = 4;
			//mayor = 6;
			//y comparo con el anterior...
			 
			 if(mayor < v[desde])
			 {
				 mayor = v[desde];
			 }
		 }
		 
		 return mayor;
	 }

	 
	 public static void Main()
	 {
		 int desde = 0;
		 int hasta = 5;
		 int resultado;
		 int[] vector = {3,2,9,5,8,6};
		 
		 resultado = MayorVector(vector, desde, hasta);
		 
		 Console.WriteLine(resultado);
	 }
 }
