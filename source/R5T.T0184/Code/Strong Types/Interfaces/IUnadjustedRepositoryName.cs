using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0184
{
    /// <summary>
    /// Strongly-types a string as an unadjused repository name.
    /// </summary>
    /// <remarks>
    /// Repository names (<see cref="IRepositoryName"/>) can be adjusted for many reasons, the cheff reason being whether the repository is private or not.
    /// </remarks>
    [StrongTypeMarker]
    public interface IUnadjustedRepositoryName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}