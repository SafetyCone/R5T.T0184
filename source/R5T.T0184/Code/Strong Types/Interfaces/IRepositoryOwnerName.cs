using System;

using R5T.T0178;
using R5T.T0185;


namespace R5T.T0184
{
    /// <summary>
    /// Strongly-types a string as the name of a repository owner.
    /// </summary>
    [StrongTypeMarker]
    public interface IRepositoryOwnerName : IStrongTypeMarker,
        IName
    {
    }
}
