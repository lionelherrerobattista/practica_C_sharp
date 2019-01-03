/*
 * (3.2.3.2) Crea un programa que pida al usuario a una distancia
 * (en metros) y el tiempo necesario para recorrerla
 * (como tres números: horas, minutos, segundos),
 * y muestre la velocidad, en metros por segundo,
 * en kilómetros por hora y en millas por hora
 * (pista: 1 milla = 1.609 metros).
 */
 using System;
 
 
 public class Ejercicio_3_2_3_2
 {
	 public static void Main()
	 {
		 float distancia; //se pide al usuario, en metros
		 //----tiempo----//
		 int horas;
		 int minutos;
		 int segundos;
		 //-------------//
		 float velocidad;
		 float tiempo;
		 
		 Console.Write("Ingrese la distancia a recorrer (en metros): ");
		 distancia = Convert.ToSingle(Console.ReadLine());
		 
		 Console.WriteLine("Ingrese el tiempo" +
		 " en que desea recorrer esa distancia:");
		 
		 Console.Write("Ingrese las horas: ");
		 horas = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Ingrese los minutos: ");
		 minutos = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Ingrese los segundos: ");
		 segundos = Convert.ToInt32(Console.ReadLine());
		 
		 //velocidad en metros por segundo
		 tiempo= (horas * 3600) + (minutos * 60) + segundos; //en segundos
		 velocidad = distancia / tiempo;
		 
		 Console.WriteLine("La velocidad en metros/segundos es: {0}",
		  velocidad);
		 
		 //kilometros por hora
		 tiempo = (horas) + (minutos / 60) + (segundos / 3600);//en horas
		 velocidad = (distancia / 1000) / tiempo;
		 
		 Console.WriteLine("La velocidad en kilometros/hora es: {0}",
		  velocidad);
		 
		 //millas por hora
		 tiempo = (horas) + (minutos / 60) + (segundos / 3600);//en horas
		 velocidad = (distancia / 1609) / tiempo;
		 
		 Console.WriteLine("La velocidad en millas/hora es: {0}",
		  velocidad);
		 
	 }
	 
	 
	 
	 
 }
