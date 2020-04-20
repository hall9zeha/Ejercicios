package com.barrcode.amazonviewer.model;
import java.text.SimpleDateFormat;
import java.util.*;

import com.barrcode.amazonviewer.dao.IMovieDAO;
/**
 * Hereda de {@link Film}
 * Implementa de {@link IVisualizable}
 * 
 * */

public class Movie extends Film implements IVisualizable, IMovieDAO {
	public int id ;
	public int timeViewed;
	public String dateView;
	public int material;


public Movie()	{}
public Movie(String title, String genre, String creator, int duration, short year)
{
	super(title, genre, creator, duration);
	setYear(year);
	
}

public int getMaterial() {
	return material;
}
public void setMaterial(int material) {
	this.material = material;
}

public String getDateView() {
	return dateView;
}

public void setDateView(String dateView) {
	this.dateView = dateView;
}
	public int getId() {
		return id;
	}

	public void setId(int id)
	{
		
		this.id=id;
	}

	
	public int getTimeViewed() {
				
		return timeViewed;
	}

	public void setTimeViewed(int timeViewed) {
		
		this.timeViewed =timeViewed ;
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
		
		return "\n Title: " + getTitle() +
				"\n Genre: " + getGenre() +
				"\n Creator: "+ getCreator() +
				"\n Duration: " + getDuration() +
				"\n Year: "+ getYear()+
				"\n DateView: " + getDateView();
	}
	
	/**
	 * {@inheritDoc}
	 * */
	public Date startToSee(Date dateI)
	{
		
		return dateI;
	}
	
	/**
	 * {@inheritDoc}
	 * */
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
	public static ArrayList<Movie> listaMovieFecha(String fecha)
	{
		Movie movie= new Movie();
		return movie.traerPorFecha(fecha);
	}
	
	public static ArrayList<Movie> makeMovieList()
	{
		Movie movie=new Movie();
		return movie.read();
	}
	/**
	 * {@inheritDoc}
	 * */
	public void view()
	{
		
		
		setViewed(true);
		Date dateI=startToSee(new Date());
		
		Movie movie= new Movie();
		
		
		//movie.setMovieViewed(this);
		movie.setViewedTable(this);
		
		for(int i=0; i<1000; i++)
		{
			System.out.println("..........");
		}
		
		stopToSee(dateI, new Date());
		System.out.println("Viste: " + toString());
		System.out.println("Por: " + getTimeViewed() +  " Milisegundos ");
	}
}
