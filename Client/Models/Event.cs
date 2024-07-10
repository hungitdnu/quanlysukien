using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
	[Serializable]
	public class Event
	{
		public int ID { get; set; } = -1;
		public string tenSuKien { get; set; }
		public DateTime _thoiGian { get; set; }
		public string diaDiem { get; set; }
		public string moTa { get; set; }
		public Event(string tenSuKien, DateTime _thoiGian, string diaDiem, string moTa)
		{
			this.tenSuKien = tenSuKien;
			this._thoiGian = _thoiGian;
			this.diaDiem = diaDiem;
			this.moTa = moTa;
		}
		public Event() { }
		public override string ToString()
		{
			return this.tenSuKien ?? "Có lỗi xảy ra";
		}
	}
}
