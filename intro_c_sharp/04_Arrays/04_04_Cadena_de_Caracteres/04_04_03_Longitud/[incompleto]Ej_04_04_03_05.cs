/* (4.4.3.5) Un programa capaz de multiplicar dos números enteros
 * muy grandes (por ejemplo, de 30 cifras), que se deberán pedir
 * como cadena de texto y analizar letra a letra.
 * 
 * NO ESTA TERMINADO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
 */
 using System;
 
 public class Ejercicio_4_4_3_5
 {
	 public static void Main()
	 {
		 string numeroUno;
		 string numeroDos;
		 
		 int multiplicando;
		 int multiplicador;
		 int numeroEnteroUno;
		 int numeroEnteroDos;
		 
		 int i;
		 int j=0;
		 int longitud;
		 int resultado=0;
		 int resto = 0;
		 
		 int posicionSuma=0;
		 
		 string resultadoString; //el resultado de los dos numeros que tomo
		 char[,] total; //Lo uso para mostrar el numero
		 char[] resultadoFinal;

		 
		 //Pido los numeros
		 Console.Write("Escriba el primer número: ");
		 numeroUno = Console.ReadLine();
		 
		 Console.Write("Escriba el segundo número: ");
		 numeroDos = Console.ReadLine();
		 
		 longitud = numeroUno.Length;
		 //longitud máxima de una multiplicacion
		 //de dos numeros iguales es la longitud *2
		 total = new char[longitud,longitud*2]; //[numeros que tiene el multiplicador, long multiplicador*2]
		 
		 resultadoFinal = new char[longitud*2];
		 
		 //Empiezo desde atrás
		 for(i = longitud-1; i >= 0; i--) //multiplicador
		 {
			 for(j = longitud-1; j >= 0; j--) //multiplicando
			 {
				 multiplicando = Convert.ToInt32(numeroUno[j].ToString());
				 multiplicador = Convert.ToInt32(numeroDos[i].ToString());

				 //Multiplico los numeros
				 resultado = ((multiplicando * multiplicador) + resto);
				 
				 //Lo paso a string para separar el resto
				 resultadoString = resultado.ToString();
				 
				 //Si es >9 hay resto necesariamente (base = 10)
				 if(resultado > 9)
				 {
					 //Guardo el resto en una variable,
					 // el resto está en la posición 0 del resultado
					 resto = Convert.ToInt32(resultadoString[0].ToString());
					 
					 //Guardo el resultado en la cadena donde acumulo las sumas
					 total[posicionSuma,(j*2)] = resultadoString[1];
					 
					 
					 //En la ultima iteracion con resto, guardo el resto en el total
					 //posición 0
					 if(j == 0)
					 {
						 total[posicionSuma,j] = resultadoString[0];
					 }
					 

				 }
				 else //si no hay resto
				 {
					 total[posicionSuma,(j*2)] = resultadoString[0];
					 
					 
					 //Si es la ultima iteración y no hay resto
					 //completo con 0
					 if(j == 0)
					 {
						 total[i,j] = '0';
					 }
					 
				 }
				 
			 }
			 
			 posicionSuma++;

		 }
		 
		 //sumo los resultados
		 for(j = longitud-1; j >= 0; j--)//matriz con la multiplicacion
		 {
				 for(i = (longitud*2)-1; i >= 0; i--) //resultado final
				 {
			 
					 //Voy tomando los numeros de atrás para adelante, uno por uno
					 //y los guardo en una variable int

					 numeroEnteroUno = Convert.ToInt32(total[j,i].ToString());
					 numeroEnteroDos = Convert.ToInt32(resultadoFinal[i].ToString());

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
						 resultadoFinal[i] = resultadoString[1]; //+1 porque tiene un índice más para guardar el último resto
						 
						 //En la ultima iteracion con resto, guardo el resto en el total
						 //posición 0
						 if(i == 0)
						 {
							 resultadoFinal[i] = resultadoString[0];
						 }
						 
					 }
					 else //si no hay resto
					 {
						 resultadoFinal[i+1] = resultadoString[0];
						 
						 //Si es la ultima iteración y no hay resto
						 //completo con 0
						 if(i == 0)
						 {
							 resultadoFinal[i] = '0';
						 }
						 
					 }

						 
				 }
		 }
		 
		 //Muestro el numero
		 for(i = 0; i < (longitud*2)-1; i++)
		 {
			 if(i == 0 && resultadoFinal[i] == '0')
			 {
				 continue;
			 }
			 
			 Console.Write(resultadoFinal[i]);
		 }		 
	 }
 }
