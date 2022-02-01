using Filmes.EntityFramework.Dados;
using Filmes.EntityFramework.Extensions;
using System;

namespace Filmes.EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //select * from actor
            using (var contexto = new FilmesContexto())
            {
                contexto.LogSQLToConsole();

                foreach (var ator in contexto.Atores)
                {
                    System.Console.WriteLine(ator);
                }
            }
        }
    }
}
