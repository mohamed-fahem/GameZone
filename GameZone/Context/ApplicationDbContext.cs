namespace GameZone.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<GameDevice> GameDevices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameDevice>()
                .HasKey(e => new { e.GameId, e.DeviceId });

            modelBuilder.Entity<Category>()
                .HasData(new Category[]
                {
                    new Category{ CategoryId = 1 , CategoryName= "Action"},
                    new Category{ CategoryId = 2 , CategoryName= "Sport"},
                    new Category{ CategoryId = 3 , CategoryName= "Racing"},
                    new Category{ CategoryId = 4 , CategoryName= "Film"},
                    new Category{ CategoryId = 5 , CategoryName= "Figting"},
                });


            modelBuilder.Entity<Device>()
                .HasData(new Device[]
                {
                    new Device { DeviceId = 1, DeviceName = "PlayStation", Icon = "bi bi-playstation" },
                    new Device { DeviceId = 2, DeviceName = "xbox", Icon = "bi bi-xbox" },
                    new Device { DeviceId = 3, DeviceName = "Nintendo Switch", Icon = "bi bi-nintendo-switch" },
                    new Device { DeviceId = 4, DeviceName = "PC", Icon = "bi bi-pc-display" }
                });


        }
    }
}
