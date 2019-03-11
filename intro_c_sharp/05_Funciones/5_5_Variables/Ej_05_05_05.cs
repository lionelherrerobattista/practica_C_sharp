/*(5.5.5) Crea una función "SumaCifras" que reciba un numero cualquiera
 * y que devuelva como resultado la suma de sus dígitos. Por ejemplo,
 * si el número fuera 123 la suma sería 6.
 */
 using System;
 
 public class Ejercicio_5_5_5
 {
	 //Función que suma las cifras de un numero ingresado por el usuario
	 public static int SumarCifras(string numeroUsuario)
	 {
		 int sumaCifras = 0;
		 int i;
		 
		 //Recorro el numero cómo cadena
		 for(i = 0; i < numeroUsuario.Length; i++)
		 {	 
			 sumaCifras +=
			  Convert.ToInt32(Convert.ToString(numeroUsuario[i]));
			  //Paso el Char a string para que Convert no devuelva
			  // el valor ASCII
		 }
		 
		 return sumaCifras;
	 }
	 
	 public static void Main()
	 {
		 string numeroUsuario;
		 int sumaCifras;
		 
		 //Pido que el usuario ingrese un número
		 Console.WriteLine("Ingrese un número para conocer la suma "
		  + "de sus cifras.");
		 
		 numeroUsuario = Console.ReadLine();
		 
		 //Sumo las cifras
		 sumaCifras = SumarCifras(numeroUsuario);
		 
		 //Muestro la suma de las cifras
		 Console.WriteLine("La suma de las cifras de {0} es: {1}",
		  numeroUsuario, sumaCifras);
		 
	 }
 }
