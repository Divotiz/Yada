using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Yada.Core.Constants;

namespace Yada.Data.Context;

public partial class YadaContext : DbContext
{
    private readonly IConfiguration _configuration;

    public YadaContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public YadaContext(DbContextOptions<YadaContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_configuration[ConfigurationConstants.DefaultConnectionStringName]);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
