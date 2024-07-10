using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
	[Serializable]
	internal class InviteEvent
	{
		public Event suKien { get; set; }
		public User nguoiMoi { get; set; }
		public User nguoiNhan { get; set; }
	}
}
