using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;
public interface IProductService
{
    IDataResult<List<Product>> GetAll();
    IDataResult<Product> GetById(int id);
    IResult Add(Product product);
    IResult Update(Product product);
    IResult Delete(Product product);

}