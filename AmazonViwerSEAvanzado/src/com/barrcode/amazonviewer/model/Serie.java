package com.barrcode.amazonviewer.model;

import java.util.ArrayList;



public class Serie extends Film {
	private int id;
	private int sessionQuantity;
	private ArrayList<Chapter> chapters;
	
	public Serie(String title, String genre, String creator, int duration, int sessionQuantity)
	{
		super(title, genre, creator, duration);
		setSessionQuantity(sessionQuantity);
		this.chapters=chapters;
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
	public ArrayList<Chapter> getChapters()
	{
		return chapters;
	}
	public void setChapters(ArrayList<Chapter> chapter)
	{
		this.chapters=chapter;
	}
	public static ArrayList<Serie> makeListSeries()
	{
		ArrayList<Serie> series=new ArrayList();
		for(int i=0; i<=6; i++)
		{
			
			Serie serie = new Serie("Serie "+i, "genero "+i, "creador "+i, 1200,5);
			serie.setChapters(Chapter.makeListChapter(serie));
			series.add(serie);
		}
		return series;
	}
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "\n ::SERIE:: "+
				"\n Title: " + getTitle()+
				"\n Genero: "+ getGenre()+
				"\n Year: "+getYear()+
				"\n Creator: "+getCreator()+
				"\n Duration: "+ getDuration();
				
	}
	public void view()
	{
		setViewed(true);
	}
	
	
}
