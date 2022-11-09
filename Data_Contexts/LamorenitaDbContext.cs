using Lamorenita.Data_Entities;
using Microsoft.EntityFrameworkCore;

namespace Lamorenita.Data_Contexts
{
    public class LamorenitaDbContext : DbContext
    {
        public LamorenitaDbContext(DbContextOptions<LamorenitaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region My DbSet
        public DbSet<UserEntity> User { get; set; }
        public  DbSet<ProductTypeEntity> ProductType { get; set; }
        public DbSet<ProductEntity> Product { get; set; }

        public DbSet<ContactEntity> Contact { get; set; }
        public DbSet<DirectionEntity> Direction { get; set; }
        public DbSet<PhoneNumberEntity> PhoneNumber { get; set; }
        public DbSet<ContactDirectionEntity> ContactDirection { get; set; }

        public DbSet<StoreEntity> Store { get; set; }
        public DbSet<StoreDirectionEntity> StoreDirection { get; set; }
        public DbSet<StoreManagerEntity> StoreManager { get; set; }
        #endregion}
    }
}
