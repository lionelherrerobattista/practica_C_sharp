/*(4.2.2) Un programa que pida al usuario dos bloques
 * de 6 cadenas de texto. Después pedirá al usuario
 * una nueva cadena y comprobará si aparece en alguno
 * de los dos bloques de información anteriores.
 */
 using System;
 
 public class Ejercicio_4_2_2
 {
	 public static void Main()
	 {
		 string[,] cadenas = new string[2,6];
		 int i;
		 string cadenaUsuario;
		 //bools para saber si está la cadena
		 bool flagBloqueUno = false;
		 bool flagBloqueDos = false;
		 
		 //Pido información para las cadenas
		 Console.WriteLine("Escriba 6 cadenas para el primer bloque: ");
		 for(i = 0; i < 6; i++)
		 {
			 cadenas[0, i] = Console.ReadLine();
		 }
		 
		 Console.WriteLine("-----------------------------------------");
		 Console.WriteLine("Escriba 6 cadenas para el segundo bloque: ");
		 for(i = 0; i < 6; i++)
		 {
			 cadenas[1, i] = Console.ReadLine();
		 }
		 
		 //Pido la cadena que se quiere buscar
		 Console.WriteLine("-----------------------------------------");
		 Console.WriteLine("Escriba otra cadena para saber" +
		  " si aparece en alguno de los bloques:");
		 cadenaUsuario = Console.ReadLine();
		 
		 //Me fijo si está en alguno de los bloques
		 for(i = 0; i < 6; i++)
		 {
			 
			 if(string.Compare(cadenaUsuario, cadenas[0, i]) == 0)
			 {
				 flagBloqueUno = true;				 
			 }
		 }
		 
		 for(i = 0; i < 6; i++)
		 {
			 
			 if(string.Compare(cadenaUsuario, cadenas[1, i]) == 0)
			 {
				 flagBloqueDos = true;				 
			 }
		 }
		 
		 //Mensaje a mostrar 
		 Console.WriteLine("-----------------------------------------");
		 if(flagBloqueUno == true && flagBloqueDos == true)
		 {
			 Console.WriteLine("Aparece en ambos bloques");
		 }
		 else
		 {
			 if(flagBloqueUno == true)
			 {
				 Console.WriteLine("Aparece en el bloque 1.");
			 }
			 else
			 {
				 if(flagBloqueDos == true)
				 {
					 Console.WriteLine("Aparece en el bloque 2.");
				 }
				 else
				 {
					 Console.WriteLine("No aparece.");
				 }
			 }
		 }
		 
	 }
 }
