/*
 * (3.5.3) Crea un programa que use el operador condicional
 *  para dar a una variable llamada "ambosPares" (booleana)
 *  el valor "true" si dos números introducidos por el usuario
 *  son pares, o "false" si alguno es impar.
 */
 using System;
 
 public class Ejercicio_3_5_3
 {
	 public static void Main()
	 {
		 int numeroUno;
		 int numeroDos;
		 bool ambosPares;
		 
		 Console.WriteLine("Escriba dos numeros para compararlos: ");
		 
		 Console.Write("Escriba un numero: ");
		 numeroUno = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Escriba otro numero: ");
		 numeroDos = Convert.ToInt32(Console.ReadLine());
		 
		 //Condicion para que sea true
		 ambosPares = (numeroUno % 2 == 0) && (numeroDos % 2 == 0);
		 
		 
		 if(ambosPares) //si es true
		 {
			 Console.WriteLine("Ambos son pares.");			 
		 }
		 else
		 {
			 Console.WriteLine("Alguno es impar.");
		 }
		 
	 }	 
 }
