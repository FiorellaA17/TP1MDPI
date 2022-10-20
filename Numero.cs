
using System;

namespace TP1MDPI
{
	//2)Implemente la clase Numero:
	//Haga que la clase Numero implemente la interface Comparable.
	
	public class Numero : Icomparable
	{
		int valor;
		
		
		public Numero(int v)
		{
			this.valor=v;
		}
		
		public int getValor()
		{
			return this.valor;
		}
		
		/*Implemento los metodos de la interface Icomparable*/
		
		//Devuelve verdadero si el objeto que recibe el mensaje es el mismo que el “comparable” recibido por parámetro, 
		//devuelve falso en caso contrario
		
		public bool sosIgual(Icomparable c)
		{
			if(this.getValor() == ((Numero)c).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		//Devuelve verdadero si el objeto que recibe el mensaje es más chico que el “comparable” recibido por parámetro,
		//devuelve falso en caso contrario
		
		public bool sosMenor(Icomparable c)
		{
			if(this.getValor() < ((Numero)c).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		//Devuelve verdadero si el objeto que recibe el mensaje es más grande que el “comparable” recibido por parámetro,
		//devuelve falso en caso contrario
		
		public bool sosMayor(Icomparable c)
		{
			if(this.getValor() > ((Numero)c).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		//sobreescribo para tener el valor, le digo como imprimir el objeto
		public override string ToString()
		{
			return string.Format("[{0}]", valor);
		}
	}
}
