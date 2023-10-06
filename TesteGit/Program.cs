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

        Console.WriteLine($"O resultado é: {resultado} ");

        Console.ReadLine();
    }
}
