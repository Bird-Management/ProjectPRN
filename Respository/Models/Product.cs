﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Respository.Models
{
    public partial class Product
    {
        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        public string Image { get; set; }
        public double? Price { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Column("CategoryID")]
        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Product")]
        public virtual Category Category { get; set; }
    }
}