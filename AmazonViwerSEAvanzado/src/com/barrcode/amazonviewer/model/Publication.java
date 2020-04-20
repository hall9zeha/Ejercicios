package com.barrcode.amazonviewer.model;
import java.util.*;
public class Publication {
	
	private int id;
	private String title;
	private short editionDate ;
	private String editorial;
	private String[] authors;
	
	public Publication() {}
	public Publication(String title, short editionDate, String editorial) {
		this.title=title;
		this.editionDate=editionDate;
		this.editorial=editorial;
		
		// TODO Auto-generated constructor stub
	}
	public String getTitle()
	{
		return title;
	}
	public void setTitle(String title)
	{
		this.title=title;
	}
	public short getEditionDate()
	{
		return editionDate;
	}
	public void setEditionDate(short editionDate)
	{
		this.editionDate=editionDate;
	}
	public String getEditorial()
	{
		return editorial;
	}
	public void setEditorial(String editorial)
	{
		this.editorial=editorial;
	}
	public String[] getAuthors()
	{
		return authors;
	}
	public void setAuthors(String[] authors)
	{
		this.authors=authors;
	}
}
