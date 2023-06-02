using System;


namespace R5T.T0184.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToRepositoryDescription(string)"/>
        public static IRepositoryDescription ToRepositoryDescription(this string value)
        {
            return Instances.StringOperator_Extensions.ToRepositoryDescription(value);
        }

        /// <inheritdoc cref="IStringOperator.ToRepositoryOwnerName(string)"/>
        public static IRepositoryOwnerName ToRepositoryOwnerName(this string value)
        {
            return Instances.StringOperator_Extensions.ToRepositoryOwnerName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToRepositoryName(string)"/>
        public static IRepositoryName ToRepositoryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToRepositoryName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToUnadjustedRepositoryName(string)"/>
        public static IUnadjustedRepositoryName ToUnadjustedRepositoryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToUnadjustedRepositoryName(value);
        }
    }
}
