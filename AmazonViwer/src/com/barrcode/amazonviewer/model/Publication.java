package com.barrcode.amazonviewer.model;
import java.util.*;
public class Publication {
	
	private int id;
	private String title;
	private Date editionDate ;
	private String editorial;
	private String[] authors;
	
	
	public Publication(String title, Date editionDate, String editorial) {
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
	public Date getEditionDate()
	{
		return editionDate;
	}
	public void setEditionDate(Date editionDate)
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
