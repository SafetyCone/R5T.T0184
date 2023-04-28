using System;

using R5T.T0132;


namespace R5T.T0184.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IRepositoryDescription ToRepositoryDescription(string value)
        {
            var output = new RepositoryDescription(value);
            return output;
        }

        public IRepositoryOwnerName ToRepositoryOwnerName(string value)
        {
            var output = new RepositoryOwnerName(value);
            return output;
        }

        public IRepositoryName ToRepositoryName(string value)
        {
            var output = new RepositoryName(value);
            return output;
        }
    }
}
