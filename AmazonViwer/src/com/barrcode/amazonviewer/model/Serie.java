package com.barrcode.amazonviewer.model;

public class Serie extends Film {
	private int id;
	private int sessionQuantity;
	private Chapter[] chapters;
	
	public Serie(String title, String genre, String creator, int duration, int sessionQuantity)
	{
		super(title, genre, creator, duration);
		setSessionQuantity(sessionQuantity);
	}
	
	public int getId() {
		return id;
	}
	
	public int getSessionQuantity()
	{
		return sessionQuantity;
	}
	public void setSessionQuantity(int sessionQuantity)
	{
		this.sessionQuantity=sessionQuantity;
	}
	public Chapter[] getChapters()
	{
		return chapters;
	}
	public void setChapters(Chapter[] chapter)
	{
		this.chapters=chapter;
	}
	
	
	
}
