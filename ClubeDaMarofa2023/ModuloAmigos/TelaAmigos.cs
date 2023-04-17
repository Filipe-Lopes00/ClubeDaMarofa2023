using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Dynamic;
using System.Drawing;

namespace ClubeDaMarofa2023.ModulosAmigos
{
    public class TelaAmigos
    {
        public RepositorioAmigos repositorio = null;

       
        public void ApresentarMenuCadastroAmigos()
        {

              Amigos amigos = new Amigos();

        Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CADASTRO DE AMIGOS");
            Console.ResetColor();

            Console.WriteLine("Nome do amigo:  ");
            amigos.nome = Console.ReadLine();

            Console.WriteLine("Nome do responsável: ");
            amigos.nomeResponsavel = Console.ReadLine();

            Console.WriteLine("Telefone: ");
            amigos.telefone = Console.ReadLine();

            Console.WriteLine("Endereço: ");
            amigos.endereco = Console.ReadLine();

            Console.WriteLine("Digite 0 para voltar!");
            string voltar = Console.ReadLine();

            repositorio.Inserir(amigos);

        }

        public void VisualizarAmigos()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15}| {4,-40}", "Id", "Nome", "Nome Responsável", "Telefone", "Endereço");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.ResetColor ();
            foreach (Amigos amigos in repositorio.SelecionarTodos())
            {
                Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15} | {4,-40}", amigos.id, amigos.nome, amigos.nomeResponsavel, amigos.telefone, amigos.endereco);
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }

        public void VisualizartTabela() 
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15}| {4,-40}", "Id", "Nome", "Nome Responsável", "Telefone", "Endereço");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
            foreach (Amigos amigos in repositorio.SelecionarTodos())
            {
                Console.WriteLine("{0,-5} | {1,-25} | {2,-30} | {3,-15} | {4,-40}", amigos.id, amigos.nome, amigos.nomeResponsavel, amigos.telefone, amigos.endereco);
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }


    }
}
