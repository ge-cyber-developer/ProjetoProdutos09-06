using System;

namespace ProjetoProduto09_06.Classes
{
    public class Login
    {
        private bool Logado { get; set; }

        public Login()
        {
            string desejaCadastrar;
            do
            {
                Console.WriteLine($@"
Seja bem vindo
Para acessar nosso menu, você deve se cadastrar e logar sua conta.
Deseja fazer isso? (s/n)
            ");
                desejaCadastrar = Console.ReadLine().ToLower();

                if (desejaCadastrar == "s")
                {
                    Usuario u1 = new Usuario();
                    Console.WriteLine(u1.Cadastrar(u1));
                    Console.WriteLine(Logar(u1));
                }
                else if (desejaCadastrar == "n")
                {
                    Console.WriteLine("Até mais");
                    Logado = false;
                }
                else
                {
                    Console.WriteLine("Digite uma opção válida");
                }
            } while (desejaCadastrar != "s" && desejaCadastrar != "n");

            Produto p = new Produto();
            do
            {
                if (Logado == true)
                {
                    Console.WriteLine($@"
    Você deseja:
1 - Cadastrar Produto
2 - Listar Produtos
3 - Deletar Produtos
4 - Cadastrar Marca
5 - Listar Marca
6 - Deletar Marca
7 - Sair do Sistema
            ");

                    string opcaoMenu = Console.ReadLine();

                    switch (opcaoMenu)
                    {
                        case "1":
                            Console.WriteLine(p.Cadastrar(p));
                            break;
                        case "2":

                            break;
                        case "3":
                            Console.WriteLine(p.Deletar(p));
                            break;
                        case "4":

                            break;
                        case "5":

                            break;
                        case "6":
                            break;
                        case "7":
                            Console.WriteLine("Até mais");
                            Logado = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Insira uma opção válida");
                            break;
                    }
                }
            } while (Logado == true);
        }

        public string Logar(Usuario usuario)
        {
            Console.WriteLine("\nLogar\n\nInsira seu email");
            string Email = Console.ReadLine();

            Console.WriteLine("\nInsira sua senha");
            string Senha = Console.ReadLine();

            if (Email == usuario.Email && Senha == usuario.Senha)
            {
                Logado = true;
                return $"\nUsuario {usuario.Nome} logado. Seja bem vindo.";
            }
            else
            {
                return "Email e/ou senha incorreto";
            }
        }
        public string Deslogar(Usuario usuario)
        {
            Logado = false;
            return $"Usuario {usuario} deslogado. Até mais.";
        }
    }
}