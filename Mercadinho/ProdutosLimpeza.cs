using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho
{
    public class ProdutosLimpeza : Produtos 
    {
        public bool ehSabao { get; set; }
        public bool ehAmaciante { get; set; }
        public bool ehDesinfetante { get; set; }

        public ProdutosLimpeza()
        {
            this.ehSabao = false;
            this.ehAmaciante = false;
            this.ehDesinfetante = false;
            
        }

        public override void ExibirEmbalagem()
        {
            base.ExibirEmbalagem();
            

        }

        public void perguntaEspecificasdasLimpeza()
        {
            Console.WriteLine("Especifique o alimento:");
            Console.WriteLine("[1] - Sabão\n[2] - Amaciante \n [3] - Desinfetante\n");
            int escolhendoEspecifico = int.Parse(Console.ReadLine());
            

            switch (escolhendoEspecifico)
            {
                case 1:
                    this.ehSabao = true;
                    break;

                case 2:
                    this.ehAmaciante = true;

                    break;

                case 3:
                    this.ehDesinfetante = true;
                    break;

                default:
                    break;

            }

        }
    }
}
