namespace Yada.Data.Repositories;

public partial class SampleRepository : YadaRepository<Sample, int>, ISampleRepository
{
    public SampleRepository(IConfiguration configuration, ILogger<SampleRepository> logger, YadaContext context) : base(logger, context)
    {
    }
}
