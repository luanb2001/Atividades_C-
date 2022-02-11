using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite um número");
     	int valor1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite outro número");
     	int valor2 = int.Parse(Console.ReadLine());

     	Console.WriteLine("A área dos valores é: " + (valor1 * valor2));
    }
}