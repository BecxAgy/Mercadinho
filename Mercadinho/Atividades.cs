using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho
{
    public class Atividades
    {



        static void Main(string[] args)
        {

            Console.WriteLine("Olá! Bem-vindo... ");
            Estoque estoque = new Estoque();
            int opcao = 100;

            while (opcao != 3)
            {
                Console.WriteLine("Selecione o tipo de operação desejada:\n[0] - Cadastrar um produto\n[1] - Consultar um produto\n[2] - Solicitar um produto\n[3] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        estoque.cadastro();
                        break;

                    case 1:
                        estoque.Consulta();
                        break;

                    case 2:
                        estoque.solicitar();
                        break;

            



                    default:
                        Console.WriteLine("Opcão inválida!!");
                        break;
                }
            }
        }



    }

}
