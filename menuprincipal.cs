using System;

namespace practica2
{
	public class menuprincipal
	{
		public static void Main(string[] args)
       
		{
			reloj r;
			cronometro c;
			Console.WriteLine("Menu");
		    Console.WriteLine("1.Hora");
		    Console.WriteLine("2.Cronometro");
		    
		    int opc=int.Parse(Console.ReadLine());
		    
		    switch (opc)
		    {
		    		case 1: r= new reloj();
		    		r.GetHashCode();
		    
		    break;
		    
		   case 2:  c= new cronometro();
		   c.GetHashCode();
		            break;
		           default:Console.WriteLine("NO VALIDO");
		            break;
		    }
		    Console.WriteLine("Press any key to continue . . .");
		    Console.ReadKey(true);
		}
	}
}
