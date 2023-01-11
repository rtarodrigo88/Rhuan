using System;
using System.Collections.Generic;
using System.Text;

namespace Rhuan.Models
{
    public class ItemFornecedor
    {
        public int Id { get; set; }        
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public int IdItemCliente { get; set; }

    }
}
