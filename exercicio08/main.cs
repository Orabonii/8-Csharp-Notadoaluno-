using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite a nota do aluno (0 a 10):");
            double nota;

            if (double.TryParse(Console.ReadLine(), out nota))
            {
                if (nota >= 0 && nota <= 10)
                {
                    if (nota >= 9)
                    {
                        Console.WriteLine("Conceito: A");
                    }
                    else if (nota >= 7)
                    {
                        Console.WriteLine("Conceito: B");
                    }
                    else if (nota >= 5)
                    {
                        Console.WriteLine("Conceito: C");
                    }
                    else if (nota >= 3)
                    {
                        Console.WriteLine("Conceito: D");
                    }
                    else
                    {
                        Console.WriteLine("Conceito: F");
                    }
                }
                else
                {
                    Console.WriteLine("Nota inválida. Por favor, digite uma nota entre 0 e 10.");
                }
        }
    }
}

