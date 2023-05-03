using Core.Entities;

namespace Entities.Concrete;
public class Product : IEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
}
