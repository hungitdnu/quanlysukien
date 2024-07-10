using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Const
{
	internal class MessageCode
	{
		public const byte LOGIN = 0;
		public const byte LOGOUT = 1;
		public const byte REGISTER = 2;

		public const byte CREATE_EVENT = 3;
		public const byte GET_EVENT = 5;
		public const byte GET_INFO_EVENT = 7;
		public const byte GET_LIST_USER_JOIN = 9;
		public const byte GET_LIST_USER_INVITEABLE = 10;
		public const byte GET_LIST_USER_PENDING = 15;
		public const byte IS_OWNER = 14;

		public const byte INVITE_USER = 8;
		public const byte ACCEPT_INVITE = 12;
		public const byte NEW_INVITE = 6;
		public const byte GET_LIST_INVITE = 11;
		public const byte REQUEST_JOIN = 13;
		public const byte ACCEPT_REQUEST = 16;
	}
}
