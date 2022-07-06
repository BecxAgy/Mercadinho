using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho
{
    public class Alimentos : Produtos
    {
        public bool ehDoce { get; set; }
        public bool ehCarne { get; set; }
        public bool ehVegetal { get; set; }
        public bool ehHortalica { get; set; }


        public Alimentos( ){
            this.ehDoce = false;
            this.ehCarne = false;
            this.ehVegetal = false;
            this.ehHortalica = false;
          

        }

        

        public override void ExibirEmbalagem()
        {

            base.ExibirEmbalagem();
            

        }
        
        public void perguntaEspecificasdasAlimentos()
        {
            Console.WriteLine("Especifique o alimento:");
            Console.WriteLine("[1] - Doces\n[2] - Carnes \n [3] - Vegetais\n[4] - Hortaliças\n");
            int escolhendoEspecifico = int.Parse(Console.ReadLine());
         

            switch (escolhendoEspecifico)
            {
                case 1:
                    this.ehDoce = true;
                   
                    break;

                case 2:
                    this.ehCarne= true;
                    
                    break;

                case 3:
                    this.ehVegetal = true;
                    
                    break;

                case 4:
                    this.ehHortalica = true;
                    
                    break;

                default:
                    break;

            }
           
            
            


        }







    }
}
