/*(4.4.1.2) Crea un programa que pida al usuario su nombre.
 *  Si se llama como tú (por ejemplo, "Nacho"),
 *  responderá "Bienvenido, jefe". En caso contrario,
 *  le saludará por su nombre.
 */
 using System;
 
 public class Ejercicio_4_4_1_2
 {
	 public static void Main()
	 {
		 string nombreUsuario;
		 string nombreJefe = "Lionel";
		 
		 //Pido el nombre al usuario
		 Console.Write("Escriba su nombre: ");
		 nombreUsuario = Console.ReadLine();
		 
		 //Compruebo si concide con mi nombre
		 if(nombreUsuario == nombreJefe)
		 {
			 Console.WriteLine("Bienvenido, jefe");
		 }
		 else
		 {
			 //uso + para concatenar
			 Console.WriteLine("Bienvenido " + nombreUsuario);
		 }
	 }
 }
