/*(5.9.1.5) Crea un programa que "dibuje" asteriscos en 100 posiciones
 * al azar de la pantalla. Para ayudarte para escribir en cualquier
 * coordenada, puedes usar un array de dos dimensiones
 * (con tamaños 24 para el alto y 79 para el ancho),
 * que primero rellenes y luego dibujes en pantalla.
 */
 using System;
 
 public class Ejercicio_5_9_1_5
 {
	 public static void Main()
	 {
		 Random random = new Random();
		 
		 int alto;
		 int ancho;
		 int i;
		 
		 char[,] matriz = new char [24,79]; //Creo la matríz
		 
		 
		 //Cargo los asteriscos en lugares al azar
		 for(i = 0; i < 100; i++)
		 {
			 alto = random.Next(0, 24);
			 ancho = random.Next(0, 79);
			 matriz[alto, ancho] = '*';
		 }
		
		//Muestro la matríz
		 for(alto = 0; alto < 24; alto++)
		 {
			 for(ancho = 0; ancho < 79; ancho++)
			 {
				 Console.Write("{0}", matriz[alto,ancho]);
			 }
			 Console.WriteLine();
		 }
	 }
 }
