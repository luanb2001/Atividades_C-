using System;
					
public class Program
{
	public static void Main()
	{
		
        int i=0;
        int j=0;
		
		int[] v1;
		int[] v2;
		int[] v3;
        v1 = new int[2];
        v2 = new int[2];
        v3 = new int[4];
        
        for (i=0; i<2; i++)
		{
            Console.WriteLine("- Informe o "+(i+1)+"° valor do vetor 1: ");
            v1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n");
    
        for (i=0; i<2; i++)
		{
			Console.WriteLine("- Informe o "+(i+1)+"° valor do vetor 2: ");
            v2[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n");
    
        for (i=0; i<2; i++)
		{
			v3[j] = v1[i];
            j++;
            v3[j] = v2[i];
            j++;
         }
    
        Console.WriteLine("Dados do vetor 3: ");
        for (j=0; j<4; j++)
		{
			Console.WriteLine(v3[j]);
		}
	}
}