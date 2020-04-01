package com.barrcode.amazonviewer.model;
import java.util.*;
public class Book extends Publication implements IVisualizable {
	private int id;
	private String isbn;
	private boolean readed;
	private int timeReaded;
	
	public Book(String title, short editionDate, String editorial)
	{
		super(title, editionDate, editorial);
	}
	
	public String getIsbn()
	{
		return isbn;
	}
	public void setIsbn(String isbn)
	{
		this.isbn=isbn;
	}
	public String getReaded()
	{
		String leido="";
		if(readed==true)
		{
			leido="si";
		}
		else
		{
			leido="no";
		}
		return leido;
				
	}
	public void setReaded(boolean readed)
	{
		this.readed=readed;
	}
	public boolean getIsReaded()
	{
		return readed;
	}
	public int getTimeReaded()
	{
		return timeReaded;
	}
	public void setTimeReaded(int timeReaded)
	{
		this.timeReaded=timeReaded;
	}
	
	
	public Date startToSee(Date dateI)
	{
		return dateI;
	}
	public void stopToSee(Date dateI, Date dateF)
	{
		if(dateF.getTime()>dateI.getTime())
		{
			setTimeReaded((int)(dateF.getTime()- dateI.getTime()));
		}
		else
		{
			setTimeReaded(0);
		}
	}
	public static ArrayList<Book> makeListBook()
	{
		ArrayList<Book> books= new ArrayList<Book>();
		for(int i=0; i<=6; i++)
		{
			books.add(new Book("Book " + i, (short)(2020+i),"Editorial " + i));
		}
		return books;
	}
public String toString() {
		
		return "Title: " + getTitle();
				
				
	}
}
