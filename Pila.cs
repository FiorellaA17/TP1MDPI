/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 24/8/2022
 * Hora: 22:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP1MDPI
{
	//4)Implemente las clases Pila y Cola (vistas en Algoritmos y Programación) y haga que las dos clases implementen la interface Coleccionable
	
	public class Pila : Icoleccionable
	{
		List<Icomparable> datos;
	
		
		public Pila()
		{
			datos=new List<Icomparable>();  
		}
		
		public void agregar(Icomparable c)
		{
			datos.Add(c);
		}
		
		public Icomparable desapilar()
		{
			Icomparable aux;
			int tam=datos.Count;
			aux=(Icomparable)datos[tam-1];
			datos.Remove(aux);
			
			return aux;
		}
		
		public bool vacia()
		{
			return datos.Count == 0;
		}
		
		public Icomparable tope()
		{
			int tam=datos.Count;
			
			return (Icomparable) datos[tam-1];
		}
		
		//region Icoleccionable implementation
		
		public int cuantos()
		{
			return this.datos.Count;
		}
		
		public Icomparable minimo()
		{
			//return (Icomparable)datos.Min();
//			Icomparable min=new Numero(100);
//			Icomparable min=new Persona("min",60000000);
			Icomparable min=new Alumno("min",60000000,1000,100);
			
			foreach(Icomparable elem in this.datos)
			{
				if(elem.sosMenor(min))
				{
					min=elem;
				}
			}
			
			return min;
		}

		public Icomparable maximo()
		{
			//return (Icomparable)datos.Max();
//			Icomparable max=new Numero(0);
//			Icomparable max=new Persona("max",0);
			Icomparable max=new Alumno("max",0,0,0);
			
			foreach(Icomparable elem in this.datos)
			{
				if(elem.sosMayor(max))
				{
					max=elem;
				}
			}
			
			return max;
		}

	

		public bool contiene(Icomparable c)
		{
			//return this.datos.Contains((Icomparable)c);

			foreach(Icomparable elem in datos)
			{
				if(elem.sosIgual(c))
				{
					return true;
				}
			}
			
			return false;
		}
		//end region
		
	}
}
