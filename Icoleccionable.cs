
using System;

namespace TP1MDPI
{
	//3) Implemente la siguiente interface que representa objetos que almacenan comparables:
	//(coleccionable)
	
	public interface Icoleccionable
	{
		int cuantos(); //Devuelve la cantidad de elementos comparables que tiene el coleccionable
		Icomparable minimo(); //Devuelve el elemento de menor valor de la colección
		Icomparable maximo();//Devuelve el elemento de mayor valor de la colección
		void agregar (Icomparable c); //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
		bool contiene (Icomparable c); //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario

		
	}
}
