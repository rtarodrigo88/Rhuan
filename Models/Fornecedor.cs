﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rhuan.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ItemFornecedor> ItemFornecedor { get; set; }
    }
}
