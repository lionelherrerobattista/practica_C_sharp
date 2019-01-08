/*
 * (3.5.1) Crea un programa que use el operador condicional
 *  para dar a una variable llamada "iguales" (booleana)
 *  el valor "true" si los dos números que ha tecleado el usuario
 *  son iguales, o "false" si son distintos.
 */
 using System;
 
 public class Ejercicio_3_5_1
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
		 //Notacion alternativa sin usar if
		 iguales = (numeroUno == numeroDos);
		 
		 
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
