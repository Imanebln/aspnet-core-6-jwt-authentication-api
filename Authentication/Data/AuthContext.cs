using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Data
{
    public class AuthContext : IdentityDbContext<ApplicationUser>
    {
        public AuthContext(DbContextOptions<AuthContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
