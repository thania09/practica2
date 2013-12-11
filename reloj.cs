using System;

namespace practica2
{
	public class reloj
	{
		
		public reloj()
		{
		int h=DateTime.Now.Hour;
        int m=DateTime.Now.Minute;
        int s=DateTime.Now.Second;

			for (int a=h;a<24;a++){
		    	for (int b=m;b<60;b++){
		    		for (int c=s;c<60;c++){
						
						Console.Clear ();
		    			Console.WriteLine (a+":"+b+":"+c);	
		    			System.Threading.Thread.Sleep(1000);
		    			
					}
				}
			}
		}
	}
}
