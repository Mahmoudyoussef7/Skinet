using Microsoft.EntityFrameworkCore;

namespace Core.Entities
{
    public class StoreContext:DbContext
    {
        protected StoreContext() : base()
        {
        }

        public StoreContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<ProductBrand> ProductBrands { get; set; }
    }
}
