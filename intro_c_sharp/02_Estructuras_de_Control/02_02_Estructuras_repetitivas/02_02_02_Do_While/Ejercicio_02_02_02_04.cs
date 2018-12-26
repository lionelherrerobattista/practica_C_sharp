/*
(2.2.2.4) Crea un programa que pida al usuario
su identificador y su contraseña (ambos numéricos), y no le permita seguir
hasta que introduzca como identificador "1234" y como contraseña "1111".
*/

using System;

public class Ejercicio_02_02_02_04
{
    public static void Main()
    {
	int identificador;
	int password;
	int flag=0; //flag de error
	
	do
	{

	    Console.Write("Escriba el identificador: ");
	    
	    if(flag==1)
	    {
	        Console.Write("Error. Escriba el identificador nuevamente: ");
            }

	    identificador = Convert.ToInt32(Console.ReadLine());
		
	    flag = 1;  //Si se repite, muestra el mensaje de error
	
	}while(identificador != 1234);

	flag= 0;

	do
	{

	    if(flag==1)
	    {
	        Console.Write("Error. Escriba la password nuevamente: ");
            }
	    else
	    {
	        Console.Write("Escriba la password: ");
	    }

	    password = Convert.ToInt32(Console.ReadLine());

	    flag = 1; //Si se repite, muestra el mensaje de error		    
	

	}while(password != 1111);

    }

}