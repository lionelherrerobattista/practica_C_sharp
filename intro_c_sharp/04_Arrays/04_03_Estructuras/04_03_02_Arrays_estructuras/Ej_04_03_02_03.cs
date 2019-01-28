/*(4.4.1.3) Un programa que pida tu nombre, tu día de nacimiento
 *  y tu mes de nacimiento y lo junte todo en una cadena,
 *  separando el nombre de la fecha por una coma
 *  y el día del mes por una barra inclinada,
 *  así: "Juan, nacido el 31/12".
 */
 using System;
 
 public class Ejercicio_4_4_1_3
 {
	 struct sPersona
	 {
		 public string nombre;
		 public byte diaNacimiento; //limite 255
		 public byte mesNacimiento;
	 }
	 public static void Main()
	 {
		 sPersona persona;
		 
		 //Pido los datos
		 Console.Write("Escriba su nombre: ");
		 persona.nombre = Console.ReadLine();
		 Console.Write("Fecha de nacimiento: ");
		 persona.diaNacimiento = Convert.ToByte(Console.ReadLine());
		 Console.Write("Mes de nacimiento: ");
		 persona.mesNacimiento = Convert.ToByte(Console.ReadLine());
		 
		 //Muestro los datos
		 Console.Write(persona.nombre + ", nacido el " +
		  persona.diaNacimiento + "/" + persona.mesNacimiento + ".");
	 }
 }
