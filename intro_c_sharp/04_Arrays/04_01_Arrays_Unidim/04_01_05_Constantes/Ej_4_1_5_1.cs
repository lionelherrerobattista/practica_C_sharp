/*(4.1.5.1) Crea un programa que contenga un array con los nombres
 * de los meses del año. El usuario podrá elegir entre verlos
 * en orden natural (de Enero a Diciembre) o en orden inverso
 * (de Diciembre a Enero). Usa constantes para el valor máximo
 * del array en ambos recorridos.
 */
 using System;
 
 public class Ejercicio_4_1_5_1
 {
	 public static void Main()
	 {
		 const byte MAX_MESES = 12;
		 string[] meses = {"Enero","Febrero", "Marzo", "Abril", "Mayo",
			  "Junio", "Julio", "Agosto", "Septiembre",
			   "Octubre", "Noviembre", "Diciembre"};
		 byte orden;
		 int i;
		
		 Console.WriteLine("Elija la forma en la que quiere mostrar" +
		 " los meses del año:");
		 Console.WriteLine("1-Orden Natural");
		 Console.WriteLine("2-Orden Inverso");
		 Console.Write("Respuesta: ");
		 orden = Convert.ToByte(Console.ReadLine());
		 
		 //Muestro en orden natural
		 if(orden == 1)
		 {
			 for(i=0; i < MAX_MESES; i++)
			 {
				 Console.Write("{0} ", meses[i]);
			 }
		 }
		 else
		 {
			 //Muestro en orden inverso
			 if(orden == 2)
			 {
			     for(i = MAX_MESES-1; i >= 0; i--)
			     {
				     Console.Write("{0} ", meses[i]);
			     }				
			 }	
		 }
 
	  }
 }
