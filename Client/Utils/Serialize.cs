using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Utils
{
	internal class Serialize
	{
		public static T Deserialize<T>(object obj)
		{
			return System.Text.Json.JsonSerializer.Deserialize<T>((System.Text.Json.JsonElement)obj);
		}
	}
}
