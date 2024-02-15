namespace Yada.Core.Entities;

public class Sample : BaseEntity<Sample, int>, IEntity<Sample, int>
{
    public Sample()
    {
    }

    //public override int Id { get; set; }
    public string Name { get; set; }

    public override Expression<Func<Sample, IComparable>> GetDisplayNameExpression()
    {
        return x => x.Name;
    }
}
