﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Respository.Models
{
    public partial class Account
    {
        [Key]
        [Column("uID")]
        public int UId { get; set; }
        [Column("user")]
        [StringLength(255)]
        [Unicode(false)]
        public string User { get; set; }
        [Column("pass")]
        [StringLength(255)]
        [Unicode(false)]
        public string Pass { get; set; }
        [Column("isSell")]
        public int? IsSell { get; set; }
        [Column("isAdmin")]
        public int? IsAdmin { get; set; }
    }
}