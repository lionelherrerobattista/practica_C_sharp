/*(5.5.2) Crea una función "EscribirTablaMultiplicar", que reciba
 * como parámetro un número entero, y escriba la tabla de multiplicar
 * de ese número (por ejemplo, para el 3 deberá llegar desde "3x0=0"
 * hasta "3x10=30").
 */
 using System;
 
 public class Ejercicio_5_5_2
 {
	 //Función que muestra la tabla de multiplicar de un número elegido
	 //por el usuario
	 public static void EscribirTablaMultiplicar(int numero)
	 {
		 int multiplicador;
		 int resultado;
		 
		 Console.WriteLine("-----------------------------------------");
		 Console.WriteLine("{0, 10} {1}", "Tabla de multiplicar de" , numero);
		 Console.WriteLine("-----------------------------------------");
		 
		 //muestro la tabla:
		 for(multiplicador = 0; multiplicador < 11; multiplicador++)
		 {
			 resultado = numero * multiplicador;
			 
			 Console.WriteLine("{0, 4}   x {1, 3}   = {2, 3}", numero, multiplicador,
			  resultado);			 
		 }
	 }
	 
	 public static void Main()
	 {
		 int numeroUsuario;
		 
		 //Pido el número al usuario:
		 Console.WriteLine("Escriba un número para ver su tabla de" +
		 " multiplicar.");
		 
		 numeroUsuario = Convert.ToInt32(Console.ReadLine());
		 
		 //Muestro la tabla:
		 EscribirTablaMultiplicar(numeroUsuario);
	 }
 }
