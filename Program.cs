using System;
using System.Collections.Generic;

namespace ATIVIDADE___Produto
{
    class Marcas
    {
        static void Main(string[] args)
        {
            List<Marca> ListaMarcas = new List<Marca>();

            while (true)
            {
                Console.WriteLine("Deseja Cadastrar, Listar ou Deletar um item ? | 1 - Cadastro | 2 - Listar | 3 - Deletar ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite o código da marca: ");
                    int codigo = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome da marca: ");
                    string nomemarca = Console.ReadLine();

                    Console.WriteLine("Digite a data de cadastro (formato dia/mês/ano): ");
                    string data = Console.ReadLine();
                    DateTime datacadastro = DateTime.ParseExact(data,"dd/MM/yyyy", null);

                     Console.WriteLine("Confirmação Data de Cadastro: " + datacadastro.Day + " " + datacadastro.Month + " " + datacadastro.Year);
                     
                    Cadastrar(codigo, nomemarca, datacadastro, ListaMarcas);
                }
                else if (opcao == 2)
                {
                   ListarMarcas(ListaMarcas);
                }
                else if (opcao == 3)
                {
                   Console.WriteLine("Digite o código da Marca que deseja deletar: ");
                   int codigo = int.Parse(Console.ReadLine());
                   DeletarMarcas(codigo, ListaMarcas);

                }
                else 
                {
                    Console.WriteLine("Opção inválida! Por favor tente novamente.");
                }
            }    
            
        }
       
       public class Marca 
       {
            private int codigo;
            private string nomemarca;
            private DateTime datacadastro;

            public int Codigo { get => codigo; set => codigo = value;}
            public string NomeMarca { get => nomemarca; set => nomemarca = value;}
            public DateTime DataCadastro { get => datacadastro; set => datacadastro = value;}
       }

            static void Cadastrar(int codigo, string nomemarca, DateTime datacadastro ,List<Marca> ListaMarcas)
           {
              Marca objeto = new Marca();
              objeto.Codigo = codigo;
              objeto.NomeMarca = nomemarca;
              objeto.DataCadastro = datacadastro;
              ListaMarcas.Add(objeto);
           }

             static void ListarMarcas (List<Marca> ListaMarcas)
           {
                foreach (var marca in ListaMarcas)
                {
                    Console.WriteLine("[CÓDIGO]: "+marca.Codigo+" [NOME MARCA]: "+marca.NomeMarca+" [DATA DE CADASTRO]: "+marca.DataCadastro);
                }
           }

              static void DeletarMarcas ( int codigo, List<Marca> ListaMarcas)
           {
              ListaMarcas.RemoveAll(objeto => objeto.Codigo == codigo);
              Console.WriteLine("Marca deletada com sucesso!");
           }

    }
}
