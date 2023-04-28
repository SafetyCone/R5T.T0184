using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0184
{
    /// <inheritdoc cref="IRepositoryOwnerName"/>
    [StrongTypeImplementationMarker]
    public class RepositoryOwnerName : TypedBase<string>, IStrongTypeMarker,
        IRepositoryOwnerName
    {
        public RepositoryOwnerName(string value)
            : base(value)
        {
        }
    }
}
