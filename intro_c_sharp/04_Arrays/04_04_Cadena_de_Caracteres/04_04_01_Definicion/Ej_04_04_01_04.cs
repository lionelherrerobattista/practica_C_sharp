/*(4.4.1.4) Crea un programa que pida al usuario dos números enteros
 * y después una operación que realizar con ellos.
 * La operación podrá ser "suma", "resta", multiplicación" y "división",
 * que también se podrán escribir de forma abreviado
 *  con los operadores matemáticos "+", "-", "*" y "/".
 *  Para multiplicar también se podrá usar una "x", minúscula
 *  o mayúscula. A continuación se mostrará el resultado
 *  de esa operación (por ejemplo, si los números son 3 y 6
 *  y la operación es "suma", el resultado sería 9).
 *  La operación debes tomarla como una cadena de texto
 *  y analizarla con un "switch".
 */
 using System;
 
 public class Ejercicio_4_4_1_4
 {
	 public static void Main()
	 {
		 string respuestaUsuario;
		 int numeroUno;
		 int numeroDos;
		 float resultado;
		 
		 //Pido los dos numeros
		 Console.WriteLine("Ingrese dos números");
		 Console.WriteLine("-----------------------------------------");
		 Console.Write("Primer número: ");
		 numeroUno = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Segundo número: ");
		 numeroDos = Convert.ToInt32(Console.ReadLine());
		 Console.WriteLine("-----------------------------------------");
		 //Pido el tipo de operación
		 Console.WriteLine("Ingrese la operación a realizar: ");
		 Console.Write("(suma, resta, multiplicación o división): ");
		 respuestaUsuario = Console.ReadLine();
		 Console.WriteLine("-----------------------------------------");
		 
		 //switch con las operaciones
		 switch(respuestaUsuario)
		 {
			 case "suma":
			   resultado = numeroUno + numeroDos;
			   Console.WriteLine("Resultado: {0}", resultado);
			   break;
			 case "resta":
			   resultado = numeroUno - numeroDos;
			   Console.WriteLine("Resultado: {0}", resultado);
			   break;
			 case "multiplicacion":
			   resultado = numeroUno * numeroDos;
			   Console.WriteLine("Resultado: {0}", resultado);
			   break;
			 case "division":
			   resultado = (float)numeroUno / numeroDos;
			   Console.WriteLine("Resultado: {0}", resultado);
			   break;
			 
		 }
		 
	 }
	 
 }
