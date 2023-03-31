using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using Landpag2.Models.Authenticationconn;

namespace Landpag2.Data
{
  public partial class AuthenticationconnContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public AuthenticationconnContext(DbContextOptions<AuthenticationconnContext> options):base(options)
    {
    }

    public AuthenticationconnContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);



        builder.Entity<Landpag2.Models.Authenticationconn.SoftwareModulescatlist>()
              .Property(p => p.sprModulecatid)
              .HasPrecision(19, 0);

        builder.Entity<Landpag2.Models.Authenticationconn.SoftwareModulescatlist>()
              .Property(p => p.InstallcatModule)
              .HasPrecision(19, 4);
        this.OnModelBuilding(builder);
    }


    public DbSet<Landpag2.Models.Authenticationconn.SoftwareModulescatlist> SoftwareModulescatlists
    {
      get;
      set;
    }
  }
}
