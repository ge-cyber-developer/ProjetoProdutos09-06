using System;

namespace ProjetoProduto09_06.Classes
{
    public class Login
    {
        private bool Logado;
        public Login(){
            Console.WriteLine("Menu");
        }
        public string Logar(Usuario usuario){
            return $"Usuario {usuario} logado";
        }
        public string Deslogar(Usuario usuario){
            return $"Usuario {usuario} deslogado";
        }
    }
}