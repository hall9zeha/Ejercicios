package com.barrcode.amazonviewer.model;

public class Movie extends Film {
	public int id ;
	public int timeViewed;
public Movie(String title, String genre, String creator, int duration, short year)
{
	super(title, genre, creator, duration);
	setYear(year);
}
	

	
	
	
	
	public int getId() {
		return id;
	}

	

	
	public int getTimeViewed() {
		return timeViewed;
	}

	public void setTimeViewed(int timeViewed) {
		this.timeViewed = timeViewed;
	}

	public void showData()
	{
		//System.out.println("Tittle: " + this.title);
		//System.out.println("Genero: " + this.genre);
		//System.out.println("Year: " + this.year);
		
		String [] movie= new String[2] ;
		//movie[0]=title;
		//movie[1]=genre;
		
		for(String obj:movie)
		{
			System.out.println("Peliculas:" + obj);
		}
		
		
	}
	//utilizamos el método del sistema toString() y lo sobreescribimos para que nos devuelva por defecto lo que queramos 
	@Override
	public String toString() {
		
		return "Title: " + getTitle() +
				"\n Genre: " + getGenre() +
				"\n Creator: "+ getCreator() +
				"\n Duration: " + getDuration() +
				"\n Year: "+ getYear();
	}
	

}
