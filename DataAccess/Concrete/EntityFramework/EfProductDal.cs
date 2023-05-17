using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;
public class EfProductDal : EfEntityRepositoryBase<Product, ProductManagerContext>, IProductDal
{
    public List<ProductDetailDto> GetProductDetails()
    {
        using (ProductManagerContext context = new ProductManagerContext())
        {
            var result = from p in context.Products
                         join c in context.Categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDetailDto
                         {
                             ProductId = p.Id,
                             ProductName = p.ProductName,
                             CategoryName = c.CategoryName
                         };
            return result.ToList();

        }
    }
}
