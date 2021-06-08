using System;

namespace ProjetoProduto09_06.Classes
{
    public class Login
    {
        private bool Logado;

        public Login(){
            Console.WriteLine($@"
Seja bem vindo
Para acessar nosso menu, você deve se cadastrar e logar sua conta.
Deseja fazer isso? (s/n)
            ");
            string desejaCadastrar = Console.ReadLine().ToLower();

            if (desejaCadastrar == "s")
            {   
                Usuario u1 = new Usuario ();
                Console.WriteLine(u1.Cadastrar(u1));
                Logar(u1);
            }
            else if (desejaCadastrar == "n")
            {
                Console.WriteLine("Até mais");
            }
            else
            {
                Console.WriteLine("Digite uma opção válida");
            }
            
        }
        public string Logar(Usuario usuario){
            Console.WriteLine("Insira seu email");
            string Email = Console.ReadLine();

            Console.WriteLine("Insira sua senha");
            string Senha = Console.ReadLine();

            if (Email == usuario.Email && Senha == usuario.Senha)
            {
                Logado = true;
            }


            return $"Usuario {usuario} logado";

        }
        public string Deslogar(Usuario usuario){
            Logado = false;
            return $"Usuario {usuario} deslogado";
        }
    }
}