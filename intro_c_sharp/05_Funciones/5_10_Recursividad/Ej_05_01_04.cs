/*(5.10.4) Crea un programa que emplee recursividad
 * para calcular la suma de los elementos de un vector
 * de números enteros, desde su posición inicial a la final,
 * usando una función recursiva que tendrá la apariencia:
 * SumaVector(v, desde, hasta). Nuevamente,
 * piensa cuál será el caso base
 * (cuántos elementos podrías sumar para que dicha suma sea trivial)
 * y cómo pasar del caso "n-1" al caso "n" (por ejemplo,
 * si conoces la suma de los 6 primeros elementos
 * y el valor del séptimo elemento, cómo podrías emplear
 * esta información para conocer la suma de los 7 primeros).
 */
 using System;
 
 public class Ejercicio_5_10_4
 {
	 public static int SumaVector(int[] v, int desde, int hasta)
	 {
		 int resultado;
		 
		 resultado = v[hasta];
		 
		 if(hasta == 1)
		 {
			 //Para salir sumo el último numero
			 resultado += v[desde];
		 }
		 else
		 {
			 //Siempre sumo uno anterior
			 resultado += SumaVector(v, hasta-2, hasta-1);
			 
		 }
		 
		 return resultado;
	 }
	 public static void Main()
	 {
		 int desde = 0;
		 int hasta = 5;
		 int resultado;
		 int[] vector = {3,4,5,5,8,342};
		 
		 resultado = SumaVector(vector, desde, hasta);
		 
		 Console.WriteLine(resultado);
	 }
 }
