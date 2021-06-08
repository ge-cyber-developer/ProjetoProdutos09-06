using System;

namespace ProjetoProduto09_06.Classes
{
    public class Usuario
    {
        protected int Codigo;
        protected string Nome;
        public string Email;
        public string Senha;
        protected DateTime DataCadastro;

        public string Cadastrar(Usuario usuario){

            Console.Write("Digite o código do usuário que você deseja cadastrar:  ");
            Codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do usuário que você deseja cadastrar:  ");
            Nome = Console.ReadLine();

            Console.Write("Digite o email do usuário que você deseja cadastrar:  ");
            Email = Console.ReadLine();

            Console.Write("Digite a senha do usuário que você deseja cadastrar:  ");
            Senha = Console.ReadLine();

            Console.WriteLine($"\nCódigo:  {usuario.Codigo}");
            Console.WriteLine($"Nome:  {usuario.Nome}");
            Console.WriteLine($"Email:  {usuario.Email}");
            Console.WriteLine($"Senha:  {usuario.Senha}");

            return $"\nUsuário {usuario.Nome} cadastrado\n";
        }

        public string Deletar(Usuario usuario){
            return $"Usuário {usuario} deletado";
        }

    }
}