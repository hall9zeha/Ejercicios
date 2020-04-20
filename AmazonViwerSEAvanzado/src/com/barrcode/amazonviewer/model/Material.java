package com.barrcode.amazonviewer.model;

import java.util.ArrayList;

import com.barrcode.amazonviewer.dao.IMovieDAO;

public class Material implements IMovieDAO {

	private  int idMaterial;
	private String material;
	
	public Material() {
		 }
	public Material(int idMaterial, String material)
	{
		
		this.idMaterial=idMaterial;
		this.material= material;
	}
	
	public int getIdMaterial()
	{
		return idMaterial;
	}
	public  void setIdMaterial(int idMaterial)
	{
		this.idMaterial=idMaterial;
	}
	public String getMaterial()
	{
		return material;
	}
	public void setMaterial(String material)
	{
		this.material=material;
	}
	
	public static  ArrayList<Material> getListMaterial()
	{
		Material mat= new Material();
		return mat.ListMaterial();
	}
	/*@Override
	public String toString() {
		return  getId() +
				 getMaterial();
				
	}*/
}
