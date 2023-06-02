using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0184
{
    /// <inheritdoc cref="IUnadjustedRepositoryName"/>
    [StrongTypeImplementationMarker]
    public class UnadjustedRepositoryName : TypedBase<string>, IStrongTypeMarker,
        IUnadjustedRepositoryName
    {
        public UnadjustedRepositoryName(string value)
            : base(value)
        {
        }
    }
}