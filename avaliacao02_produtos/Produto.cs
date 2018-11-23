using System;
namespace avaliacao02_produtos
{
    public class Produto
    {

        public string nome{ get; set; }
        public double preco { get; set; }
        public Categoria categoria { get; set; }//associacao 
        public Produto()
        {
        }
    }
}
