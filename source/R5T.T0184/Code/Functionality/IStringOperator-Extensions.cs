using System;

using R5T.T0132;


namespace R5T.T0184.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IRepositoryDescription"/>
        public IRepositoryDescription ToRepositoryDescription(string value)
        {
            var output = new RepositoryDescription(value);
            return output;
        }

        /// <inheritdoc cref="IRepositoryOwnerName"/>
        public IRepositoryOwnerName ToRepositoryOwnerName(string value)
        {
            var output = new RepositoryOwnerName(value);
            return output;
        }

        /// <inheritdoc cref="IRepositoryName"/>
        public IRepositoryName ToRepositoryName(string value)
        {
            var output = new RepositoryName(value);
            return output;
        }

        /// <inheritdoc cref="IUnadjustedRepositoryName"/>
        public IUnadjustedRepositoryName ToUnadjustedRepositoryName(string value)
        {
            var output = new UnadjustedRepositoryName(value);
            return output;
        }
    }
}
