package com.barrcode.amazonviewer.model;

public class Chapter extends Movie{

	private int id;
	private int numberSession;
	
	public Chapter (String title, String genre, String creator, int duration, short year, int numberSession)
	{
		super(title, genre, creator,duration, year);
		this.numberSession=numberSession;
	}
	
	public int getId()
	{
		return id;
	}
	public int getNumberSession()
	{
		return numberSession;
	}
	public void setNumberSession(int numberSession)
	{
		this.numberSession=numberSession;
	}
	
	
	
}
