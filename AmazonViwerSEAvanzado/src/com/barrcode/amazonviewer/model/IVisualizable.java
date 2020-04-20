package com.barrcode.amazonviewer.model;
import java.util.*;
public interface IVisualizable {

	/**
	 * Este m�todo captura el momento de la visualizaci�n
	 * @param dateI es un objeto de tipo {@code Date} con el tiempo de inicio
	 * @return Devuelve la fecha y hora capturada
	 * */
	Date startToSee(Date dateI);
	
	/**
	 * @param dateI es un objeto de tipo {@code Date} con el tiempo de inicio
	 * @param dateF es un objeto de tipo {@code Date} con el tiempo de Fin
	 * */
	void stopToSee(Date dateI, Date dateF);
	
	
	
}
