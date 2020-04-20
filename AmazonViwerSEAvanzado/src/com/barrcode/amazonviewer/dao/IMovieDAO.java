package com.barrcode.amazonviewer.dao;
import com.barrcode.amazonviwer.db.IDBConnection;
import com.barrcode.amazonviewer.model.Material;
import com.barrcode.amazonviewer.model.Movie;
import static com.barrcode.amazonviwer.db.DataBase.*;
import java.sql.*;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.*;

public interface IMovieDAO extends IDBConnection{
	
	default Movie setMovieViewed(Movie movie)
	{
		try(Connection connection=connectToDB())
		{
			//prueba relaizada con éxito probar más}}
			 Material mat= new Material();
			java.util.Date d = new java.util.Date();  
			SimpleDateFormat plantilla = new SimpleDateFormat("yyyy-MM-dd");
			String tiempo = plantilla.format(d);
			
			
			
			
			
			movie.setDateView(tiempo);
			Statement statement= connection.createStatement();
			
			String sql="insert into " + TVIEWED +
					" ("+TVIEWED_IDMATERIAL+","+TVIEWED_IDELEMENT+", "+TVIEWED_IDUSUARIO+", "+TVIEWED_TIME+")" +
					" values("+TMATERIAL_ID[0]+", "+movie.getId()+","+TUSER_ID+",CURDATE())";
			if(statement.executeUpdate(sql)>0)
			{
				System.out.println("se marco en vistos");
			}
		}
		catch(SQLException e)
		{
			e.printStackTrace();
		}
		return movie;
	}
	//probamos un método sin harcodeo para ingresar datos a viewed
	
	default void setViewedTable(Movie movie)
	{
		try
		{
			Connection cn= connectToDB();
			
			Material mat= new Material();
			
			String sql="insert into viewed (id_material,id_element,id_user,time) values(?,?,?,curdate())";
			PreparedStatement st=cn.prepareStatement(sql);
			st.setInt(1,movie.getMaterial());
			st.setInt(2,movie.getId());
			st.setInt(3,1);
			st.executeUpdate();		
		}
		catch(SQLException e)
		{
			e.getStackTrace();
		}
	}
	//probamos un método sin hardcodeo para ingresar datos a viewed
	default ArrayList<Movie>read()
	{
		
		ArrayList<Movie>movies= new ArrayList();
		try(Connection connection=  connectToDB())
		{
		String sql="select * from " + TMOVIE;
		PreparedStatement 	 preparedStatement= connection.prepareStatement(sql);
		ResultSet rs=preparedStatement.executeQuery();
		
		while(rs.next())
		{
			Movie movie=new Movie(
					rs.getString(TMOVIE_TITLE), 
					rs.getString(TMOVIE_GENRE), 
					rs.getString(TMOVIE_CREATOR), 
					Integer.valueOf(rs.getString(TMOVIE_DURATION)), 
					Short.valueOf(rs.getString(TMOVIE_YEAR)));
			
			movie.setId(Integer.valueOf(rs.getString(TMOVIE_ID)));
			
			movie.setViewed(getMovieViewed(preparedStatement, connection,Integer.valueOf(rs.getString(TMOVIE_ID))));
			movies.add(movie);
		}
		
		}
		catch(SQLException e)
		{
			
		}
		return movies;
	}
	
	private boolean getMovieViewed(PreparedStatement preparedStatement , Connection connection, int id_movie)
	{
		boolean viewed=false;
		String sql=" select * from " 
		+ TVIEWED + 
		" where "+ TVIEWED_IDMATERIAL  + "= ?" + 
		" and " + TVIEWED_IDELEMENT + "= ?"+
		" and " + TVIEWED_IDUSUARIO + "= ?";
		ResultSet rs=null;
		try
		{
			preparedStatement=connection.prepareStatement(sql);
			preparedStatement.setInt(1, TMATERIAL_ID[0]);
			preparedStatement.setInt(2, id_movie);
			preparedStatement.setInt(3, TUSER_ID);
			
			rs=preparedStatement.executeQuery();
			viewed=rs.next();
			
		}
		catch(Exception e)
		{
			e.printStackTrace();
		}
		return viewed;
	}
	default ArrayList<Movie> traerPorFecha(String fecha)
	{
		ArrayList<Movie> movieFecha= new ArrayList<Movie>();
		PreparedStatement pStatement=null;
		Connection cn=connectToDB();
		String sql="select * from movie inner join viewed on movie.id=viewed.id_element where viewed.time =?";
		ResultSet rs=null;
		try
		{
			
			pStatement= cn.prepareStatement(sql);
			pStatement.setString(1, fecha);
			rs=pStatement.executeQuery();
			
			while(rs.next())
			{
				Movie movie=new Movie(
						
						rs.getString("title"),
						rs.getString("genre"),
						rs.getString("creator"),
						Integer.valueOf(rs.getString("duration")),
						Short.valueOf(rs.getString("year"))
						
						
						);
				movie.setViewed(getMovieViewed(pStatement, cn, rs.getInt("id")));
				movieFecha.add(movie);
				
			}
		}
		catch(SQLException e)
		{
			e.getStackTrace();
		}
		return movieFecha;
	}
	default ArrayList<Material> ListMaterial()
	{
		ArrayList<Material> materials= new ArrayList<Material>();
		PreparedStatement pStatement=null;
		Connection cn=connectToDB();
		String sql="select *  from material";
		ResultSet rs= null;
		try
		{
			pStatement=cn.prepareStatement(sql);
			rs=pStatement.executeQuery();
			while(rs.next())
			{
				Material mat= new Material();
				
				mat.setIdMaterial(rs.getInt("id"));
				mat.setMaterial(rs.getString("name"));
				
				materials.add(mat);
			}
			
		}
		catch(Exception e)
		{
			e.getStackTrace();
		}
		return materials;
	}
}
