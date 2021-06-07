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
                
            }
            else if (desejaCadastrar == "n")
            {
                
            }
            else
            {
                
            }
            
        }
        public string Logar(Usuario usuario){
            Logado = true;
            return $"Usuario {usuario} logado";

        }
        public string Deslogar(Usuario usuario){
            Logado = false;
            return $"Usuario {usuario} deslogado";
        }
    }
}