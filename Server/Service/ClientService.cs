using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Service
{
	internal class ClientService : IService
	{
		private List<Models.Client> clients = new List<Models.Client>();
		private ClientService() { }
		private static ClientService instance;
		public static ClientService gI()
		{
			if (instance == null)
			{
				instance = new ClientService();
			}
			return instance;
		}
		public void Start()
		{
			clients = new List<Models.Client>();
			
		}

		public void Stop()
		{
			clients.Clear();
		}
		public Models.Client GetClientByUserName(string userName)
		{
			foreach (Models.Client client in clients)
			{
				if (client.nguoiDung != null && client.nguoiDung.userName.Equals(userName))
				{
					return client;
				}
			}
			return null;
		}
		public void AddClient(Models.Client client)
		{
			clients.Add(client);
		}
		public void RemoveClient(Models.Client client)
		{
			clients.Remove(client);
		}
		public void SendMessagePrivate(Models.Client client, Models.Message message)
		{
			if (client == null) return;
			string jsonString = System.Text.Json.JsonSerializer.Serialize(message);
			if(client.writer != null)
				client.writer.WriteLine(jsonString);
		}
		public void SendMessageGlobal(Models.Message message)
		{
			string jsonString = System.Text.Json.JsonSerializer.Serialize(message);
			foreach (Models.Client client in clients)
			{
				if(client != null && client.nguoiDung != null && client.writer != null)
					client.writer.WriteLine(jsonString);
			}
		}
		public void SendMessageForUserEvent(Models.Message message, Models.Event e)
		{
			string jsonString = System.Text.Json.JsonSerializer.Serialize(message);
			foreach (Models.Client client in clients)
			{
				if (client != null && client.writer != null 
					&& client.nguoiDung != null 
					&& e.GetUserJoined().Contains(client.nguoiDung) 
					)
				{
					client.writer.WriteLine(jsonString);
				}
			}
		}
		public void Update()
		{

		}
	}
}
