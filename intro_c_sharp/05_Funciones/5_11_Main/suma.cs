/*(5.11.1) Crea un programa llamado "suma", que calcule (y muestre)
 * la suma de dos números que se le indiquen como parámetros
 * en línea de comandos. Por ejemplo, si se teclea "suma 2 3" 
 * deberá responder "5", si se teclea "suma 2" responderá "2"
 * y si se teclea únicamente "suma" deberá responder
 * "no hay suficientes datos" y devolver un código de error 1.
 */
 using System;
 
 public class Ejercicio_5_11_1
 {
	 public static int Main(string[] argumentos)//string[] para tomar los argumentos que les paso por linea de comandos
	 {
		 int i;
		 int suma = 0;
		 int codigoError = 0;
		 
		 //Si paso 1 o 2 argumentos
		 if(argumentos.Length == 1 || argumentos.Length == 2)
		 {
			 for(i = 0; i < argumentos.Length; i++)
			 {
				 //sumo los argumentos
				 suma += Convert.ToInt32(argumentos[i]);
			 }
			 
			 //Muestro la suma
			 Console.WriteLine("Suma: {0}", suma);
		 }
		 else
		 {
			 Console.WriteLine("No hay suficientes datos.");
			 codigoError = 1;			 
		 }
		 
		 //Devulevo el código de error
		 return codigoError;
	 
	 }
 }
