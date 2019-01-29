/*(4.4.3.3) Un programa que pida al usuario una frase, después
 * una letra y finalmente diga si aparece esa letra como parte
 * de esa frase o no.
 */
 using System;
 
 public class Ejericio_4_4_3_3
 {
	 public static void Main()
	 {
		 string frase;
		 char letra;
		 int longitud;
		 int i;
		 bool encontroLetra = false;
		 
		 //Pido frase y letra
		 Console.Write("Escriba un frase: ");
		 frase = Console.ReadLine();
		 
		 Console.Write("Escriba la letra a buscar: ");
		 //usar convert to char
		 letra = Convert.ToChar(Console.ReadLine());
		 
		 //Saco la longitud
		 longitud = frase.Length;
		 
		 for(i = 0; i < longitud; i++)
		 {
			 if(frase[i] == letra)
			 {
				 encontroLetra = true;
			 }
		 }
		 
		 Console.WriteLine("-----------------------------------------");
		 if(encontroLetra == true)
		 {
			 Console.WriteLine("Se encontró la letra.");
		 }
		 else
		 {
			 Console.WriteLine("No se encontró.");
		 }
	 }
 }
