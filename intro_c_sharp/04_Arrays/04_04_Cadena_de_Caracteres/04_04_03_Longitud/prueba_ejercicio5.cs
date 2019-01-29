/* Prueba
 */
 using System;
 
 public class Ejercicio_4_4_3_4
 {
	 public static void Main()
	 {
		 string numeroUno;
		 string numeroDos;
		 
		 int numeroEnteroUno;
		 int numeroEnteroDos;
		 int multiplicador;
		 
		 
		 
		 int i;
		 int j;
		 int longitud;
		 int resultado=0;
		 int resto = 0;
		 
		 string resultadoString; //el resultado de los dos numeros que tomo
		 char[] total; //Lo uso para mostrar el numero

		 
		 //Pido los numeros
		 Console.Write("Escriba el multiplicando: ");
		 numeroUno = Console.ReadLine();
		 
		 Console.Write("Escriba el multiplicador: ");
		 numeroDos = Console.ReadLine();
		 
		 multiplicador = Convert.ToInt32(numeroDos.ToString());
		 
		 longitud = numeroUno.Length;
		 total = new char[longitud+1];
		 
		 for(j= 0; j < multiplicador; j++)
		 {
		 //Empiezo desde atrás
			 for(i = longitud-1; i >= 0; i--)
			 {
		 
				 //Voy tomando los numeros de atrás para adelante, uno por uno
				 //y los guardo en una variable int
				 
				 //Si es un char, convert devuelve el valor ASCII
				 //valor ASCII de '1' es 49
				 //Usar ToString para que no devuleva el valor ASCII !!!
				 numeroEnteroUno = Convert.ToInt32(numeroUno[i].ToString());
				 numeroEnteroDos = Convert.ToInt32(numeroUno[i].ToString());

				 //Sumo los numeros más el resto (max. 18 - 9+9 -)
				 resultado = (numeroEnteroUno + numeroEnteroDos + resto);
				 
				 //Lo paso a string para separar el resto
				 resultadoString = resultado.ToString();
				 
				 //Si es >9 hay resto necesariamente (base = 10)
				 if(resultado > 9)
				 {
					 //Guardo el resto en una variable,
					 // el resto está en la posición 0 del resultado
					 resto = Convert.ToInt32(resultadoString[0].ToString());
					 
					 //Guardo el resultado en la cadena que voy a mostrar
					 total[i+1] = resultadoString[1]; //+1 porque tiene un índice más para guardar el último resto
					 
					 //En la ultima iteracion con resto, guardo el resto en el total
					 //posición 0
					 if(i == 0)
					 {
						 total[i] = resultadoString[0];
					 }
					 
				 }
				 else //si no hay resto
				 {
					 total[i+1] = resultadoString[0];
					 
					 //Si es la ultima iteración y no hay resto
					 //completo con 0
					 if(i == 0)
					 {
						 total[i] = '0';
					 }
					 
				 }

				 

			 }
			 	 
		}	
		
					 //Muestro el numero
			 for(i = 0; i < longitud+1; i++)
			 {
				 if(i == 0 && total[i] == '0')
				 {
					 continue;
				 }
				 
				 Console.Write(total[i]);
			 }
			 
	 }
	 
	 
 }

