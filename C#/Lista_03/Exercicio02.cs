using System;
					
public class Program
{
	public static void Main()
	{
        int c = 0;
        double pi = 3.14;

        Console.WriteLine("Digite o perímetro da circunferência em cm: ");
        c = int.Parse(Console.ReadLine());

        double raio = (c/pi)/2;
        double area = (raio*raio)*pi;

        Console.WriteLine("O tamanho do raio é: " + raio + "cm");
        Console.WriteLine("O tamanho da área é: " + area + "cm²"); 
	}
}