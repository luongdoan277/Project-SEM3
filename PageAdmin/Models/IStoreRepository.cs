using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageAdmin.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Media> Medias { get; }
        IQueryable<Category> Categories { get; }
    }
}
