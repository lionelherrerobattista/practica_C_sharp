/*
 * (3.2.3.4) Si se ingresan E euros en el banco
 *  a un cierto interés I durante N años, el dinero obtenido viene dado
 *  por la fórmula del interés compuesto:
 *  Resultado = e(1+ i)^n Aplicarlo para calcular
 *  en cuanto se convierten 1.000 euros al cabo de 10 años
 *  al 3% de interés anual.
 */
 using System;
 
 public class Ejercicio_3_2_3_4
 {
	 public static void Main()
	 {
		 float euros;
		 float interes;
		 int years;
		 
		 double resultado;//formula de interes compuesto
		 
		 
		 euros = 1000f;
		 interes = 0.3f;
		 years = 10;
		 
		 //Uso Math.Pow para elevar a la potencia
		 resultado = euros * Math.Pow((1 + interes),years);
		 
		 Console.WriteLine("El dinero obtenido es de {0}", resultado);
 
		 
	 }
	 
	 
	 
 }
