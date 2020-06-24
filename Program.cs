using System;

namespace Aula24ObjetosComoArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();
            //Criamos alhuns produtos
            Produto p1 = new Produto(01, "Livro Angustia - Graciliano Ramos", 45.90f);
            Produto p2 = new Produto(02, "Livro A culpa é das estrelas - John Green", 38.9f);
            Produto p3 = new Produto(03, "Black Bird - Anna Carey", 29.90f);
            Produto p4 = new Produto(04, "Livro Serial Killers - Ilana Casoy", 69.90f);

            //Adicionamos eles ao carrinho
            cart.AdicionarProduto(p1);
            cart.AdicionarProduto(p2);
            cart.AdicionarProduto(p3);

            cart.RemoverProduto(p2);
    
            Produto prodAlt = new Produto(04, "Dicionário Michaelis - Inglês", 39.9f);
            cart.AlterarItem(04, prodAlt);

            //Mostramos nosso carrinho completo:

            cart.MostrarProduto();




        }
    }
}
