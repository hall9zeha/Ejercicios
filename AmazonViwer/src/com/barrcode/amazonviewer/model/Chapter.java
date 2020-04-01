package com.barrcode.amazonviewer.model;

import java.util.*;

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
	public static ArrayList<Chapter> makeListChapter()
	{
		ArrayList<Chapter>chapters=new ArrayList<Chapter>();
		for(int i=0; i<=6; i++)
		{
			
			chapters.add(new Chapter("Chapter "+i,"Genre "+i,"Author "+i, 60, (short)(2020+i),0));
			
		}
		return chapters;
	}
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "\n :: CHAPTER :: "+
				"\n Title: " + getTitle() +
				"\n Year: "+getYear() +
				"\n Creator: " + getCreator() +
				"\n Duration: "+getDuration();
		
	}
	
	
}
