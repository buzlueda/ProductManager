using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}