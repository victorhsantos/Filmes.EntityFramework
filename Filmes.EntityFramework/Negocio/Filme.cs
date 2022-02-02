using System;
using System.Collections.Generic;
using System.Text;

namespace Filmes.EntityFramework.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public short Duracao { get; set; }
        public string AnoLancamento { get; set; }

        public override string ToString()
        {
            return $"Titulo: {Titulo} " +
                $"Descricao: {Descricao} " +
                $"Duracao: {Duracao} " +
                $"AnoLancamento: {AnoLancamento} ";
        }
    }
}
