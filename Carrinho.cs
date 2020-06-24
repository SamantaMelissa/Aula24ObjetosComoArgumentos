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
        public void RemoverProduto(Produto prod){
            carrinho.Remove(prod);
        }

        //Podemos criar um método para listar os produtos que estão no carrinho

        public void Ler(){
            foreach(Produto item in carrinho){
                System.Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
        }
        public void MostrarTotal(){

            Console.ForegroundColor = ConsoleColor.Blue;
                foreach(Produto item in carrinho){
                    ValorTotal += item.Preco;
                }
            Console.WriteLine($"Total do carrinho: ${ValorTotal.ToString("n2")}");
            
            Console.ResetColor();
            
        }

        // 6 - Podemos alterar um determinado produto

        public void AlterarItem(Int32 _cod, Produto _novoProduto){
            carrinho.Find(x => x.Codigo == _cod).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _cod).Preco = _novoProduto.Preco;
        }
    }
}