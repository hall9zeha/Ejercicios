package com.barrcode.amazonviewer;

import static com.barrcode.amazonviwer.db.DataBase.TMOVIE_ID;

import java.text.SimpleDateFormat;

import java.util.ArrayList;
import java.util.Date;
import java.util.Scanner;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.function.Consumer;

import com.barrcode.amazonviewer.model.*;
import com.barrcode.mekereport.Report;

/**
 * <h1>AmazonViewer</h1>
 * AmazonViewer es un programa que te permite simular la visualización de Películas y series, así como leer libros,
 * también te permite hacer reportes generales con fecha del día.
 * <p>
 * Existen algunas reglas, como que todos los elementos pueden ser vistos, y leidos a excepción de magazines que ,
 * solo se podra mostrar a manera de colección.
 * 
 * @author Barry
 * @version 1.1
 * @since 2020
 * 
 * */ 
public class Main {

	
	static AtomicInteger atomInteger= new AtomicInteger(1);
	
	static Material mat= new Material();
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
		//traemos la lista que tenemos en la base de datos
		ArrayList<Material> materials = Material.getListMaterial(); 
		materials.stream().filter(mat->mat.getMaterial()!="chapter").forEach(mat->System.out.println(mat.getIdMaterial()+". "+ mat.getMaterial() ));
		//System.out.println("1. Movies");
		//System.out.println("2. Series");
		//System.out.println("3. Books");
		//System.out.println("4. Magazines");
		System.out.println("6. Make Report");
		System.out.println("7. Make Report Today");
		
		System.out.println("8. Traer por fecha");
		System.out.println("9. Make Report por fecha");
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
		case 4:
			showBooks();
			break;
		case 5:
			showMagazines();
			break;
		case 6:
			//MakeReport();
			menuReports();
			break;
		case 7:
			MakeReport(new Date());
			break;
		case 8:
			showMovieFecha();
			break;
		case 9:
			
			System.out.println("ingresa la fecha");
			Scanner scp=new Scanner(System.in);
			String result=String.valueOf(scp.nextLine());
			DateReport(result);
			
			
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
		
		mat.setIdMaterial(4);
		
		do {
			System.out.println("");
			System.out.println("::Books::");
			
			//implementando lambda para mostrar los libros listados
			books.forEach(b-> System.out.println(
					atomInteger.getAndIncrement()+
					" Título: " + b.getTitle()  + 
					" Publicado en: " + b.getEditionDate() +
					" Editorial: " + b.getEditorial() +
					"Leido: " + b.getReaded()));
			
			
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
			selectedBook.view();
			}
		}
		while(exit!=0);
		
	}
	static ArrayList<Serie> series=Serie.makeListSeries();
	private static void showSeries() {
		int exit=1;
		
		
		do {
			System.out.println("ingrese 0 si desea regresar al menu");
			System.out.println("");
			System.out.println("::Series::");
			
			//implementando lambda para mostrar las series
			AtomicInteger aInteger= new AtomicInteger(1);
			series.forEach(se->System.out.println(
					aInteger.getAndIncrement() +
					" Title: "+se.getTitle() +
					" Genre: "+se.getGenre()+
					" Author: "+se.getCreator()+
					" Duracion: "+ se.getDuration()+
					" Seasons: "+se.getSessionQuantity() +
					" Visto: " + se.getViewed()));
			
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
			
			AtomicInteger aInteger= new AtomicInteger(1);
			serieSelect.forEach(s->System.out.println(
					aInteger.getAndIncrement() + 
					" Capítulo: "+ s.getTitle() +
					" Visto: " + s.getViewed() ));
			
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
		chapterSelected.view();
		}
			}
		while(exit!=0);
		
	}
	static ArrayList<Movie>listaFecha=new ArrayList();
	private static void showMovieFecha()
	{
		int exit=1;
		AtomicInteger atoInt= new AtomicInteger(1);
		System.out.println("ingresa la fecha en la que vio la película en este formato Año-Mes-Día: ");
		Scanner sc= new Scanner(System.in);
		String respuesta=String.valueOf(sc.nextLine());
		
		
		listaFecha=Movie.listaMovieFecha(respuesta);
		do {
			System.out.println("");
			System.out.println("::Movies::");
		
		listaFecha.forEach(lf->System.out.println(atoInt.getAndIncrement()+ ". " + lf.getId()  + " Título: " + lf.getTitle()+ 
				" Género: "+ lf.getGenre()+ 
				" Año: " +lf.getYear()+ 
				" Visto: "+lf.getViewed()));
		
		System.out.println("0. Regresar al Menu");
		System.out.println();
		
		
		
		Scanner sc1= new Scanner(System.in);
		int response=Integer.valueOf(sc1.nextLine());
		if(response==0)
		{
			exit=0;
			showMenu();
		}
		if(response>0)
		{
			
			Movie movieSelected= movies.get(response -1);
			
			movieSelected.view();
		}
		
		
	}
	while(exit!=0);

	}
	static ArrayList<Movie> movies=new ArrayList();
	private static void showMovies() {
		// TODO Auto-generated method stub
		int exit=1;
		
		
		movies=Movie.makeMovieList();
		do {
			System.out.println("");
			System.out.println("::Movies::");
			//esta función nos dara un índice numerado ya que la programación funcional es solamente declarativa y no puedo manipular variables como los índices
			AtomicInteger atomicInteger= new AtomicInteger(1);//inicializado en uno
			//aplicando recursividad con lambdas a la iteración for de películas, nos mostrará las películas recorriendo la lista como lo hacía el for anterior
			movies.forEach(m->System.out.println(
					atomicInteger.getAndIncrement() +
					". s" + m.getId() +
					" Título: " + m.getTitle()+ 
					" Género: "+ m.getGenre()+ 
					" Año: " +m.getYear()+ 
					" Visto: "+m.getViewed()));
			
			//probamos otro ejemplo diferente funciona muy bien
			
			//movies.forEach(System.out::println);
			
			/*for(int i=0; i<movies.size(); i++)
			{
			System.out.println(i +1 + "." +"Titulo: "+  movies.get(i).getTitle()  + "Genero: "+ movies.get(i).getGenre() +  movies.get(i).getYear()  + "Visto: "+ movies.get(i).getViewed());	
			}*/
			
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
				movieSelected.setMaterial(1);
				movieSelected.view();
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
		if(response>=1)
		{
		
			MakeReport(response);
			
		}
		
		}
		while(exit!=0);
		
	}
	static ArrayList<Chapter>chapters=new ArrayList<Chapter>();
	public static void MakeReport(int opc)
	{
		Report report= new Report();
		//cambiaremos la naturaleza del contentReport que era String a StringBuilder porque nos permite concatenar cadenas
		StringBuilder contentReport=new StringBuilder();
		switch(opc)
		{
		case 1:
		report.setNameFile("Reporte");
		report.setExtension("txt");
		report.setTitle("::PELÍCULAS VISTAS::");
		
		//probando streams y filter para reemplazar el código for if
		movies.stream().filter(m->m.getIsViewed()).forEach(m->contentReport.append(m.toString() + "\n"));
		
		break;
		case 3:
		
			report.setNameFile("Reporte");
			report.setExtension("txt");
			report.setTitle("::LIBROS LEIDOS::");
			//String contentReport="";
		
		books.stream().filter(b->b.getIsReaded()).forEach(b->contentReport.append(b.toString() +"\n"));	
			
		
		break;
		
		case 4:
			report.setNameFile("Reporte");
			report.setExtension("txt");
			report.setTitle("::SERIES VISTAS::");
			//String contentReport="";
			
			Consumer<Serie> serieEach=s->{
				chapters=s.getChapters();
				chapters.stream().filter(c->c.getIsViewed()).forEach(c->contentReport.append(c.toString() +"\n"));
				
			};
			series.stream().forEach(serieEach);
			
			
			
		
		break;
		
		
		}
		report.setContent(contentReport.toString());
		report.makeReport();
		System.out.println("Reporte generado");
	}
	public static void MakeReport(Date date)
	{
		SimpleDateFormat df=new SimpleDateFormat("yyyy-MM-dd");
		String fecha=df.format(date);
		Report report = new Report();
		report.setNameFile("Reporte " + fecha);
		report.setExtension("txt");
		report.setTitle("::VISTOS::");
		StringBuilder contentReport=new StringBuilder();
		movies.stream().filter(m->m.getIsViewed()).forEach(m->contentReport.append(m.toString() +"\n"));
		
		
		report.setContent(contentReport.toString());
		report.makeReport();
		
				
				
	}
	//probando reporte por fecha de películas 
	public static void DateReport(String date)
	{
		int exit=1;
		do {
			
		Movie mov= new Movie();
		mov.setDateView(date);
		listaFecha=Movie.listaMovieFecha(date);
		Report reporte= new Report();
		reporte.setNameFile("Reporte" + date);
		reporte.setExtension("txt");
		reporte.setTitle("::Vistos el ::" + date);
		StringBuilder  contentReport = new StringBuilder();
		listaFecha.forEach(lf->contentReport.append(lf.toString()+"\n"));
		reporte.setContent(contentReport.toString());
		reporte.makeReport();
		
		System.out.println("Reporte con fecha ingresada generado");
		System.out.println("Ingrese una opción: ");
		
		Scanner sc =new Scanner(System.in);
		int result=Integer.valueOf(sc.nextLine());
		if(result==0)
		{
			showMenu();
			exit=0;
		}
	}while(exit==0);
		
	}
	
}
