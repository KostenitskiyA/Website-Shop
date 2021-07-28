using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Website_Shop.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserType> UserTypes { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options) 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var profile1 = new Profile()
            {
                Id = 1,
                Name = "Вадим Чуйка",
                UserId = 1,
                UserTypeId = 1
            };
            var profile2 = new Profile()
            {
                Id = 2,
                Name = "Александр Кашкай",
                UserId = 2,
                UserTypeId = 2
            };
            var profile3 = new Profile()
            {
                Id = 3,
                Name = "Влад Валакас",
                UserId = 3,
                UserTypeId = 3
            };
            var profiles = new List<Profile>()
            {
                profile1,
                profile2,
                profile3
            };

            var user1 = new User()
            {
                Id = 1,
                Login = "Vadim",
                Password = "Alladin"
            };
            var user2 = new User()
            {
                Id = 2,
                Login = "Sasha",
                Password = "Natasha"
            };
            var user3 = new User()
            {
                Id = 3,
                Login = "Vlad",
                Password = "Borad"
            };
            var users = new List<User>()
            {
                user1,
                user2,
                user3
            };

            var userType1 = new UserType()
            {
                Id = 1,
                Name = "Администратор"
            };
            var userType2 = new UserType()
            {
                Id = 2,
                Name = "Продавец"
            };
            var userType3 = new UserType()
            {
                Id = 3,
                Name = "Покупатель"
            };
            var userTypes = new List<UserType>()
            {
                userType1,
                userType2,
                userType3
            };

            modelBuilder.Entity<UserType>()
                .HasData(userTypes);

            modelBuilder.Entity<User>()
                .HasData(users);

            modelBuilder.Entity<Profile>()
                .HasData(profiles);

            /// Связь One-to-One
            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(u => u.User)
                .HasForeignKey<Profile>(p => p.UserId);

            /// Связь One-to-Many
            modelBuilder.Entity<Profile>()
                .HasOne(u => u.UserType)
                .WithMany(u => u.Profiles)
                .HasForeignKey(p => p.UserTypeId);
        }
    }
}
