/*(5.11.2) Crea una calculadora básica, llamada "calcula",
 * que deberá sumar, restar, multiplicar o dividir los dos números
 * que se le indiquen como parámetros.
 * Ejemplos de su uso sería "calcula 2 + 3" o "calcula 5 * 60".
 */
 using System;
 
 public class Ejercicio_5_11_2
 {
	 public static int Main(string[] argumentos)
	 {
		 char signo;
		 float numeroUno;
		 float numeroDos;
		 float resultado;
		 int codigoError = 0;
		 
		 //Si paso 1 o 2 argumentos
		 if(argumentos.Length == 3)
		 {
			 numeroUno = Convert.ToSingle(argumentos[0]);
			 signo = Convert.ToChar(argumentos[1]);
			 numeroDos = Convert.ToSingle(argumentos[2]);
			 
			 if(signo == '+')
			 {
				 resultado = numeroUno + numeroDos;				 
			 }
			 else
			 {
				 if(signo == '-')
				 {
					 resultado = numeroUno - numeroDos;					 
				 }
				 else
				 {
					 if(signo == '*')
					 {
						 resultado = numeroUno * numeroDos;						 
					 }
					 else
					 {
						 resultado = (float)numeroUno / numeroDos;						 
						 
					 }
				 }
				 
			 }
			 
			 //Muestro la suma
			 Console.WriteLine("Resultado: {0}", resultado);
		 }
		 else
		 {
			 Console.WriteLine("No tiene valor numérico válido");
			 codigoError = 2;			 
		 }
		 
		 //Devulevo el código de error
		 return codigoError;		 
	 }
 }
