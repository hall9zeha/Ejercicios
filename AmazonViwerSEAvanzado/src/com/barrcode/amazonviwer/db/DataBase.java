package com.barrcode.amazonviwer.db;

import com.barrcode.amazonviewer.model.Material;

public class DataBase {

	
	public static final String URL="jdbc:mysql://localhost:3306/";
	public static final String DB="amazonviewer";
	public static final String USER="root";
	public static final String PASSWORD="";
	
	public static final String TMOVIE="movie";
	public static final String TMOVIE_ID="id";
	public static final String TMOVIE_TITLE="title";
	public static final String TMOVIE_GENRE="genre";
	public static final String TMOVIE_CREATOR="creator";
	public static final String TMOVIE_DURATION="duration";
	public static final String TMOVIE_YEAR="year";
	
	//tabla material
	public static final String TMATERIAL="material";
	public static final int[] TMATERIAL_ID= {1,2,3,4,5};
	public static final String TMATERIAL_NAME="name";
	
	//tabla user
	public static final String TUSER="user";
	public static final int TUSER_ID=1;
	
	//tabla viewed
	public static final String TVIEWED ="viewed";
	public static final String TVIEWED_IDMATERIAL="id_material";
	public static final String TVIEWED_IDELEMENT="id_element";
	public static final String TVIEWED_IDUSUARIO="id_user";
	public static final String TVIEWED_TIME="time";
	
	
}
