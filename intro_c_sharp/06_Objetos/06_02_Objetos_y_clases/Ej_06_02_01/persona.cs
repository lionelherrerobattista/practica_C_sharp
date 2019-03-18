/*(6.2.1) Crea una clase llamada Persona, en el fichero "persona.cs".
 * Esta clase deberá tener un atributo "nombre", de tipo string.
 * También deberá tener un método "SetNombre", de tipo void
 * y con un parámetro string, que permita cambiar el valor del nombre.
 * Finalmente, también tendrá un método "Saludar",
 * que escribirá en pantalla "Hola, soy " seguido de su nombre.
 * Crea también una clase llamada PruebaPersona.
 * Esta clase deberá contener sólo la función Main,
 * que creará dos objetos de tipo Persona, les asignará un nombre
 * a cada uno y les pedirá que saluden.
 */
using System;

public class Persona
{
	string nombre;
	
	public void SetNombre(string nuevoNombre)
	{
		nombre = nuevoNombre;				
	}
	
	public void Saludar()
	{
		Console.WriteLine("Hola soy {0}", nombre);		
	}
}

public class PruebaPersona
{
	public static void Main()
	{
		Persona personaUno = new Persona();
		Persona personaDos = new Persona();
		
		personaUno.SetNombre("Juan");
		personaDos.SetNombre("María");
		
		personaUno.Saludar();
		personaDos.Saludar();		
	}
}
