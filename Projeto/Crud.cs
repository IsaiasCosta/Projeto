using System;

namespace Projeto
{
    class Crud : Padrao
    {
        public override void Alterar()
        {
            //Listar indice e nome da Pessoa

            Console.WriteLine("Inform o código para alteração dos dados Pessoais\n");
            for (int i = 0; i < ArmazenarDados.Pessoas.Count; i++)
            {
                Console.WriteLine($"{i + 1} {ArmazenarDados.Pessoas[i].Nome}");
            }
            int codigo = Convert.ToInt16(Console.ReadLine());

            //Objeto Pessoa
            Pessoa pessoa = new();

            //Obter dados Pessoais
            Console.WriteLine("Informe o Nome");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe a Idade");
            pessoa.Idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe a Cidade");
            pessoa.Cidade = Console.ReadLine();

            //Atualizar Lista
            ArmazenarDados.Pessoas[codigo - 1] = pessoa;
        }

        public override void Cadastrar()
        {
            Pessoa pessoa = new();

            //Cadastrar dados Pessoais
            Console.WriteLine("Informe o Nome");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe a Idade");
            pessoa.Idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe a Cidade");
            pessoa.Cidade = Console.ReadLine();

            ArmazenarDados.Pessoas.Add(pessoa);
        }

        public override void Remover()
        {
            //Remover a pessoas da lista 

            Console.WriteLine("Informe o codigo para remover os dados pessoais\n");

            for (int i = 0; i < ArmazenarDados.Pessoas.Count; i++)
            {
                Console.WriteLine($"{i + 1} {ArmazenarDados.Pessoas[i].Nome}");
            }

            int codigo = Convert.ToInt16(Console.ReadLine());

            ArmazenarDados.Pessoas.RemoveAt(codigo - 1);
        }

        public override void Selecionar()
        {
            //Selecioanr os dados Pessoais
            for (int i = 0; i < ArmazenarDados.Pessoas.Count; i++)
            {
                Console.WriteLine($"Nome: {ArmazenarDados.Pessoas[i].Nome}\n" +
                                 
                                  $"Idade:{ArmazenarDados.Pessoas[i].Idade}\n" +
                                 
                                  $"Cidade: {ArmazenarDados.Pessoas[i].Cidade}\n" +
                                  $"========================================");
            }

        }
    }
}
