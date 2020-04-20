package com.barrcode.util;
import java.util.Scanner;
public class AmazonUtil {

	public static int validateUserResponseMenu(int min, int max)
	{
		
		Scanner sc = new Scanner(System.in);
		
		while(!sc.hasNextInt())
		{
			sc.hasNext();
			System.out.println("No ingresaste una opción válida");
			System.out.println("Intentalo nuevamente");
		}
		int response =sc.nextInt();
		
		while(response <min || response>max)
		{
			System.out.println("No ingresaste una opción válida");
			System.out.println("Intentalo nuevamente");
			
			while(!sc.hasNextInt())
			{
				sc.hasNext();
				System.out.println("No ingresaste una opción válida");
				System.out.println("Intentalo nuevamente");
			}
			response = sc.nextInt();
		}
		System.out.println("Tu respuesta fue " +response + "\n");
		return response;
	}
}
