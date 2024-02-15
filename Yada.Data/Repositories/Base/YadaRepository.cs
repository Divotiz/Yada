
namespace Yada.Data.Repositories.Base;

/// <summary>
/// CrudRepository
/// </summary>
/// <typeparam name="T"></typeparam>
/// <typeparam name="TId">The type of the identifier.</typeparam>
public class YadaRepository<T, TId> : CrudRepository<T, TId, YadaContext>, IYadaRepository<T, TId> where T : class, IEntity<T, TId>
{
    public YadaRepository(ILogger<YadaRepository<T, TId>> _logger, YadaContext context) : base(_logger, context)
    {
    }
}
