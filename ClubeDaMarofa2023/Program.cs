

using ClubeDaMarofa2023.ModuloApresentacoes;
using ClubeDaMarofa2023.ModuloCaixas;
using ClubeDaMarofa2023.ModuloEmprestimos;
using ClubeDaMarofa2023.ModuloRevistas;
using ClubeDaMarofa2023.ModulosAmigos;
using System.Drawing;

//COMANDOS
//      Console.ForegroundColor = color;
//Console.Write(message);
//Console.ResetColor();

internal class Program
{
    public static void ApresentarMenu()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-------- Menu Principal --------");      
        Console.WriteLine("1 - Cadastro de Amigos");
        Console.WriteLine("2 - visualizar Amigos");
        Console.WriteLine("3 - EXCLUIR amigos");
        Console.WriteLine("4 - Editar amigos");
        Console.WriteLine("5 - cadastrar Revista");
        Console.WriteLine("6 - Vizualizar Revista");
        Console.WriteLine("7 - Mostrar Caixas");           
        Console.WriteLine("0 - Sair");       
        Console.WriteLine("--------------------------------");      
        Console.ResetColor ();
    }
     static void Main(string[] args)

    {

        TabelaDeEmprestimosMensal tabelaDeEmprestimosMensal = new TabelaDeEmprestimosMensal();
        TabelaDeEmprestimos tabelaDeEmprestimos = new TabelaDeEmprestimos();
        TelaEmprestimos telaEmprestimos = new TelaEmprestimos();
        TelaDevolucao telaDevolucao = new TelaDevolucao();       
        RepositorioRevista listaDeRevista = new RepositorioRevista();        
        RepositorioAmigos repositorioDeAmigos = new RepositorioAmigos();
        TelaAmigos telaAmigos = new TelaAmigos();
        telaAmigos.repositorio = repositorioDeAmigos;
        TelaCaixa telaCaixas = new TelaCaixa();
        RepositorioRevista repositorioDeRevistas = new RepositorioRevista();
        TelaRevista telaRevista = new TelaRevista(repositorioDeRevistas);
        

        bool sairVoltar = true;
        while (sairVoltar)
        {   
           
            Console.Clear();
            ApresentarMenu();
            int opcao = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    telaAmigos.ApresentarMenuCadastroAmigos();
                    break;
                case 2:
                    Console.Clear();
                    telaAmigos.VisualizarAmigos();
                    break;

                case 3:
                    do
                    {
                        Console.Clear();
                        telaAmigos.VisualizartTabela();
                        Console.WriteLine();
                        Console.WriteLine("Selecione o ID do amigo a ser removido (ou digite 0 para voltar): ");
                        int id = int.Parse(Console.ReadLine());

                        if (id == 0)
                        {
                            break; // sai do loop e retorna ao menu principal
                        }

                        repositorioDeAmigos.Excluir(id);
                    } while (true); // repete o loop até o usuário selecionar a opção 0

                    break;

                case 4:
                    do
                    {
                        Console.Clear();
                        telaAmigos.VisualizartTabela();
                        Console.WriteLine();
                        Console.WriteLine("Selecione o ID do amigo a ser editado (ou digite 0 para voltar): ");
                        int idSelecionado = int.Parse(Console.ReadLine());

                        if (idSelecionado == 0)
                        {
                            break; 
                        }

                        Console.WriteLine("Digite o novo nome: ");
                        string novoNome = Console.ReadLine();

                        Console.WriteLine("Digite o novo responsável: ");
                        string novoResponsavel = Console.ReadLine();

                        Console.WriteLine("Digite o novo telefone: ");
                        string novoTelefone = Console.ReadLine();

                        Console.WriteLine("Digite o novo endereço: ");
                        string novoEndereco = Console.ReadLine();

                        Amigos novoAmigo = new Amigos();
                        novoAmigo.nome = novoNome;
                        novoAmigo.nomeResponsavel = novoResponsavel;
                        novoAmigo.telefone = novoTelefone;
                        novoAmigo.endereco = novoEndereco;

                        repositorioDeAmigos.Editar(idSelecionado, novoAmigo);
                    } while (true); 

                    break;

                  case 5:
                    Console.Clear();
                    telaRevista.ApresentarMenuCadastroRevista();
                    return;
                  case 6:
                    Console.Clear();
                    telaRevista.VisualizarRevistas();
                    return;




                   case 0:
                      sairVoltar = false;
                      break;
            }
        }



    }

   
}
