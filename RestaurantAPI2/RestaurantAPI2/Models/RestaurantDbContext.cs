using Microsoft.EntityFrameworkCore;

namespace RestaurantAPI2.Models
{
    public class RestaurantDbContext:DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
