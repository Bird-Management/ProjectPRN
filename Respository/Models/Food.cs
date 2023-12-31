﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Respository.Models
{
    public partial class Food
    {
        [Key]
        [Column("FoodID")]
        [StringLength(10)]
        public string FoodId { get; set; }
        [StringLength(50)]
        public string FoodName { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [StringLength(50)]
        public string Producer { get; set; }
        public int? Amount { get; set; }
        public double? Price { get; set; }
        public bool? Status { get; set; }
    }
}