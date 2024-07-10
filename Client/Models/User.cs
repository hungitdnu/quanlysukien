using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
	[Serializable]
	public class User
	{
		public string fullName { get; set; }
		public string userName { get; set; }
		public string passWord { get; set; }
		public bool isOnline { get; set; }
		public override string ToString()
		{
			return fullName ?? "Có lỗi xảy ra";
		}
	}
}
