using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Digivance.Core
{
    /// <summary>
    /// Some string helper methods wrapped into handy extensions
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Tells us if the provided string contains any numeric characters
        /// </summary>
        /// <param name="value">The string we are evaluating</param>
        /// <returns>True if one of more characters are numeric</returns>
        public static bool ContainsNumeric(this string value) => Regex.IsMatch(value, "\\d");

        /// <summary>
        /// Tells us if the provided string contains a standard us keyboard symbol
        /// </summary>
        /// <param name="value">The string we are evaluating</param>
        /// <returns>True if one or more characters are symbols</returns>
        public static bool ContainsSymbol(this string value) => value.Any(x => "~`!@#$%^&*()_+=-\\][{}|';:\"/.,<>?".Contains(x));

        /// <summary>
        /// Tells us if the provided string contains Uppercase character
        /// </summary>
        /// <param name="value">The string we are evaluating</param>
        /// <returns>True if one or more characters are uppercase</returns>
        public static bool ContainsUpper(this string value) => value.Any(char.IsUpper);

        /// <summary>
        /// Tells us if the provided string contains Lowercase character
        /// </summary>
        /// <param name="value">The string we are evaluating</param>
        /// <returns>True if one or more characters are lowercase</returns>
        public static bool ContainsLower(this string value) => value.Any(char.IsLower);

        /// <summary>
        /// A helper that validates the provided string as an email address by 
        /// attempting to construct a MailAddress object from it
        /// </summary>
        /// <param name="value">The string to validate as an email address</param>
        /// <returns>True if we are able to construct a MailAddress from the provided value</returns>
        public static bool IsEmailAddress(this string value)
        {
            try
            {
                var addr = new MailAddress(value);
                return addr.Address == value;
            }
            catch
            {
                return false;
            }
        }
    }
}
