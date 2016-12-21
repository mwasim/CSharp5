using System.Text.RegularExpressions;

namespace CSharp.LinqQueries
{
    public static class ExtensionMethods
    {
        public static bool IsValidEmail(this string email)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

            return regex.IsMatch(email);
        }
    }
}
