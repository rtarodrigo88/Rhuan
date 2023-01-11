using System;
using System.Collections.Generic;
using System.Text;

namespace Rhuan.Models
{
    public class ItemCliente
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal quantidade { get; set; }
        public List<ItemFornecedor> ItemFornecedor { get; set; }
    }
}
