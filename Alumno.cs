
using System;

namespace TP1MDPI
{
	//15)
	
	public class Alumno : Persona
	{
		int legajo;
		int promedio;
		
		public Alumno(string n, int d, int l, int p) : base(n,d)
		{
			this.legajo=l;
			this.promedio=p;
		}
		
		public int getLegajo()
		{
			return this.legajo;
		}
		
		public int getPromedio()
		{
			return this.promedio;
		}
		
		//18) Reimplemente los métodos de comparable en Alumno para que se compare por legajo o promedio, a elección.
		
		public override bool sosIgual(Icomparable c)
		{
			if(this.getPromedio() == ((Alumno)c).getPromedio())
				return true;
			else
				return false;
			
//			throw new NotImplementedException();
		}

		public override bool sosMenor(Icomparable c)
		{
			
			if(this.getPromedio() < ((Alumno)c).getPromedio())
				return true;
			else
				return false;
//			throw new NotImplementedException();
		}

		public override bool sosMayor(Icomparable c)
		{
			if(this.getPromedio() > ((Alumno)c).getPromedio())
				return true;
			else
				return false;
//			throw new NotImplementedException();
		}
		
		public override string ToString()
		{
			return string.Format("nombre: {0} - promedio: {3}", getNombre(),getDni(),getLegajo(),getPromedio());
		}
	}
}
