using System;
using System.Collections.Generic;

namespace avaliacao02_produtos
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Produto> lsProduto = new List<Produto>();
            Produto produto = new Produto();
            Categoria categoria = new Categoria();

            for (int i = 1; i <= 10; i++){
                Console.WriteLine("Informe Nome: ");
                produto.nome = Console.ReadLine();

                Console.WriteLine("Informe Preco: ");
                produto.preco =Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe tipo: ");
                categoria.tipo = Console.ReadLine();
                produto.categoria = categoria;

                lsProduto.Add(produto);
            }


            foreach(var i in lsProduto){
                Console.WriteLine("Produto: {0}\nPreco: {1}\nTipo: {2}\n\n",i.nome,i.preco,i.categoria.tipo);
            }
        }
    }
}
