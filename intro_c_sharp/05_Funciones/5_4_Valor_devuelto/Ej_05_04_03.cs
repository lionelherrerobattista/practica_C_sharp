/*(5.4.3) Crea una función llamada "Signo", que reciba un número real,
 * y devuelva un número entero con el valor: -1 si el número es negativo,
 * 1 si es positivo o 0 si es cero.
 */
 using System;
 
 public class Ejercicio_5_4_3
 {
	 //Función que indica si el número es negativo o positivo
	 public static int Signo(float numero)
	 {
		 int retornoSigno;
		 
		 if(numero > 0)
		 {
			 retornoSigno = 1;
		 }
		 else if(numero == 0)
		 {
			 retornoSigno = 0;
		 }
		 else
		 {
			 retornoSigno = -1;
		 }
		 
		 return retornoSigno;
	 }
	 public static void Main()
	 {
		 float numero;//número que le pido al usuario
		 
		 //Pido un número al usuario:
		 Console.Write("Escriba un numero para saber si es positivo,"
		  + " negativo o 0: ");
		 
		 numero = Convert.ToSingle(Console.ReadLine());
		 
		 if(Signo(numero) == 1)
		 {
			 Console.WriteLine("El número {0} es positivo.", numero);
		 }
		 else if(Signo(numero) == 0)
		 {
			 Console.WriteLine("El número es 0.");
		 }
		 else if(Signo(numero) == -1)
		 {
			 Console.WriteLine("El número {0} es negativo.", numero);
		 }
	 
	 }
 }
