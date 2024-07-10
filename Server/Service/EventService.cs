using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Service
{
	internal class EventService : IService
	{
		public List<Event> events;
		private List<InviteEvent> invites;
		private List<RequestEvent> requests;
		public List<string> queries = new List<string>();
		public event Action<List<Event>> EventUpdate;
		private static EventService instance;
		private EventService() { }
		public static EventService gI()
		{
			if (instance == null)
			{
				instance = new EventService();
			}
			return instance;
		}
		public void Start()
		{
			events = SqlService.gI().GetEvents();
			invites = SqlService.gI().GetInvites();
			requests = SqlService.gI().GetRequests();
			SqlService.gI().GetJoinEvent();
			Update();
		}

		public void Stop()
		{
			events?.Clear();
			invites?.Clear();
			requests?.Clear();
			Update();
		}
		public void Update()
		{
			foreach(var query in queries)
			{
				SqlService.gI().ExecuteQuery(query);
			}
			queries.Clear();
			EventUpdate?.Invoke(events);
		}

		public Message CreateEvent(Event e)
		{
			Message message = new Message();
			message.messageCode = Const.MessageCode.CREATE_EVENT;
			e.setID();
			e.AddUserJoined(e.nguoiTao);
			events.Add(e);
			string query = $"INSERT INTO SuKien VALUES ({e.ID}, N'{e.tenSuKien}', N'{e._thoiGian.ToString()}', N'{e.diaDiem}', N'{e.moTa}', N'{e.nguoiTao.userName}')";
			queries.Add(query);
			Update();
			return message;
		}
		public Event GetEventInfo(int id)
		{
			return events.FirstOrDefault(ev => ev.ID == id);
		}
		public List<User> GetListUserJoin(int id)
		{
			return events.FirstOrDefault(ev => ev.ID == id).GetUserJoined() ?? new List<User>();
		}
		public List<User> GetListUserInviteable(int idSuKien)
		{
			return UserService.gI().users.Except(events.FirstOrDefault(ev => ev.ID == idSuKien).GetUserJoined()).Select(m => m.clone()).ToList();
		}
		public List<InviteEvent> GetListInvite(User user)
		{
			return invites.Where(m => m.nguoiNhan == user).ToList();
		}
		public List<InviteEvent> GetInvites()
		{
			return invites;
		}
		public void AddInvite(InviteEvent invite)
		{
			invites.Add(invite);
			queries.Add($"INSERT INTO LoiMoiSuKien VALUES (N'{invite?.nguoiMoi?.userName}', N'{invite?.nguoiNhan?.userName}', {invite.suKien.ID})");
			Update();
		}
		public void RemoveInvite(InviteEvent invite)
		{
			invites.Remove(invite);
			queries.Add($"DELETE FROM LoiMoiSuKien WHERE UsernameNguoiMoi = N'{invite?.nguoiMoi?.userName}' AND UsernameNguoiNhan = N'{invite?.nguoiNhan?.userName}' AND IdSuKien = {invite.suKien.ID}");
			Update();
		}
		public List<RequestEvent> GetRequests()
		{
			return requests;
		}
		public void AddRequest(RequestEvent request)
		{
			requests.Add(request);
			queries.Add($"INSERT INTO YeuCauSuKien VALUES ({request.suKien.ID}, N'{request?.nguoiYeuCau?.userName}')");
			Update();
		}
		public void RemoveRequest(RequestEvent request)
		{
			requests.Remove(request);
			queries.Add($"DELETE FROM YeuCauSuKien WHERE IdSuKien = {request.suKien.ID} AND UsernameYeuCau = N'{request?.nguoiYeuCau?.userName}'");
			Update();
		}
	}
}
