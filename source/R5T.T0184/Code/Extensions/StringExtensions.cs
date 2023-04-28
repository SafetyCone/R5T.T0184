using System;


namespace R5T.T0184.Extensions
{
    public static class StringExtensions
    {
        public static IRepositoryDescription ToRepositoryDescription(this string value)
        {
            return Instances.StringOperator_Extensions.ToRepositoryDescription(value);
        }

        public static IRepositoryOwnerName ToRepositoryOwnerName(this string value)
        {
            return Instances.StringOperator_Extensions.ToRepositoryOwnerName(value);
        }

        public static IRepositoryName ToRepositoryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToRepositoryName(value);
        }
    }
}
