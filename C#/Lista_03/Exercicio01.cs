using System;
					
public class Program
{
	public static void Main()
	{
        int A = 0;
        int B = 0;
        int soma;
        int subtr;
        int multip;
        int div;

        Console.WriteLine("Digite o 1º número: ");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o 2º número: ");
        B = int.Parse(Console.ReadLine());

        soma = ((A + B));
        subtr = (A - B);
        multip = (A * B);
        div = (A / B);

        Console.WriteLine("\n" + A + " + " + B + " = " + soma);
        Console.WriteLine(+A + " - " + B + " = " + subtr);
        Console.WriteLine(+A + " * " + B + " = " + multip);
        Console.WriteLine(+A + " / " + B + " = " + div);
	}
}