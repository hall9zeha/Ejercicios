package com.barrcode.amazonviewer;

import java.util.Date;
import java.util.Scanner;

import com.barrcode.amazonviewer.model.*;
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		//showMenu();
		
		Movie movie= new Movie("Alita battle angel", "Fiction", "J. Cameron", 120, (short)2019);
		//movie.showData();
		//cada vez que imprimimos el objeto movie nos imprimira el método toString sobreescrito por nosotros
		System.out.println(movie);
	}
	public static void showMenu()
	{
		 
		int exit=0;
		
		do {
		System.out.println("BIENVENIDOS A AMAZON VIEWER");  
		System.err.println("");
		System.out.println("Selecciona el número de la operación deseada");
		System.out.println("1. Movies");
		System.out.println("2. Series");
		System.out.println("3. Books");
		System.out.println("4. Magazines");
		System.out.println("5. Make Report");
		System.out.println("6. Make Report Today");
		System.out.println("0. Exit");
		
		Scanner sc=new Scanner(System.in);
		System.out.println("Opcion: ");
		int op=Integer.valueOf(sc.nextLine());
		switch(op)
		{
		case 1:
			showMovies();
			break;
		case 2:
			showSeries();
			break;
		case 3:
			showBooks();
			break;
		case 4:
			showMagazines();
			break;
		case 5:
			MakeReport();
			break;
		case 6:
			MakeReport(new Date());
			break;
		default:
			System.out.println();
			System.out.println("Escoge una opción");
			System.out.println();
			break;
		}
		}
		while(exit!=0);
		
		//hacer un switch para mostrar las opciones seleccionadas
	}

	private static void showMagazines() {
		int exit=0;
		do {
			System.out.println("");
			System.out.println("::Magazines::");
		}
		while(exit!=0);
		
	}

	private static void showBooks() {
		int exit=0;
		do {
			System.out.println("");
			System.out.println("::Books::");
		}
		while(exit!=0);
		
	}

	private static void showSeries() {
		int exit=0;
		do {
			System.out.println("ingrese 9 si desea regresar al menu");
			System.out.println("");
			System.out.println("::Series::");
			Scanner sc=new Scanner(System.in);
			int op=Integer.valueOf(sc.nextLine());
			
			if(op==9)
			{
				showMenu();
			}
		}
		while(exit!=0);
	}

	private static void showMovies() {
		// TODO Auto-generated method stub
		int exit=0;
		do {
			System.out.println("");
			System.out.println("::Movies::");
		}
		while(exit!=0);
		
	}
	public static void MakeReport()
	{
		
	}
	public static void MakeReport(Date date)
	{
		
	}
}
