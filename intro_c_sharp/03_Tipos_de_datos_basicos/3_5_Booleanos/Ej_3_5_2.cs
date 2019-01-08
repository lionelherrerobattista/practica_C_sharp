/*
 * (3.5.2) Crea una versión alternativa del ejercicio 3.5.1,
 *  que use "if" en vez del operador condicional.
 */
 using System;
 
 public class Ejercicio_3_5_2
 {
	 public static void Main()
	 {
		 bool iguales; //true o false
		 int numeroUno;
		 int numeroDos;
		 
		 Console.WriteLine("Escriba dos numeros para compararlos:");
		 
		 Console.Write("Escriba un numero: ");
		 numeroUno = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Escriba otro numero: ");
		 numeroDos = Convert.ToInt32(Console.ReadLine());
		 
		 //Escribo la condicion para que el bool sea true
		 //Notacion con if
		 if(numeroUno == numeroDos)
		 {
			 iguales = true;			 
		 }
		 else
		 {
			 iguales = false;
		 }
		 
		 
		 if(iguales) //Si iguales es true
		 {
			 Console.WriteLine("Los numeros son iguales.");
		 }
		 else
		 {
			 Console.WriteLine("No son iguales.");
		 }
		 
	 }
 }
