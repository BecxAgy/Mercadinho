using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho
{
    class Bebidas : Produtos
    {
        public bool temAlcool { get; set; }
        public bool ehLeite { get; set; }
        public bool ehRefri { get; set; }
        public bool ehSucos { get; set; }
        public float volume { get; set; }

        public Bebidas()
        {
            this.temAlcool = false;
            this.ehLeite = false;
            this.ehRefri = false;
            this.ehSucos = false;

        }

        public override void ExibirEmbalagem()
        {
            base.ExibirEmbalagem();

           

        }

        public void perguntaEspecificasBebidas()
        {
            Console.WriteLine("Especifique o alimento:");
            Console.WriteLine("[1] - Alcóolico\n[2] - Laticínios\n [3] - Refrigerantes\n[4] - Sucos\n");
            int escolhendoEspecifico = int.Parse(Console.ReadLine());

            switch (escolhendoEspecifico)
            {
                case 1:
                    this.temAlcool = true;
                    break;

                case 2: 
                    this.ehLeite = true;
      
                    break;

                case 3:
                    this.ehRefri = true;
                    break;

                case 4:
                   this.ehSucos = true;
                    break;

                default:
                    break;

            }
            Console.WriteLine("Qual o volume da bebida em litros...");
            this.volume = float.Parse(Console.ReadLine());
            

        }
    }
}
