/*(5.7.2) Crea una función "Iniciales", que reciba una cadena
 * como "Nacho Cabanes" y devuelva las letras N y C (primera letra,
 * y letra situada tras el primer espacio), usando parámetros
 * por referencia. Crea un "Main" que te permita comprobar
 * que funciona correctamente.
 */
 using System;
 
 public class Ejercicio_5_7_2
 {
	 //Función que muestra las iniciales del nombre y del apellido
	 public static void Iniciales(string nombre, ref char inicialNombre,
	  ref char inicialApellido)//paso los valores por referencia
	 {
		 int indice;
		 
		 //Primer inicial
		 inicialNombre = Char.ToUpper(nombre[0]);
		 
		 //Busco el apellido tras el espacio
		 for(indice = 1; indice < nombre.Length; indice++)
		 {
			 if(nombre[indice-1] == ' ')
			 {
				 inicialApellido = Char.ToUpper(nombre[indice]);
				 break;
			 }
		 }
	 }
	 
	 public static void Main()
	 {
		 string nombre;
		 //si paso los valores por referencia tengo que darles primero
		 //un valor inicial
		 char letra1 = 'a';
		 char letra2 = 'a';
		 
		 //Pido el nombre y el apellido:
		 Console.WriteLine("Ingrese su nombre y su apellido para obtener" 
		 + " sus iniciales.");
		 nombre = Console.ReadLine();
		 
		 //Busco las iniciales
		 Iniciales(nombre, ref letra1, ref letra2);
		 
		 //Las muestro
		 Console.WriteLine("Sus iniciales son: {0} {1}", letra1, letra2);
	 }
 }
