using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Server.Models
{
	[Serializable]
	public class User
	{
		public string fullName { get; set; }
		public string userName { get; set; }
		public bool isOnline { get; set; } = false;
		public string passWord { get; set; }
		[NonSerialized]
		public List<Event> suKienThamGia = new List<Event>();
		public User clone()
		{
			User user = new User();
			user.fullName = this.fullName;
			user.userName = this.userName;
			user.passWord = "";
			user.isOnline = this.isOnline;
			return user;
		}
	}
}
