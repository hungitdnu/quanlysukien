using Server.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
	[Serializable]
	public class Event
	{
		[NonSerialized]
		private static int _id = 0;
		public int ID { get; set; }
		public string tenSuKien { get; set; }
		public DateTime _thoiGian { get; set; }
		public string diaDiem { get; set; }
		public string moTa { get; set; }
		[NonSerialized]
		public User nguoiTao;
		[NonSerialized]
		private List<User> nguoiThamGia = new List<User>();

		public void setID()
		{
			_id = EventService.gI().events.Count > 0 ?  EventService.gI().events.Max(m => m.ID) + 1 : 0;
			this.ID = _id++;
		}

		public List<User> GetUserJoined()
		{
			return nguoiThamGia;
		}
		public void AddUserJoined(User user)
		{
			nguoiThamGia.Add(user);
			SqlService.gI().ExecuteQuery($"INSERT INTO ThamGiaSuKien VALUES ({this.ID}, N'{user.userName}')");
		}
		public void AddUserNoSql(User user)
		{
			nguoiThamGia.Add(user);
		}
	}
}
