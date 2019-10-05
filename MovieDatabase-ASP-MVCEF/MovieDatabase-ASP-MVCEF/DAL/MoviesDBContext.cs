using MovieDatabase_ASP_MVCEF.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.DAL
{
    public class MoviesDBContext : IdentityDbContext
    {

        public MoviesDBContext() : base("DefaultConnection")
        {
        }

        //public DbSet<Movie> Movies { get; set; }

    }
}
