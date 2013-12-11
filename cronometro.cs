using System;

namespace practica2
{
	public class cronometro
	{
		public cronometro()
		{
			for (int w=0;w<24;w++){
		    	for (int x=0;x<60;x++){
		    		for (int z=0;z<60;z++){
						
						Console.Clear ();
		    			Console.WriteLine (w+":"+x+":"+z);	
		    			System.Threading.Thread.Sleep (1000);
		
					}
					
				}
			}
		}
	}
}
