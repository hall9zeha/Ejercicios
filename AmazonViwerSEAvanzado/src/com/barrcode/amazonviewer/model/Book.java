package com.barrcode.amazonviewer.model;

import java.util.*;
import com.barrcode.util.*;
public class Book extends Publication implements IVisualizable {
	private int id;
	private String isbn;
	private boolean readed;
	private int timeReaded;
	private ArrayList<Page> pages;
	
	public Book(String title, short editionDate, String editorial, String[] authors, ArrayList<Page>pages)
	{
		super(title, editionDate, editorial);
		setAuthors(authors);
		this.pages=pages;
	}
	public Book () {}
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
	public void view()
	{
		setReaded(true);
		Date dateI=startToSee(new Date());
	
		int i=0;
		do {
			System.out.println("................");
			System.out.println("Page "+getPages().get(i).getNumber());
			System.out.println(getPages().get(i).getContent());
			System.out.println("................");
			
			if(i!=0)
			{
				System.out.println("1. Regresar p�gina");
			}
			System.out.println("2. Avanzar p�gina");
			System.out.println("0. Cerrar libro");
			System.out.println();
			
			int response =AmazonUtil.validateUserResponseMenu(0,2);
			if(response==2)
			{
				i++;
			}
			else if(response==1)
			{
				i--;
			}
			else if(response==0)
			{break;}
			
		}while(i<getPages().size());
		
		stopToSee(dateI, new Date());
		System.out.println("Leiste: " + toString());
		System.out.println("Por: " + getTimeReaded() + " milisegundos");

	}
	
	public ArrayList<Page> getPages()
	{
		return pages;
	}
	public void setPages(ArrayList<Page>pages)
	{
		this.pages=pages;
	}
	
	
	public static ArrayList<Book> makeListBook()
	{
		ArrayList<Book> books= new ArrayList<Book>();
		String[]authors=new String[3];
		for(int i=0; i<3; i++)
		{
			authors[i]="autor "+i;
		}
		
		ArrayList<Page> pages= new ArrayList();
		int pagina=0;
		for(int i=0; i<3;i++)
		{
			pagina=i+1;
			pages.add(new Book.Page(pagina,"Contenido de la p�gina " + pagina));
		}
		
		for(int i=0; i<=6; i++)
		{
			books.add(new Book("Book " + i, (short)(2020+i),"Editorial " + i,authors,pages));
		}
		return books;
	}
public String toString() {
		
		return "Title: " + getTitle();
				
				
	}

/**
 * Clase Anidada est�tica
 * */
public static class Page{
	
	private int id;
	private int number;
	private String content;
	
	public Page(int number, String content)
	{
		this.number=number;
		this.content=content;
	}
	public int getNumber()
	{
		return number;
	}
	public void setNumber(int number)
	{
		this.number=number;
	}
	
	public String getContent()
	{
		return content;
	}
	public void setContent(String content)
	{
		this.content=content;
	}
}

}
