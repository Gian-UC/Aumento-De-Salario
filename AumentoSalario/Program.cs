using System;

class Program
{
    static void Main()
    {        
        double[] salarios = { 1900.00, 3200.0, 2000.0, 3500.0, 2800.0 };

        Console.WriteLine("Salários antes do aumento:");
        ExibirSalarios(salarios);
        
        AumentarSalarios(salarios, 0.10);

        Console.WriteLine("\nSalários após o aumento de 10%:");
        ExibirSalarios(salarios);
    }

    static void AumentarSalarios(double[] salarios, double percentualAumento)
    {
        for (int i = 0; i < salarios.Length; i++)
        {
            salarios[i] += salarios[i] * percentualAumento;
        }
    }

    static void ExibirSalarios(double[] salarios)
    {
        foreach (double salario in salarios)
        {
            Console.WriteLine($"R$ {salario:F2}");
        }
    }
}
