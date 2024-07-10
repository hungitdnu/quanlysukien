using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Utils
{
	internal class Validate
	{
		public static bool ValidateByRegex(string input, string pattern)
		{
			return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
		}
		public static bool ValidateByLength(string input, int min, int max)
		{
			return input.Length >= min && input.Length <= max;
		}
		public static bool IsValidUsername(string username)
		{
			return ValidateByRegex(username, @"^[a-zA-Z0-9_]{6,32}$");
		}
		public static bool IsValidPassword(string password)
		{
			return ValidateByLength(password, 6, 32) && !password.Contains(" ");
		}
	}
}
