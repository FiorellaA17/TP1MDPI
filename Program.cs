
using System;

namespace TP1MDPI
{
	class Program
	{
		public static void Main(string[] args)
		{
			//pruebas
			/*Icomparable n1=new Numero(5);
			Icomparable n2=new Numero(4);
			
			Console.WriteLine("***sos Igual***");
			bool resultadoIgual=n1.sosIgual(n2);
			Console.WriteLine(resultadoIgual);
			
			Console.WriteLine("***sos menor***");
			bool resultadoMenor=n1.sosMenor(n2);
			Console.WriteLine(resultadoMenor);
			
			Console.WriteLine("***sos mayor***");
			bool resultadoMayor=n1.sosMayor(n2);
			Console.WriteLine(resultadoMayor);*/
			
			
			//7) Implemente un módulo main que cree una Pila y una Cola, que las llene y que invoque a la función informar
			//con la pila y cola creadas.
			/*
			Icoleccionable pila = new Pila();
			Icoleccionable cola = new Cola();
			
			llenar(pila);
			llenar(cola);
			
			Console.WriteLine("*****PILA*****");
			informar(pila);
			
			Console.WriteLine("*****COLA*****");
			informar(cola);*/
			
			//9) Modifique el módulo main para crear una ColeccionMultiple e informe con esta colección. 
//			Pila pila = new Pila();
//			Cola cola = new Cola();
//			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
//			
//			llenar(pila);
//			llenar(cola);
//			
//			Console.WriteLine("*****Pila*****");
//			informar(pila);
//			Console.WriteLine("");
//			
//			Console.WriteLine("*****Cola*****");
//			informar(cola);
//			Console.WriteLine("");
//			
//			Console.WriteLine("*****Coleccion Multiple*****");
//			informar(multiple);
//			Console.WriteLine("");
			
			//13) Modifique el módulo main para crear una ColeccionMultiple de personas e informe con esta colección.
			
//			Pila pila = new Pila();
//			Cola cola = new Cola();
//			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
//			llenarPersonas(pila);
//			llenarPersonas(cola);
//			informar(multiple);
			
			//17)main
			Pila pila = new Pila();
			Cola cola = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			informar(multiple);
			
			//Responda ¿Funcionó? ¿Fue necesario decir explícitamente que Alumno tiene que implementar la interface Comparable?
			//¿Cuál fue el criterio por el cual se comparó a los alumnos? ¿Por qué?
			
			//Me funcionó pero seguia comparando por persona y no por alumnos. comparaba por dni.
			//Porque no implemente el icomparable en alumnos,entonces usaba el de persona porque heredaba de ella esos metodos.
			//Luego tuve que usar el override en alumno y virtual en persona para "pisarlos"o sea sobreescribirlos
			//porque sino usaba los metodos del icomparable que definimos en la clase persona.
						
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		//5) Implemente una función llenar que reciba un Coleccionable y que le agregue 20 comparables elegidos al azar. 
		
		public static void llenar(Icoleccionable c)
		{
			
			//tengo los mismos valores en pila y cola. Cuando voy paso a paso por instrucciones me da diferentes valores
			
			Random random = new Random();
			
			for (int x = 1; x <= 20; x++) 
			{
				int numAleatorio=random.Next(100);
				Icomparable numero = new Numero(numAleatorio);
				c.agregar(numero);
			}
		}
		
		//6)Implemente  una  función  informar que  reciba  un  Coleccionable e  imprima  por  consola  la cantidad  de  elementos 
		//que  tiene  el  coleccionable  recibido  por  parámetro, el  elemento mínimo, el máximo y si contiene,
		//o no, como elemento un valor leído por teclado.
		
		public static void informar(Icoleccionable c)
		{
			//numero
//			Console.WriteLine("La cantidad de elementos que tiene la coleccion es de: {0}",c.cuantos());
//			Console.WriteLine("La cantidad minima dentro de la coleccion es de: {0}",c.minimo());
//			Console.WriteLine("La cantidad maxima dentro de la coleccion es de: {0}",c.maximo());
//			
//			Console.Write("Ingrese un numero para comparar en la coleccion: ");
//			int num=int.Parse(Console.ReadLine());
//			Icomparable elemento=new Numero(num);
//			
//			if(c.contiene(elemento))
//			{
//				Console.WriteLine("");
//				Console.WriteLine("El elemento leido esta en la coleccion");
//			}
//			else
//			{
//				Console.WriteLine("");
//				Console.WriteLine("El elemento leido no esta en la coleccion");
//			}
			
			//persona
//			Console.WriteLine("La cantidad de elementos que tiene la coleccion es de: {0}",c.cuantos());
//			Console.WriteLine("El numero mas pequeño en dni es: {0}",c.minimo());
//			Console.WriteLine("El numero mas grande en dni es: {0}",c.maximo());
//			
//			
//			Console.Write("Ingrese un numero para comparar en la coleccion: ");
//			int num=int.Parse(Console.ReadLine());
//			Icomparable elemento=new Persona("aux",num); //cambio el elemento por persona para que al ingresar me tome el num como numero de dni y no como de la clase numero
//			
//			if(c.contiene(elemento))
//			{
//				Console.WriteLine("");
//				Console.WriteLine("El elemento leido esta en la coleccion");
//			}
//			else
//			{
//				Console.WriteLine("");
//				Console.WriteLine("El elemento leido no esta en la coleccion");
//			}
			
			//alumno
			Console.WriteLine("La cantidad de elementos que tiene la coleccion es de: {0}",c.cuantos());
			Console.WriteLine("El promedio mas bajo es de: {0}",c.minimo());
			Console.WriteLine("El promedio mas alto es de: {0}",c.maximo());
			
			
			Console.Write("Ingrese un numero para comparar en la coleccion: ");
			int num=int.Parse(Console.ReadLine());
			Icomparable elemento=new Alumno("aux",0,0,num);
			
			
			if(c.contiene(elemento))
			{
				Console.WriteLine("");
				Console.WriteLine("El elemento leido esta en la coleccion");
			}
			else
			{
				Console.WriteLine("");
				Console.WriteLine("El elemento leido no esta en la coleccion");
			}
			
			
		}
		
		//12) Implemente  una  función  llenarPersonas que  reciba un  Coleccionable  y  que  le  agregue 20 personas elegidos al azar. 
		public static void llenarPersonas(Icoleccionable c)
		{

			string [] listaNombres= {"Ana", "juan", "jose", "ruth", "gael", "pedro", "esther", "maria", "belen", "pablo", "lucas", "mia", "lucia", "Leonel"};
			Random random = new Random();
			
			for (int x = 1; x <= 20; x++) 
			{
				int indice=random.Next(listaNombres.Length);
				string nombre= listaNombres[indice];
				int dniAleatorio=random.Next(10000000,50000000);
				Icomparable persona = new Persona(nombre,dniAleatorio);
				c.agregar(persona);
			}
		}
		
		//16)Implemente  una  función  llenaAlumnos  que  reciba  un  Coleccionable  y  que  le  agregue  20 alumnos elegidos al azar. 
		public static void llenarAlumnos(Icoleccionable c)
		{

			string [] listaNombres= {"Ana", "juan", "jose", "ruth", "gael", "pedro", "esther", "maria", "belen", "pablo", "lucas", "mia", "lucia", "Leonel"};
			Random random = new Random();
			
			for (int x = 1; x <= 20; x++) 
			{
				int indice=random.Next(listaNombres.Length);
				string nombre= listaNombres[indice];
				int dniAleatorio=random.Next(10000000,50000000);
				int legajoAleatio=x;
				int promedioAleatorio=random.Next(1,11);
				
				Icomparable Alumno = new Alumno(nombre,dniAleatorio,legajoAleatio,promedioAleatorio);
				c.agregar(Alumno);
			}
		}
	
		
		
	}
	
	
	
}