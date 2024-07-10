using Client.Const;
using Client.Models;
using Client.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Service
{
	internal class Action
	{
		public static void Login(string userName, string passWord)
		{
			Message message = new Message();
			message.messageCode = MessageCode.LOGIN;
			message.messageData = new User() { userName = userName, passWord = passWord };
			Community.GetInstance().SendMessage(message);
		}
		public static void Register(string userName, string passWord, string fullName)
		{
			Message message = new Message();
			message.messageCode = MessageCode.REGISTER;
			message.messageData = new User() { userName = userName, passWord = passWord, fullName = fullName };
			Community.GetInstance().SendMessage(message);
		}
		public static void Logout()
		{
			Message message = new Message();
			message.messageCode = MessageCode.LOGOUT;
			Community.GetInstance().SendMessage(message);
		}
		public static void CreateEvent(Event _event)
		{
			Message message = new Message();
			message.messageCode = MessageCode.CREATE_EVENT;
			message.messageData = _event;
			Community.GetInstance().SendMessage(message);
		}
		public static void GetEvents()
		{
			Message message = new Message();
			message.messageCode = MessageCode.GET_EVENT;
			Community.GetInstance().SendMessage(message);
		}
		public static void CheckInvite()
		{
			Message message = new Message();
			message.messageCode = MessageCode.NEW_INVITE;
			Community.GetInstance().SendMessage(message);
		}
		public static void GetInfoEvent(int idEvent)
		{
			Message message = new Message();
			message.messageCode = MessageCode.GET_INFO_EVENT;
			message.messageData = idEvent;
			Community.GetInstance().SendMessage(message);
		}
		public static void GetListUser(int idEvent)
		{
			Message message = new Message();
			message.messageCode = MessageCode.GET_LIST_USER_JOIN;
			message.messageData = idEvent;
			Community.GetInstance().SendMessage(message);
		}
		public static void GetListUserInviteable(int idEvent)
		{
			Message message = new Message();
			message.messageCode = MessageCode.GET_LIST_USER_INVITEABLE;
			message.messageData = idEvent;
			Community.GetInstance().SendMessage(message);
		}
		public static void GetListInviteForMe()
		{
			Message message = new Message();
			message.messageCode = MessageCode.GET_LIST_INVITE;
			Community.GetInstance().SendMessage(message);
		}
		public static void InviteUser(int idEvent, string userName)
		{
			Message message = new Message();
			message.messageCode = MessageCode.INVITE_USER;
			message.messageData = new InviteEvent() {
				suKien = new Event() { ID = idEvent },
				nguoiNhan = new User() { userName = userName }
			};
			Community.GetInstance().SendMessage(message);
		}
		public static void GetListUserPending(int idEvent)
		{
			Message message = new Message();
			message.messageCode = MessageCode.GET_LIST_USER_PENDING;
			message.messageData = idEvent;
			Community.GetInstance().SendMessage(message);
		}
		public static void AcceptInvite(int idEvent, bool isAccept)
		{
			Message message = new Message();
			message.messageCode = MessageCode.ACCEPT_INVITE;
			message.isSuccess = isAccept;
			message.messageData = idEvent;
			Community.GetInstance().SendMessage(message);
		}
		public static void RequestJoinEvent(int idEvent)
		{
			Message message = new Message();
			message.messageCode = MessageCode.REQUEST_JOIN;
			message.messageData = idEvent;
			Community.GetInstance().SendMessage(message);
		}
		public static void IsOwner(int idEvent)
		{
			Message message = new Message();
			message.messageCode = MessageCode.IS_OWNER;
			message.messageData = idEvent;
			Community.GetInstance().SendMessage(message);
		}
		public static void AcceptJoinEvent(int idEvent, string username, bool isAccept)
		{
			Message message = new Message();
			message.messageCode = MessageCode.ACCEPT_REQUEST;
			message.isSuccess = isAccept;
			message.messageData = new string[2] {idEvent.ToString(), username};
			Community.GetInstance().SendMessage(message);
		}
	}
}
