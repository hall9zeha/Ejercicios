package com.barrcode.amazonviewer.model;

import java.util.*;

/**
 * Hereda de {@link Movie}
 * @see Film
 * */

public class Chapter extends Movie{

	private int id;
	private int numberSession;
	private Serie serie;
	
	public Chapter (String title, String genre, String creator, int duration, short year, int numberSession,Serie serie)
	{
		super(title, genre, creator,duration, year);
		this.setNumberSession(numberSession);
		this.setSerie(serie);
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
	
	public Serie getSerie()
	{
		return serie;
	}
	public void setSerie(Serie serie)
	{
		this.serie=serie;
	}
	public static ArrayList<Chapter> makeListChapter(Serie serie)
	{
		ArrayList<Chapter>chapters=new ArrayList<Chapter>();
		for(int i=0; i<=6; i++)
		{
			
			chapters.add(new Chapter("Chapter "+i,"Genre "+i,"Author "+i, 60, (short)(2020+i),i,serie));
			
		}
		return chapters;
	}
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return  "\n :: SERIE ::" + 
		"\n Title: " + getSerie().getTitle() +
		"\n :: CHAPTER ::" + 
		"\n Title: " + getTitle() +
		"\n Year: " + getYear() + 
		"\n Creator: " + getCreator() +
		"\n Duration: " + getDuration();
		
	}
	//sobreescribimos el método abstracto heredado de movie, que a su vez hereda de Film al ser clase abstracta
	@Override
	public void view() {
		// TODO Auto-generated method stub
		super.view();
		ArrayList<Chapter> chapters=getSerie().getChapters();
		int ChapterViewedCounter=0;
		for(Chapter chapter :chapters)
		{
			if(chapter.getIsViewed())
			{
				ChapterViewedCounter++;
			}
		}
		if(ChapterViewedCounter==chapters.size())
		{
			getSerie().view();
		}
	}
	
}
