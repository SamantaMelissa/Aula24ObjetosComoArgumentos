using System;
using System.Collections.Generic;

namespace Aula24ObjetosComoArgumentos
{   //CRUD --> Sigla de funcionalidade que podemos fazer em determinada classe e objeto.  
    //Create Read Update Delete (CRUD) --> Criar, ler, alterar e excluir.
    
    public class Carrinho
    {
        // 0 - Criamos uma propriedade para guardar o valor total do carrinho
        public float ValorTotal {get; set;}

        // 1 - Criamos uma lista que representará nosso carrinho

        List<Produto> carrinho = new List<Produto>();

        // 2- Criamos o método que adiciona um produto ao carrinho, passando todo o objeto como argumento
        public void AdicionarProduto(Produto produto){

            carrinho.Add(produto);
        }

        // 3 - Criamos o método que remove um produto do carrinho
        public void RemoverProduto(Produto produto){
            carrinho.Remove(produto);
        }

        //Podemos criar um método para listar os produtos que estão no carrinho

        public void MostrarProduto(){

            Console.ForegroundColor = ConsoleColor.Blue;
            if(carrinho != null){

                foreach(Produto p in carrinho){
                    ValorTotal += p.Preco;
                }
            Console.WriteLine($"Total do carrinho: ${ValorTotal.ToString("n2")}");
            
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            }else{
                Console.WriteLine($"Seu carrinho ainda está vazio!");
            }

            Console.ResetColor();
        }

        // 6 - Podemos alterar um determinado produto

        public void AlterarItem(int _codigo, Produto _novoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
    }
}