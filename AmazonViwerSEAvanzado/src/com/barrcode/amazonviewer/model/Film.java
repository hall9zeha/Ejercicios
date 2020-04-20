package com.barrcode.amazonviewer.model;

import java.text.SimpleDateFormat;
import java.util.Date;

/**
 * <h1>Film</h1>
 * <p>
 * Film es una clase abstracta, y como tal no se puede crear instancias de la misma, solo se puede instancia las clases derivadas,
 * y acceder a los recursos de la clase padre a través de la herencia de las clases hijas.
 * 
 * contiene el método abstracto
 * {@code view()} que es obligatorio implementar para todo aquel que pertenezca a la familia
 * 
 * @author Barry
 * @since 2020
 * */
public abstract class Film {

	private int id ;
	private String title;
	private String genre;
	private String creator;
	private int duration;
	private short year;
	private boolean viewed;
	
	public Film() {}
	public  Film(String title, String genre, String creator, int duration)
	{
		this.title=title;
		this.genre=genre;
		this.creator=creator;
		this.duration=duration;
		
		
	}
	
	public String getTitle()
	{
		return title;
	}
	public void setTitle(String title)
	{
		this.title=title;
		
	}
	public String getGenre()
	{
		return genre;
	}
	public void setGenre(String genre)
	{
		this.genre=genre;
	}
	public String getCreator()
	{
		return creator;
	}
	public void setCreator(String creator)
	{
		this.creator=creator;
	}
	public int getDuration()
	{
		return duration;
	}
	public void setDuration(int duration)
	{
		this.duration=duration;
	}
	public short getYear()
	{
		return year;
	}
	public void setYear(short year)
	{
		this.year=year;
	}
	public String  getViewed()
	{
		String visto="";
		if(viewed==true)
		{
			visto="si";
		}
		else
		{
			visto="no";
		}
		return visto;
	}
	public boolean getIsViewed() {
		return viewed;
	}
	public void setViewed(boolean viewed) {
		this.viewed = viewed;
	}
	/**
	 * Este método abstracto es obligatorio 
	 * */
	public abstract void view();
	
}

