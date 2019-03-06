/*(4.6.1) Un programa que pida el nombre, el apellido
 * y la edad de una persona, los almacene en un "struct"
 * y luego muestre los tres datos en una misma línea,
 * separados por comas.
 */
 using System;
 
 public class Ejercicio_4_6_1
 {
	 struct S_Persona
	 {
		 public string nombre;
		 public string apellido;
		 public byte edad;
	 }
	 
	 public static void Main()
	 {
		 //Creo una variable persona del tipo de dato de la estructura
		 S_Persona persona;
		 
		 //Pido datos de la persona
		 Console.Write("Ingrese su nombre: ");
		 persona.nombre = Console.ReadLine();
		 
		 Console.Write("Ingrese su apellido: ");
		 persona.apellido = Console.ReadLine();
		 
		 Console.Write("Ingrese su edad: ");
		 persona.edad = Convert.ToByte(Console.ReadLine());
		 
		 //Muestro los datos
		 Console.WriteLine("{0}, {1}, {2}", persona.nombre,
		   persona.apellido, persona.edad);
		  
	 }
 }
