using System.Linq;

namespace SportsStore2.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
