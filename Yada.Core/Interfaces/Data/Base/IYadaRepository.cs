namespace Yada.Core.Interfaces.Data.Base;
public interface IYadaRepository<T, TId> : ICrudRepository<T, TId> where T : IEntity<T, TId>
{
}

