namespace GraphQL.DI
{
    /// <summary>
    /// This is a required base type of all DI-created graph types. <see cref="DIObjectGraphBase"/> may be
    /// used if the <see cref="IResolveFieldContext.Source"/> type is <see cref="object"/>.
    /// </summary>
    //this class is a placeholder for future support of properties or methods on the base class
    public class DIObjectGraphBase<TSource>
    {
        //this would be an ideal spot to put public readonly fields for the resolving query, such as Schema, Metrics, Executor, and so on, rather than being inside the ResolveFieldContext instance.
        //this could only contain fields that are not unique to a resolving field (such as Source), so as to not break multithreading support
        //with DI, any objects necessary could be brought in via dependency injection (such as Schema), so they really don't need to be in here
    }

    /// <summary>
    /// This is a required base type of all DI-created graph types. <see cref="DIObjectGraphBase{TSource}"/> may be
    /// used when the <see cref="IResolveFieldContext.Source"/> type is not <see cref="object"/>.
    /// </summary>
    public class DIObjectGraphBase : DIObjectGraphBase<object>
    {
    }
}
