using System;

namespace TP1MDPI
{
	//11) Haga que la clase Persona implemente la interface Comparable. Compare las personas por dni o por nombre, según prefiera.
	public class Persona : Icomparable
	{
		string nombre;
		int dni;
		
		public Persona(string nombre, int dni)
		{
			this.nombre=nombre;
			this.dni=dni;
		}
		
		public string getNombre()
		{
			return this.nombre;
		}
		
		public int getDni()
		{
			return this.dni;
		}

		#region Icomparable implementation

		public virtual bool sosIgual(Icomparable c)
		{
			if(this.getDni() == ((Persona)c).getDni())
				return true;
			else
				return false;
			
//			throw new NotImplementedException();
		}

		public virtual bool sosMenor(Icomparable c)
		{
			
			if(this.getDni() < ((Persona)c).getDni())
				return true;
			else
				return false;
//			throw new NotImplementedException();
		}

		public virtual bool sosMayor(Icomparable c)
		{
			if(this.getDni() > ((Persona)c).getDni())
				return true;
			else
				return false;
//			throw new NotImplementedException();
		}

		#endregion
		
		public override string ToString()
		{
			return string.Format("{0}", dni);
		}
	}
}
