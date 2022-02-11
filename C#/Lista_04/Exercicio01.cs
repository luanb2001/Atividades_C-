using System;
					
public class Program
{
	public static void Main()
	{
		int qntdnotas = 0;
        double nota = 0;
        double acumula = 0;

        Console.WriteLine("Digite quantas notas quer informar: ");
        qntdnotas = int.Parse(Console.ReadLine());
    
        for(int i=1; i<=qntdnotas; i++)
		{
            Console.WriteLine("Informe a " + i + "ª nota");
            nota = int.Parse(Console.ReadLine());
            acumula = acumula + nota;
		}	
        Console.WriteLine("A média das notas é: " + (acumula/qntdnotas));
	}
}