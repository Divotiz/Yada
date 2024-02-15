namespace Yada.Core;

/// <summary>
/// The base entity
/// </summary>
/// <typeparam name="TId">The type of the identifier.</typeparam>
/// <typeparam name="T">The type of entity</typeparam>
public abstract class BaseEntity<T, TId> : BaseEntity<TId> where T : BaseEntity<T, TId>
{
    /// <summary>
    /// The display name exp
    /// </summary>
    private Func<T, IComparable> _displayNameExp;

    /// <summary>
    /// Gets the display name.
    /// </summary>
    /// <value>
    /// The display name.
    /// </value>
    public string DisplayName
    {
        get
        {
            if (_displayNameExp == null)
            {
                _displayNameExp = GetDisplayNameExpression().Compile();
            }

            return (string)_displayNameExp((T)this);
        }
    }

    /// <summary>
    /// Gets the display name expression.
    /// </summary>
    /// <returns></returns>
    public abstract Expression<Func<T, IComparable>> GetDisplayNameExpression();

    /// <summary>
    /// Gets the order by expression.
    /// </summary>
    /// <returns>The order by expression.</returns>
    public virtual Expression<Func<T, IComparable>> GetOrderByExpression() => GetDisplayNameExpression();

    /// <summary>
    /// Gets the text filter expression.
    /// </summary>
    /// <returns>The text filter expression.</returns>
    public virtual Expression<Func<T, IComparable>> GetTextFilterExpression() => GetDisplayNameExpression();
}

/// <summary>
/// The base entity
/// </summary>
/// <typeparam name="TId">The type of the identifier.</typeparam>
public abstract class BaseEntity<TId>
{
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public virtual TId Id { get; set; }
}
