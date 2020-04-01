package com.barrcode.amazonviewer;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Scanner;

import com.barrcode.amazonviewer.model.*;
import com.barrcode.mekereport.Report;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		showMenu();
		
		
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
		case 0:
			exit=0;
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
			//MakeReport();
			menuReports();
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
	static ArrayList<Book> books= Book.makeListBook();
	private static void showBooks() {
		int exit=1;
		
		do {
			System.out.println("");
			System.out.println("::Books::");
			for(int i=0; i<books.size(); i++)
			{
				System.out.println(i +"." + "Título: " + books.get(i).getTitle() + " Publicado en: " + books.get(i).getEditionDate()+ " Editorial: " + books.get(i).getEditorial() + "Leido: " + books.get(i).getReaded());
			}
			
			System.out.println("0 . Regresar al Menu");
			System.out.println();

			Scanner sc= new Scanner(System.in);
			int response=Integer.valueOf(sc.nextLine());
			if(response==0)
			{
				exit=0;
				showMenu();
			}
			if(response>0)
			{
			Book selectedBook= books.get(response -1);
			selectedBook.setReaded(true);
			Date dateI=selectedBook.startToSee(new Date());
		
			
			for(int i=0; i<1000; i++)
			{
				System.out.println("........................");
			}
			selectedBook.stopToSee(dateI, new Date());
			System.out.println("Leiste: " + selectedBook);
			System.out.println("Por: " + selectedBook.getTimeReaded() + " milisegundos");
			}
		}
		while(exit!=0);
		
	}
	static ArrayList<Chapter> chapters=Chapter.makeListChapter();
	private static void showSeries() {
		int exit=1;
		ArrayList<Serie> series= Serie.makeListSeries();
		
		do {
			System.out.println("ingrese 0 si desea regresar al menu");
			System.out.println("");
			System.out.println("::Series::");
			for(int i=0; i<series.size();i++)
			{
				System.out.println(i +1+ "." + " Title: "+series.get(i).getTitle() + " Genre: "+series.get(i).getGenre()+" Author: "+series.get(i).getCreator()+ " Duracion: "+ series.get(i).getDuration()+" Seasons: "+series.get(i).getSessionQuantity());
			}
			System.out.println("Escoja el número de la serie que quiere ver");
			Scanner sc=new Scanner(System.in);
			int op=Integer.valueOf(sc.nextLine());
			
			if(op==0)
			{
				showMenu();
			}
			showChapter(series.get(op -1).getChapters());
		}
		while(exit!=0);
	}
	
	private static void showChapter(ArrayList<Chapter> serieSelect) {
		// TODO Auto-generated method stub
		int exit=1
				;
		
		do {
			System.out.println();
			System.out.println("::Capítulos::");
			System.out.println();
			for(int i=0; i<serieSelect.size(); i++)
			{
			System.out.println(i+1+"Capítulo: " + serieSelect.get(i).getTitle() + " Visto: "+ serieSelect.get(i).getViewed());
			}
			
		System.out.println("0 Regresar a listado de Series");
		System.out.println();
		
		Scanner sc = new Scanner(System.in);
		int response=Integer.valueOf(sc.nextLine());
		
		if(response==0)
		{
			exit=0;
			showSeries();
		}
		if(response>0)
		{
		Chapter chapterSelected=serieSelect.get(response - 1);
		chapterSelected.setViewed(true);
		Date dateI=chapterSelected.startToSee(new Date());
		for(int i=0; i<1000;i++)
		{
			System.out.println("......................");
		}
		chapterSelected.stopToSee(dateI, new Date());
		System.out.println();
		System.out.println("Viste: "+ chapterSelected);
		System.out.println("Por: " + chapterSelected.getTimeViewed() + " milisegundos");
		System.out.println();
		}
			}
		while(exit!=0);
		
	}
	static ArrayList<Movie> movies=Movie.makeMovieList();;
	private static void showMovies() {
		// TODO Auto-generated method stub
		int exit=1;
		
		do {
			System.out.println("");
			System.out.println("::Movies::");
			for(int i=0; i<movies.size(); i++)
			{
			System.out.println(i +1 + "." +"Titulo: "+  movies.get(i).getTitle() + "\t" + "Genero: "+ movies.get(i).getGenre() + "\t" +  movies.get(i).getYear() + "\t" + "Visto: "+ movies.get(i).getViewed());	
			}
			
			System.out.println("0. Regresar al Menu");
			System.out.println();
			
			
			
			Scanner sc= new Scanner(System.in);
			int response=Integer.valueOf(sc.nextLine());
			if(response==0)
			{
				exit=0;
				showMenu();
			}
			if(response>0)
			{
				Movie movieSelected= movies.get(response -1);
				movieSelected.setViewed(true);
				Date dateI=movieSelected.startToSee(new Date());
				
				for(int i=0; i<1000; i++)
				{
					System.out.println("..........");
				}
				
				movieSelected.stopToSee(dateI, new Date());
				System.out.println("Viste: " + movieSelected);
				System.out.println("Por: " + movieSelected.getTimeViewed() +  " Milisegundos ");
			}
			
			
		}
		while(exit!=0);
		
	}
	public static void menuReports()
	{
		int exit=1;
		
		do {
			System.out.println();
			System.out.println("::Menu reportes::");
			System.out.println("1. Reporte Movies Vistas");
			System.out.println("2. Reporte Movies Fecha");
			System.out.println("3. Reporte Books leidos");
			System.out.println("4. Reporte Capitulos Series Vistos");
		System.out.println("0 . Regresar al Menu");
			Scanner sc= new Scanner(System.in);
			int response=Integer.valueOf(sc.nextLine());
		if(response==0)
		{
			exit=0;
			showMenu();
		}
		if(response>1)
		{
		
			MakeReport(response);
			
		}
		
		}
		while(exit!=0);
		
	}
	public static void MakeReport(int opc)
	{
		Report report= new Report();
		if(opc==1)
		{
		
		report.setNameFile("Reporte");
		report.setExtension("txt");
		report.setTitle("::PELÍCULAS VISTAS::");
		String contentReport="";
		for(Movie movie:movies)
		{
			if(movie.getIsViewed())
			{contentReport +=movie.toString();
			}
			}
		report.setContent(contentReport);
		report.makeReport();
		}
		else if(opc==3)
		{
			report.setNameFile("Reporte");
			report.setExtension("txt");
			report.setTitle("::LIBROS LEIDOS::");
			String contentReport="";
			for(Book books:books)
			{
				if(books.getIsReaded())
				{contentReport +=books.toString();
				}
				}
			report.setContent(contentReport);
			report.makeReport();
		}
		else if(opc==4)
		{
			report.setNameFile("Reporte");
			report.setExtension("txt");
			report.setTitle("::SERIES VISTAS::");
			String contentReport="";
			for(Chapter chapters:chapters)
			{
				if(chapters.getIsViewed())
				{contentReport +=chapters.toString();
				}
				}
			report.setContent(contentReport);
			report.makeReport();
		}
		
	}
	public static void MakeReport(Date date)
	{
		SimpleDateFormat df=new SimpleDateFormat("yyyy-MM-dd");
		String fecha=df.format(date);
		Report report = new Report();
		report.setNameFile("Reporte" + fecha);
		report.setNameFile("Reporte");
		report.setExtension("txt");
		report.setTitle("::VISTOS::");
		String contentReport="";
		for(Movie movie:movies)
		{
			if(movie.getIsViewed())
			{contentReport +=movie.toString();
			}
			}
		report.setContent(contentReport);
		report.makeReport();
		
				
				
	}
}
