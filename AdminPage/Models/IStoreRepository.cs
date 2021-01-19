using AdminPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPage.Models
{
    public class IStoreRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Media> Medias { get; }
        IQueryable<Category> Categories { get; }
    }
}
