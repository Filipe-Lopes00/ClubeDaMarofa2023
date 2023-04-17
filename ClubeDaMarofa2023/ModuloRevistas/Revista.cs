using ClubeDaMarofa2023.ModuloCaixas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaMarofa2023.ModuloRevistas
{
    public class Revista
    {
        public string TipoColecao { get; set; }
        public int NumeroEdicao { get; set; }
        public int Ano { get; set; }
        public Caixa Caixa { get; set; }

    }
}
