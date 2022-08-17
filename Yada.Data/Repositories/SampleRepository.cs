namespace Yada.Data.Repositories;

public partial class SampleRepository : ISampleRepository
{
    private readonly YadaContext _context;

    public SampleRepository(IConfiguration configuration, ILogger<SampleRepository> logger, YadaContext context)
    {
        _context = context;
    }
}
