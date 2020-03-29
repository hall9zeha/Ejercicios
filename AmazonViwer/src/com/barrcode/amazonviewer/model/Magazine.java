package com.barrcode.amazonviewer.model;
import java.util.*;
public class Magazine extends Publication{

	private int id;
	public Magazine(String title, Date editionDate, String editorial )
	{
		super(title, editionDate, editorial);
	}
	
	public int getId()
	{
		return id;
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return ":: Magazine :: \n " +
				"\n Title: " + getTitle() +
				"\n Editorial: " + getEditorial() + 
				"\n EditionDate: " + getEditionDate();
				
	}
	
}
