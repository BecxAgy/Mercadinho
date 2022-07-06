using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Mercadinho
{
    public class Estoque
    {
        List<Alimentos> alimentos = new List<Alimentos>();
        List<Bebidas> bebidas = new List<Bebidas>();
        List<ProdutosLimpeza> produtosLimpezas = new List<ProdutosLimpeza>();
        public void cadastro()
        {
            Console.WriteLine("Qual tipo de material você deseja cadastrar?");
            Console.WriteLine("[1] - Alimento\n[2] - Bebidas\n[3] - Produtos de Limpeza");
            //partindo para opções
            int opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    Alimentos novoAlimento = new Alimentos();
                    preencherAtributo(novoAlimento);
                    novoAlimento.perguntaEspecificasdasAlimentos();
                    alimentos.Add(novoAlimento);

                    break;

                case 2:
                    //chamo list bebidas
                    Bebidas novaBebida = new Bebidas();
                    preencherAtributo(novaBebida);
                    novaBebida.perguntaEspecificasBebidas();
                    bebidas.Add(novaBebida);
                    
                    break;

                case 3:
                    ProdutosLimpeza novaLimpeza = new ProdutosLimpeza();
                    preencherAtributo(novaLimpeza);
                    novaLimpeza.perguntaEspecificasdasLimpeza();
                    produtosLimpezas.Add(novaLimpeza);

                    break;

                default:
                    Console.WriteLine("Selecione uma opção válida...");
                    break;

            }



        }
        public void preencherAtributo(Produtos produto)
        {
            Console.WriteLine("Informe a descrição do produto:");
            produto.descricao = Console.ReadLine().ToLower();

            Console.WriteLine("Informe a data:");
            produto.dataCadastro = DateTime.Parse(Console.ReadLine());
            while (produto.dataCadastro > DateTime.Now)
            {
                Console.WriteLine("Não pode cadastrar data futura, entre com uma nova data");
                produto.dataCadastro = DateTime.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe a quantidade desse produto");
            produto.quantidade = int.Parse(Console.ReadLine());
        }

        public void Consulta()
        {
            Console.WriteLine("Qual tipo de produto você quer consultar?");
            Console.WriteLine("[1] - Alimento\n[2] - Bebidas\n[3] - Produtos de Limpeza");

            int escolhaConsulta = int.Parse(Console.ReadLine());

            switch (escolhaConsulta)
            {
                case 1:
                    //chamando list de alimentos

                    Console.WriteLine("Digite a descrição do produto");
                    string descricaoAli = Console.ReadLine().ToLower();
                    foreach (var alimento in alimentos) {
                        if (descricaoAli == alimento.descricao)
                        {
                            alimento.ExibirEmbalagem();
                            
                        }
                    }

                    //procurando atraves da descrição do produto formatando para toLower
                    break;
                case 2:
                    //chamando list de bebidas
                    Console.WriteLine("Digite a descrição do produto");
                    string descricaoBeb = Console.ReadLine().ToLower();
                    foreach (var bebida in bebidas)
                    {
                        if (descricaoBeb == bebida.descricao)
                        {
                            bebida.ExibirEmbalagem();
                            Console.WriteLine(bebida.volume); 
                        }
                    }

                    break;

                case 3:

                    Console.WriteLine("Digite a descrição do produto");
                    string descricaoProd = Console.ReadLine().ToLower();
                    foreach (var prodLimpeza in produtosLimpezas)
                    {
                        if (descricaoProd == prodLimpeza.descricao)
                        {
                            prodLimpeza.ExibirEmbalagem();

                        }


                    }
                    break;

                default:
                    Console.WriteLine("Não existe outros produtos além dos exibidos anteriormente. Por favor, digite uma opção válida.."); 
                    break;
            }


            
        }

        public void solicitar()
        {
            
            Console.WriteLine("Qual tipo de produto você quer solicitar?");
            Console.WriteLine("[1] - Alimento\n[2] - Bebidas\n[3] - Produtos de Limpeza");

            int escolhaSolicitacao = int.Parse(Console.ReadLine());

            switch (escolhaSolicitacao)
            {
                case 1:
                    

                    Console.WriteLine("Digite a descrição do produto");
                    string descricaoAli = Console.ReadLine().ToLower();


                    Console.WriteLine("Qual a quantidade que deseja retirar?");
                    int quantidadeRetiradaA = int.Parse(Console.ReadLine());

                    foreach (var alimento in alimentos)
                    {
                        if (descricaoAli == alimento.descricao)
                        {
                            if(quantidadeRetiradaA <= alimento.quantidade)
                            {
                                alimento.quantidade -= quantidadeRetiradaA;
                            }
                            else
                            {
                                Console.WriteLine("Não temos essa quantidade de produtos no nosso estoque");
                            }

                        }
                    }

                    //procurando atraves da descrição do produto formatando para toLower
                    break;
                case 2:
                    //chamando list de bebidas
                    Console.WriteLine("Digite a descrição do produto");
                    string descricaoBeb = Console.ReadLine().ToLower();

                    Console.WriteLine("Qual a quantidade que deseja retirar?");
                    int quantidadeRetiradaB = int.Parse(Console.ReadLine());

                    foreach (var bebida in bebidas)
                    {
                        if (descricaoBeb == bebida.descricao)
                        {
                            if (quantidadeRetiradaB <= bebida.quantidade)
                            {
                                bebida.quantidade -= quantidadeRetiradaB;
                            }
                            else
                            {
                                Console.WriteLine("Não temos essa quantidade de produtos no nosso estoque");
                            }
                        }
                    }

                    break;

                case 3:

                    Console.WriteLine("Digite a descrição do produto");
                    string descricaoProd = Console.ReadLine().ToLower();

                    Console.WriteLine("Qual a quantidade que deseja retirar?");
                    int quantidadeRetiradaP = int.Parse(Console.ReadLine());

                    foreach (var prodLimpeza in produtosLimpezas)
                    {
                        if (descricaoProd == prodLimpeza.descricao)
                        {
                            if (quantidadeRetiradaP <= prodLimpeza.quantidade)
                            {
                                prodLimpeza.quantidade -= quantidadeRetiradaP;
                            }
                            else
                            {
                                Console.WriteLine("Não temos essa quantidade de produtos no nosso estoque");
                            }

                        }


                    }
                    break;

                default:
                    Console.WriteLine("Não existe outros produtos além dos exibidos anteriormente. Por favor, digite uma opção válida..");
                    break;
            }


        }
    }
}
