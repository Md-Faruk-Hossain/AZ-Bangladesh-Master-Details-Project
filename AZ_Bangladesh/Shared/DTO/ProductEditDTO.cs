﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using AZ_Bangladesh.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AZ_Bangladesh.Shared.DTO
{
    public class ProductEditDTO
    {
        public int ProductID { get; set; }
        [Required, StringLength(50), Display(Name = "Product Name")]
        public string ProductName { get; set; } = default!;
        [Required, DataType(DataType.Currency), DisplayFormat(DataFormatString = "{0:0.00}")]
        public decimal Price { get; set; }
        [StringLength(150)]
        public string Picture { get; set; } = default!;
        public bool IsAvailable { get; set; }
        
    }
}
