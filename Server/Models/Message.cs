using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.Json;

namespace Server.Models
{
	[Serializable]
	internal class Message
	{
		public byte messageCode { get; set; }
		public object messageData { get; set; }
		public bool isSuccess { get; set; } = true;
		public Message(byte messageCode, object messageData)
		{
			this.messageCode = messageCode;
			this.messageData = messageData;
		}
		public Message() { }
		public static Message FromJson(string jsonString)
		{
			return JsonSerializer.Deserialize<Message>(jsonString); ;
		}
		public override string ToString()
		{
			return $"ID={messageCode},SUCCESS={isSuccess}, OBJ={messageData?.ToString()}";
		}
	}
}
