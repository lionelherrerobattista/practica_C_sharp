/*(5.9.2.2) Crea un programa que halle cualquier raíz
 * (de cualquier orden) de un número. El usuario deberá indicar
 * el número (por ejemplo, 2) y el índice de la raíz
 * (por ejemplo, 3 para la raíz cúbica). Pista: hallar
 * la raíz cúbica de 2 es lo mismo que elevar 2 a 1/3.
 */
 using System;
 
 public class Ejercicio_5_9_2_2
 {
	 public static void Main()
	 {
		 double numero;
		 double indice;
		 double resultado;
		 
		 //Pido al usuario el numero:
			 Console.Write("Escriba el radicando: ");
			 numero = Convert.ToDouble(Console.ReadLine());
			 
			 Console.Write("Escriba el índice: ");
			 indice = Convert.ToDouble(Console.ReadLine());
			 
			 //Calculo el resultado:
			 resultado = Math.Pow(numero, 1d/indice);// un numero elevado a 1/2 es == a la raiz cuadrada
			 
			 Console.WriteLine("La raiz {0}° de {1} es igual a {2}", indice,
			 numero, resultado);
		  
		 
	 }
 }
