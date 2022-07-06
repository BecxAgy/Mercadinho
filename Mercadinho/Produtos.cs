using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho
{
    public abstract class Produtos
    {
        //bebidas, alimentos, produtos de limpeza
        //construtor para tornar a classe como objeto 
        public Produtos(string descricao, DateTime dataCadastro, int quantidade)
        {
            this.descricao = descricao;
            this.dataCadastro = dataCadastro;
            this.quantidade = quantidade;
        }

        public Produtos()
        {

        }


        //get set para poder modificar
        public string descricao { get; set; }
        public DateTime dataCadastro { get; set; }
        public int quantidade { get; set; }

        public virtual void ExibirEmbalagem()
        {
            Console.WriteLine("Descrição: " + descricao);
            Console.WriteLine("Data de Cadastro : " + dataCadastro);
            Console.WriteLine("Quantidade: " + quantidade);
        }






    }

 
}
