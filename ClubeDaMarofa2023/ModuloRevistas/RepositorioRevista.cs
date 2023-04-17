using ClubeDaMarofa2023.ModulosAmigos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Para cada Revista, deverá ser cadastrado:
//• o tipo de coleção
//• o número da edição
//• o ano da revista
//• a caixa onde está guardada

namespace ClubeDaMarofa2023.ModuloRevistas
{
    public class RepositorioRevista
    {
        private ArrayList listaDeRevistas = new ArrayList();

        public void Adicionar(Revista revista)
        {
            listaDeRevistas.Add(revista);
        }

        public void Excluir(int numeroEdicao)
        {
            foreach (Revista revista in listaDeRevistas)
            {
                if (revista.NumeroEdicao == numeroEdicao)
                {
                    listaDeRevistas.Remove(revista);
                    break;
                }
            }
        }

        public ArrayList ObterLista()
        {
            return listaDeRevistas;
        }
    }
}
