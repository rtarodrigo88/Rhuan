using Rhuan.Models;
using System;
using System.Linq;

namespace Rhuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();

            var itemCliente = service.IncluirItemCliente();
            var itemForncedor = service.IncluirItemFornecedor();
            int count = 0;
            foreach (var item in itemCliente)
            {
                count++;
                Console.WriteLine("ITEM " + count);
                Console.WriteLine("Cliente Id " + item.Id);
                Console.WriteLine("Cliente Descrição " + item.Descricao);
                Console.WriteLine("Cliente Quantidade " + item.quantidade);
                foreach (var itens in itemForncedor)
                {
                    var test = itens.ItemFornecedor.FirstOrDefault(x => x.IdItemCliente == item.Id);

                    Console.WriteLine("Fornecedor Nome " + itens.Name);
                    Console.WriteLine("Fornecedor Id " + test.Id);
                    Console.WriteLine("Fornecedor Descrição " + test.Descricao);
                    Console.WriteLine("Fornecedor Quantidade " + test.Quantidade);

                }
                //Console.WriteLine("Fornecedor " + item.ItemFornecedor.);
                //Console.WriteLine("Fornecedor " + item.ItemFornecedor.Descricao);
                //Console.WriteLine("Fornecedor " + item.ItemFornecedor.quantidade);
            }

            
            foreach (var item in itemCliente)
            {
                
            }

            Console.WriteLine("Hello World!");
        }


    }
}
