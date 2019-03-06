/*(4.6.2) Un programa que pida datos de 8 personas: nombre,
 * dia de nacimiento, mes de nacimiento, y año de nacimiento
 * (que se deben almacenar en un array de structs).
 * Después deberá repetir lo siguiente: preguntar un número de mes
 * y mostrar en pantalla los datos de las personas que cumplan
 * los años durante ese mes. Terminará de repetirse
 * cuando se teclee 0 como número de mes.
 */
 using System;
 
 public class Ejercicio_4_6_2
 {
	 //Declaro la estructura
	 struct S_Persona
	 {
		 public string nombre;
		 public byte dia;
		 public byte mes;
		 public int anio;		 
	 }
	 	 
	 public static void Main()
	 {
		 //Creo el array de la estructura
		 S_Persona[] personas = new S_Persona[8];
		 
		 int indice;
		 byte mes;
		 
		 //Cargo los datos
		 for(indice = 0; indice < 8; indice++)
		 {
			 Console.WriteLine("Persona {0}", indice+1);
			 
			 Console.Write("Ingrese su nombre: ");
			 personas[indice].nombre = Console.ReadLine();
			 
			 Console.Write("Ingrese el dia de nacimiento: ");
			 personas[indice].dia = Convert.ToByte(Console.ReadLine());
			 
			 Console.Write("Ingrese el mes: ");
			 personas[indice].mes = Convert.ToByte(Console.ReadLine());
			 
			 Console.Write("Ingrese el año: ");
			 personas[indice].anio = Convert.ToInt32(Console.ReadLine());
			 
			 Console.WriteLine();
		 }
		 
		 //Pregunto por un mes
		 do
		 {
			 Console.Write("Ingrese el mes a buscar: ");
			 mes = Convert.ToByte(Console.ReadLine());
			 
			 //Busco las personas que cumplan años en ese mes
			 for(indice = 0; indice < 8; indice++)
			 {
				 if(mes == personas[indice].mes)
				 {
					 Console.WriteLine("{0} {1,10}", "Nombre",
					  "Fecha de nacimiento");
					 Console.WriteLine("{0,3} {1,15}/{2}/{3}",
					  personas[indice].nombre, personas[indice].dia,
					   personas[indice].mes, personas[indice].anio);
					   
					 Console.WriteLine();				 	 
				 }
				 
			 }			 
			 
		 }while(mes != 0);
		 
		 	 
	 }
 }
