using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Const
{
	public class MessageCode
	{
		public const byte LOGIN = 0;//done
		public const byte LOGOUT = 1;//done
		public const byte REGISTER = 2;//done

		public const byte CREATE_EVENT = 3;//done
		public const byte GET_EVENT = 5;//done
		public const byte GET_INFO_EVENT = 7;//done
		public const byte GET_LIST_USER_JOIN = 9;//done
		public const byte GET_LIST_USER_INVITEABLE = 10;//done
		public const byte GET_LIST_USER_PENDING = 15;//done
		public const byte IS_OWNER = 14;//done

		public const byte INVITE_USER = 8;//done
		public const byte ACCEPT_INVITE = 12; // done - ko response
		public const byte NEW_INVITE = 6; //done
		public const byte GET_LIST_INVITE = 11;//done
		public const byte REQUEST_JOIN = 13; //done
		public const byte ACCEPT_REQUEST = 16; //done - ko response
	}
}
