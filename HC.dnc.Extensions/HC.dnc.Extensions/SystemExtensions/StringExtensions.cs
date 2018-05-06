namespace DNC.Extensions
{
    public static class StringExtensions
    {   
        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space
        /// characters.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>true if the value parameter is null or System.String.Empty, or if value consists. exclusively of white-space characters.</returns>
        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);
    }
}
