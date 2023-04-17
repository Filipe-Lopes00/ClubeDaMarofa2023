using ClubeDaMarofa2023.ModuloCaixas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClubeDaMarofa2023.ModuloRevistas
{
    public class TelaRevista
    {
       
        private RepositorioRevista repositorioDeRevistas;

        public TelaRevista(RepositorioRevista repositorioDeRevistas)
        {
            this.repositorioDeRevistas = repositorioDeRevistas;
        }

        public void ApresentarMenuCadastroRevista()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----- Cadastro de Revistas -----");
            Console.ResetColor();
            Console.WriteLine("Digite o tipo de coleção: ");
            string tipoColecao = Console.ReadLine();

            Console.WriteLine("Digite o número da edição: ");
            int numeroEdicao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano da revista: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a caixa (1 - Vermelha / 2 - Azul): ");
            int opcaoCaixa = int.Parse(Console.ReadLine());
            Caixa caixa;
            if (opcaoCaixa == 1)
            {
                caixa = Caixa.Vermelha;
            }
            else
            {
                caixa = Caixa.Azul;
            }

            Revista revista = new Revista();
            revista.TipoColecao = tipoColecao;
            revista.NumeroEdicao = numeroEdicao;
            revista.Ano = ano;
            revista.Caixa = caixa;

            repositorioDeRevistas.Adicionar(revista);

            Console.WriteLine();
            Console.WriteLine("Revista cadastrada com sucesso!");
            Console.ReadKey();
        }

        public void VisualizarRevistas()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----- Visualizar Revistas -----");
            Console.ResetColor();
            ArrayList listaDeRevistas = repositorioDeRevistas.ObterLista();

            if (listaDeRevistas.Count == 0)
            {
                Console.WriteLine("Nenhuma revista cadastrada.");
            }
            else
            {
                Console.WriteLine("{0,-20}{1,-15}{2,-10}{3,-10}", "Tipo de Coleção", "Número", "Ano", "Caixa");
                foreach (Revista revista in listaDeRevistas)
                {
                    Console.WriteLine("{0,-20}{1,-15}{2,-10}{3,-10}", revista.TipoColecao, revista.NumeroEdicao, revista.Ano, revista.Caixa);
                }
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();


        }
    }
}