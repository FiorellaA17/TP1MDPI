/*
 * Creado por SharpDevelop.
 * Usuario: Windows
 * Fecha: 28/8/2022
 * Hora: 22:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP1MDPI
{
		//8)Cree la clase ColeccionMultiple:
		//Haga que la clase ColeccionMultiple implemente la interface Coleccionable, donde:
		public class ColeccionMultiple : Icoleccionable
	{
		Pila P;
		Cola C;
		
		public ColeccionMultiple(Pila p, Cola c )
		{
			P=new Pila();
			C=new Cola();
			
			this.P=p;
			this.C=c;
		}

		#region Icoleccionable implementation

		public int cuantos()
		{
			int total= this.P.cuantos() + this.C.cuantos();
			return total;
		}

		public Icomparable minimo()
		{
			Icomparable minP= P.minimo();
			Icomparable minC= C.minimo();
			
			if(((Persona)minP).getDni() > ((Persona)minC).getDni()) //para que compare Dni, debo castear a persona y pedir el dni
//			if(((Numero)minP).getValor() > ((Numero)minC).getValor())
				return minP;
			else
				return minC;
		}

		public Icomparable maximo()
		{
			Icomparable maxP= P.maximo();
			Icomparable maxC= C.maximo();
			
			if(((Persona)maxP).getDni() > ((Persona)maxC).getDni()) //modifico cambiando por getDni y casteando a persona
//			if(((Numero)maxP).getValor() > ((Numero)maxC).getValor())
				return maxP;
			else
				return maxC;
		}

		public void agregar(Icomparable c)
		{
			throw new NotImplementedException();
		}

		public bool contiene(Icomparable c)
		{
			bool auxP=P.contiene(c);
			bool auxC=C.contiene(c);
			
			if(auxP == true || auxC == true)
				return true;
			else
				return false;
			
		}

		#endregion
	}
}
