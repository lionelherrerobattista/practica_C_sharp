/*(4.1.3.8) Un programa que reserve espacio para un vector
 * de 3 componentes, pida al usuario valores para dichas componentes
 *  (por ejemplo [2, -5, 7]) y muestre su módulo
 *  (raíz cuadrada de la suma de sus componentes al cuadrado).
 */
 using System;
 
 public class Ejercicio_4_1_3_8
 {
	 public static void Main()
	 {
		 int[] vector = new int[3];
		 int i;
		 double modulo;
		 int acumuladorComponentes=0;
		 
		 Console.WriteLine("Ingrese los 3 componentes del vector" +
		  " para calcular su módulo: ");
		 
		 //Pido los componentes y los guardo 
		 for(i = 0; i < 3; i++)
		 {
			 vector[i] = Convert.ToInt32(Console.ReadLine());
			 //Guardo las potencias al cuadrado en un acumulador
			 acumuladorComponentes += (vector[i] * vector[i]);
		 }
		 
		 //Calculo el módulo
		 modulo = Math.Sqrt(acumuladorComponentes);
		 
		 Console.Write("El modulo del vector es {0}", modulo);
		 
	 }
 }
