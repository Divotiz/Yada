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
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Yada;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }

    public virtual DbSet<Sample> Sample { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
