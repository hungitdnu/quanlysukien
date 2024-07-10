using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
	[Serializable]
	public class Message
	{
		public byte messageCode { get; set; }
		public object messageData { get; set; }
		public bool isSuccess { get; set; } = true;
		public override string ToString()
		{
			return $"MessageCode: {messageCode},Success: {isSuccess}, MessageData: {messageData}";
		}
	}
}
