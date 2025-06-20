using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Armazenar informações,mescolher a deciçaõa seer tomada

            int escolha;

            //objtos

            Crud crud = new();

            //Lista de escolhas
            do
            {
                Console.WriteLine(" ======= Escolha uma das Opções: ======= \n");
                Console.WriteLine("[1]: Cadastrar\n[2]: Selecinar\n[3]: Atualizar\n[4]: Excluir\n[5]: Finalizar Programa");
                escolha = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("======================================== \n");

                //Escolha um das opções abaixo e prosiga
                switch (escolha)
                {
                    case 1:
                        crud.Cadastrar();
                        break;
                    case 2:
                        crud.Selecionar();
                        break;
                    case 3:
                        crud.Alterar();
                        break;
                    case 4:
                        crud.Remover();
                        break;
                    case 5:
                        Console.WriteLine("Programa encerrado !");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                    
                }
            } while (escolha != 5);
            Console.ReadKey();
        }
    }
}
