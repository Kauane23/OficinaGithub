using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outo numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());     

        double resultado = num + num1;

        if (resultado == 0) { Console.WriteLine("Numero inválido"); }
        if (resultado == 1) { Console.WriteLine("Numero inválido"); }
        if (resultado == 2) { Console.WriteLine("Numero inválido"); }

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine($"O resultado é: {resultado} ");
        
        Console.ReadLine();
    }
}
