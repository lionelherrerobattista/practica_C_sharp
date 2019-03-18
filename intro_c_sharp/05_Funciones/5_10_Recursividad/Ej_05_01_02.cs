/*(5.10.2) Como alternativa, crea una función que calcule el valor
 * de elevar un número entero a otro número entero de forma NO recursiva
 * (lo que llamaremos "de forma iterativa"), usando la orden "for".
 */
 using System;
 
 public class Ejercicio_5_10_2
 {
	 public static long PotenciaNoRecursiva(int numero, int exponente)
	 {
		 long resultado;
		 int i;
		 
		 resultado = numero;
		 
		 //Forma iterativa
		 for(i = 1; i < exponente; i++)
		 {
			 resultado *= numero;			 
		 }
		 
		 return resultado;
		 
	 }
	 public static void Main()
	 {
		int numero;
		int exponente;
		long resultado;
		
		//Pido los datos
		Console.WriteLine("Ingrese la base y el exponente" +
		 " para calcular su potencia:");
		
		Console.Write("Base: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Exponente: ");
		exponente = Convert.ToInt32(Console.ReadLine());
		
		//Calculo el resultado
		resultado = PotenciaNoRecursiva(numero, exponente);
		
		//Lo muestro
		Console.WriteLine(resultado);
		 
	 }
 }
