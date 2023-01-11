using Rhuan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rhuan
{
    public class Service
    {
        public Service()
        {

        }

        public List<ItemCliente> IncluirItemCliente()
        {
            List<ItemCliente> list = new List<ItemCliente>();

            ItemCliente item = new ItemCliente() { Id = 1, Descricao = "prego", quantidade = 100 };
            list.Add(item);

            item = new ItemCliente() { Id = 2, Descricao = "madeira", quantidade = 5 };
            list.Add(item);

            return list;
        }

        public List<Fornecedor> IncluirItemFornecedor()
        {
            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor { Id = 1, Name = "Tumelero" };            

            List<ItemFornecedor> list = new List<ItemFornecedor>();

            ItemFornecedor item = new ItemFornecedor() { Id = 1, Descricao = "parafuso", Quantidade = 100, IdItemCliente = 1};
            list.Add(item);

            item = new ItemFornecedor() { Id = 2, Descricao = "madeira", Quantidade = 5, IdItemCliente = 2};
            list.Add(item);

            fornecedor.ItemFornecedor = new List<ItemFornecedor>();
            fornecedor.ItemFornecedor.AddRange(list);
            fornecedorList.Add(fornecedor);

            fornecedor = new Fornecedor { Id = 2, Name = "FMA" };
            list = new List<ItemFornecedor>();

            item = new ItemFornecedor() { Id = 1, Descricao = "prego", Quantidade = 100, IdItemCliente = 1};
            list.Add(item);

            item = new ItemFornecedor() { Id = 2, Descricao = "arvore", Quantidade = 5, IdItemCliente = 2};
            list.Add(item);
            fornecedor.ItemFornecedor = new List<ItemFornecedor>();
            fornecedor.ItemFornecedor.AddRange(list);
            fornecedorList.Add(fornecedor);

            return fornecedorList;
        }
    }
}
