
using System;

namespace TP1MDPI
{
	//1) Implemente la siguiente interface que representa cualquier objeto que sabe compararse con otro objeto de su “mismo tipo”:
	
	public interface Icomparable
	{
		bool sosIgual (Icomparable c);
		bool sosMenor (Icomparable c);
		bool sosMayor (Icomparable c);
		
	}
}
