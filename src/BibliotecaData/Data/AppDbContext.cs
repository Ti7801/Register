using BibliotecaBusiness.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaData.Data
{
    public class AppDbContext : IdentityDbContext<Usuario, IdentityRole<Guid>, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole<Guid>>().ToTable("Roles");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("UsuariosRoles");
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("UsuariosClaims");
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("UsuariosLogins");
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RolesClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("UsuariosTokens");
        }
    }
}
