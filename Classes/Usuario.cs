using System;

namespace ProjetoProduto09_06.Classes
{
    public class Usuario
    {
        private int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        private DateTime DataCadastro { get; set; }

        public string Cadastrar(Usuario usuario){

            Console.Write("Digite o código do usuário que você deseja cadastrar:  ");
            usuario.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do usuário que você deseja cadastrar:  ");
            usuario.Nome = Console.ReadLine();

            Console.Write("Digite o email do usuário que você deseja cadastrar:  ");
            usuario.Email = Console.ReadLine();

            Console.Write("Digite a senha do usuário que você deseja cadastrar:  ");
            usuario.Senha = Console.ReadLine();

            Console.WriteLine($"\nCódigo:  {usuario.Codigo}");
            Console.WriteLine($"Nome:  {usuario.Nome}");
            Console.WriteLine($"Email:  {usuario.Email}");
            Console.WriteLine($"Senha:  {usuario.Senha}");

            return $"\nUsuário {usuario.Nome} cadastrado";
        }

        public string Deletar(Usuario usuario){
            return $"Usuário {usuario} deletado";
        }

    }
}