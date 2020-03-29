package com.barrcode.amazonviewer.model;
import java.util.*;
public class Book extends Publication implements IVisualizable {
	private int id;
	private String isbn;
	private boolean readed;
	private int timeReaded;
	
	public Book(String title, Date editionDate, String editorial)
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
	public boolean getReaded()
	{
		return readed;
	}
	public void setReaded(boolean readed)
	{
		this.readed=readed;
	}
	public int getTimeReaded()
	{
		return timeReaded;
	}
	public void setTimeReaded(int timeReaded)
	{
		this.timeReaded=timeReaded;
	}
	
	public String toString()
	{
		String detailBook= "\n :: Book :: " +
							"\n Title: " + getTitle() +
							"\n Editorial: " + getEditorial() +
							"\n EditionDate: " + getEditionDate() +
							"\n Authors:";
		
		for(int i=0; i<getAuthors().length; i++)
		{
			detailBook += "\t " + getAuthors()[i] ;
		}
		return detailBook;
	}
	public Date startToSee(Date dateI)
	{
		return dateI;
	}
	public void stopToSee(Date dateI, Date dateF)
	{
		if(dateF.getSeconds()>dateI.getSeconds())
		{
			setTimeReaded(dateF.getSeconds()- dateI.getSeconds());
		}
		else
		{
			setTimeReaded(0);
		}
	}

}
