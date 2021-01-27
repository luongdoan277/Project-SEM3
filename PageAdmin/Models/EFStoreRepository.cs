using PageAdmin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageAdmin.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private PageAdminContext context;

        public EFStoreRepository(PageAdminContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
        public IQueryable<Category> Categories => context.Categories;
        public IQueryable<Media> Medias => context.Medias;
        public IQueryable<Movie> Movies => context.Movies;
    }
}
