﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Models
{
    public class Categoria : Entity
    {
        public string Descricao { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}