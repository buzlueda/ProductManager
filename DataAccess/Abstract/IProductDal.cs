using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<ProductDetailDto> GetProducts();
    }
}