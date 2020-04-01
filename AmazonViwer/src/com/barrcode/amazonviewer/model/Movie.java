package com.barrcode.amazonviewer.model;
import java.util.*;
public class Movie extends Film implements IVisualizable {
	public int id ;
	public int timeViewed;
public Movie(String title, String genre, String creator, int duration, short year)
{
	super(title, genre, creator, duration);
	setYear(year);
}
	

	
	
	
	
	public int getId() {
		return id;
	}

	

	
	public int getTimeViewed() {
		return timeViewed;
	}

	public void setTimeViewed(int timeViewed) {
		this.timeViewed = timeViewed;
	}

	public void showData()
	{
		//System.out.println("Tittle: " + this.title);
		//System.out.println("Genero: " + this.genre);
		//System.out.println("Year: " + this.year);
		
		String [] movie= new String[2] ;
		//movie[0]=title;
		//movie[1]=genre;
		
		for(String obj:movie)
		{
			System.out.println("Peliculas:" + obj);
		}
		
		
	}
	//utilizamos el método del sistema toString() y lo sobreescribimos para que nos devuelva por defecto lo que queramos 
	@Override
	public String toString() {
		
		return "Title: " + getTitle() +
				"\n Genre: " + getGenre() +
				"\n Creator: "+ getCreator() +
				"\n Duration: " + getDuration() +
				"\n Year: "+ getYear();
	}
	
	public Date startToSee(Date dateI)
	{
		
		return dateI;
	}
	public void stopToSee(Date dateI, Date dateF)
	{
		if(dateF.getTime()>dateI.getTime())
		{
			setTimeViewed((int)(dateF.getTime() - dateI.getTime()));
		}
		else
		{
			setTimeViewed(0);
		}
	}
	public static ArrayList<Movie> makeMovieList()
	{
		ArrayList<Movie> movies= new ArrayList<Movie>();
		for(int i=0; i<=5;i++)
		{
			movies.add(new Movie("Alita " +i ,"Genero " + i, "Creador " + i, 120, (short)2019 ));
		}
		return movies;
	}
}
