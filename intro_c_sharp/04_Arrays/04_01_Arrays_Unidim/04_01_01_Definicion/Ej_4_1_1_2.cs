/*
 * (4.1.1.2) Un programa que pida al usuario 5 números reales
 *  (pista: necesitarás un array de "float")
 *  y luego los muestre en el orden contrario al que se introdujeron.
 */
 using System; 
 
 public class Ejercicio_4_1_1_2
 {
	 public static void Main()
	 {
		 
		 float[] numeros = new float[5];
		 int indice;
		 int contadorNumeros=0;
		 
		 //Pido los numeros
		 for(indice = 0; indice < 5; indice++)
		 {
			 Console.Write("Ingrese el numero {0}: ", indice+1);
			 numeros[indice] = Convert.ToSingle(Console.ReadLine());
			 
			 contadorNumeros++;
		 }
		 
		 //Muestro los numeros al reves
		 Console.Write("Numeros introducidos: ");
		 //indice empieza en nros. totales - 1 y termina en 0 
		 for(indice = contadorNumeros-1; indice >= 0; indice--)
		 {
			 Console.Write("\"{0}\" ", numeros[indice]);			 
		 }
		 
	 }
 }
