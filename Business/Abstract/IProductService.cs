using Entities.Concrete;

namespace Business.Abstract;
public interface IProductService
{
    List<Product> GetAll();
    Product GetById();
    void Add(Product product);
    void Update(Product product);
    void Delete(Product product);

}