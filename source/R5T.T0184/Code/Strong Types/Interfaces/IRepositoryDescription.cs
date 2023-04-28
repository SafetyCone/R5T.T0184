using System;

using R5T.T0178;
using R5T.T0185;


namespace R5T.T0184
{
    /// <summary>
    /// Strongly-types a string as a repository description.
    /// </summary>
    [StrongTypeMarker]
    public interface IRepositoryDescription : IStrongTypeMarker,
        IDescription
    {
    }
}
