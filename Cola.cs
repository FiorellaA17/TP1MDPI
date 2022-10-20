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

	public class Cola : Icoleccionable
	{
		List<Icomparable> datos;
		
		public Cola()
		{
			this.datos=new List<Icomparable>();
		}
		
		public IComparable desencolar() 
		{
			IComparable temp = (IComparable)this.datos[0];
			datos.Remove((Icomparable)temp);
			return temp;
		}
		
		public IComparable tope() 
		{
			return (IComparable)this.datos[0];
		}
		
		public bool esVacia() 
		{
			return this.datos.Count == 0;
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
//			Icomparable min=new Persona("min",60000000); //modifico el minimo de numero por una persona con dni, para poder comparar
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
		
		public void agregar(Icomparable c)
		{
			this.datos.Add(c);
		}
		
		public bool contiene(Icomparable c)
		{
			//return datos.Contains(c);
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
