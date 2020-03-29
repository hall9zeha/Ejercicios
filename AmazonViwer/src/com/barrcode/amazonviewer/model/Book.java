package com.barrcode.amazonviewer.model;
import java.util.*;
public class Book {
	private int id;
	private String title;
	private Date editionDate;
	private String editorial;
	private String[] autors;
	private String isbn;
	private boolean readed;
	private int timeReaded;
	public Book(String title, Date editionDate, String editorial, String isbn) {
		super();
		this.title = title;
		this.editionDate = editionDate;
		this.editorial = editorial;
		this.isbn = isbn;
	}
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getTitle() {
		return title;
	}
	public void setTitle(String title) {
		this.title = title;
	}
	public Date getEditionDate() {
		return editionDate;
	}
	public void setEditionDate(Date editionDate) {
		this.editionDate = editionDate;
	}
	public String getEditorial() {
		return editorial;
	}
	public void setEditorial(String editorial) {
		this.editorial = editorial;
	}
	public String[] getAutors() {
		return autors;
	}
	public void setAutors(String[] autors) {
		this.autors = autors;
	}
	public String getIsbn() {
		return isbn;
	}
	public void setIsbn(String isbn) {
		this.isbn = isbn;
	}
	public boolean isReaded() {
		return readed;
	}
	public void setReaded(boolean readed) {
		this.readed = readed;
	}
	public int getTimeReaded() {
		return timeReaded;
	}
	public void setTimeReaded(int timeReaded) {
		this.timeReaded = timeReaded;
	}
	
	

}
