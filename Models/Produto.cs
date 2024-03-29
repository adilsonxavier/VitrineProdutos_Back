﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace VitrineProdutos.Models
{
    public class Produto
    {
        public Produto()
        {
            ProdutoCategorias = new HashSet<ProdutoCategoria>();
        }

        [Key]
        public int ProdutoId { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [Required]
        public string  ProdutoNome { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string ProdutoDescricao { get; set; }
        
        [Required]
        public decimal ProdutoValor { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? ProdutoValorAntigo { get; set; }


        public virtual ICollection<ProdutoCategoria> ProdutoCategorias { get; set; }


        [NotMapped]  // Indica que o campo não tem correspondente no BD
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public string ImageSrc { get; set; }

        [NotMapped]
        public int QtdTotalItens { get; set; }


    }
}
