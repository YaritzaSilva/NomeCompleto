using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            string NomeCompleto;
            string NomeCatalogo;

            Console.WriteLine ("----------");
            Console.WriteLine ("Veja seu nome em diferentes perspectivas");
            Console.WriteLine ("----------\n\n");

            Console.Write("Digite seu primeiro nome: ");
            nome= Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            sobrenome= Console.ReadLine();

            NomeCompleto = $"{nome} {sobrenome}";
            NomeCatalogo = $"{sobrenome.ToUpper()},{nome}";

            Console.WriteLine();
            Console.WriteLine($"Nome completo: {NomeCompleto}");
            Console.WriteLine($"Nome de catálogo: {NomeCatalogo}");
        }
    }
}
