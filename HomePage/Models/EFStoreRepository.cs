using System.Linq;

namespace HomePage.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Movie> Movies => context.Movies;
        public IQueryable<Product> Products => context.Products;
        public IQueryable<Category> Categories => context.Categories;
        public IQueryable<Media> Medias => context.Medias;
        public IQueryable<Shop> Shops => context.Shops;
    }
}
