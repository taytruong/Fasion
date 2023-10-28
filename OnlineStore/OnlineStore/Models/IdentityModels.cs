using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OnlineStore.Models.EF_data;

namespace OnlineStore.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Fullname { get; set; }
        public string Phone { get; set; } 
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        /*public  DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public  DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<tb_Adv> tb_Adv { get; set; }
        public DbSet<tb_Category> tb_Category { get; set; }
        public DbSet<tb_Contact> tb_Contact { get; set; }
        public DbSet<tb_News> tb_News { get; set; }
        public DbSet<tb_Order> tb_Order { get; set; }
        public DbSet<tb_OrderDetail> tb_OrderDetail { get; set; }
        public DbSet<tb_Posts> tb_Posts { get; set; }
        public DbSet<tb_Product> tb_Product { get; set; }
        public DbSet<tb_ProductCategory> tb_ProductCategory { get; set; }
        public DbSet<tb_ProductImage> tb_ProductImage { get; set; }
        public DbSet<tb_Subscribe> tb_Subscribe { get; set; }
        public DbSet<tb_SystemSetting> tb_SystemSetting { get; set; }
        public DbSet<ThongKe> ThongKes { get; set; }*/

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}