using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
	internal class RequestEvent
	{
		public Event suKien { get; set; }
		public User nguoiYeuCau { get; set; }
	}
}
