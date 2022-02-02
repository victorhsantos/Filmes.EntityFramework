using System;
using System.Linq;
using Filmes.EntityFramework.Dados;
using Filmes.EntityFramework.Extensions;
using Filmes.EntityFramework.Negocio;
using Microsoft.EntityFrameworkCore;

namespace Filmes.EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new FilmesContexto())
            {
                contexto.LogSQLToConsole();
                
                foreach (var filme in contexto.Filmes)
                {
                    Console.WriteLine(filme);
                }
            }
        }
    }
}
