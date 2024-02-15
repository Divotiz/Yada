namespace Yada.Business.Services;

public partial class SampleService : BaseCrudService<Sample, int, ISampleRepository>, ISampleService
{
    public SampleService(ISampleRepository repository) : base(repository)
    {
    }
}
