using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0184
{
    /// <inheritdoc cref="IRepositoryDescription"/>
    [StrongTypeImplementationMarker]
    public class RepositoryDescription : TypedBase<string>, IStrongTypeMarker,
        IRepositoryDescription
    {
        public RepositoryDescription(string value)
            : base(value)
        {
        }
    }
}
