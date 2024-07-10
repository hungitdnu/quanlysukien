using Server.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Server.Models;
using System.Text.Json;

namespace Server.Service
{
	internal class Service : IService
	{
		private Thread listenerThread;
		private TcpListener socket;
		private static Service service = new Service();
		private bool isStarted = false;
		private Service()
		{
		}
		public static Service GetInstance()
		{
			return service;
		}
		private T Deserialize<T>(object obj)
		{
			return JsonSerializer.Deserialize<T>((System.Text.Json.JsonElement)obj);
		}
		private void HandleClient(Client client)
		{
			bool isExit = false;
			while (!isExit)
			{
				try
				{
					string jsonString = client.reader.ReadLine();
					if(string.IsNullOrEmpty(jsonString))
					{
						Console.WriteLine("[Client disconnected]");
						isExit = true;
					}
					Message message = Message.FromJson(jsonString);
					Console.WriteLine("[RECEIVE SERVER] " + message.ToString());
					switch (message.messageCode)
					{
						case MessageCode.LOGIN:
							{
								User nguoiDung = Deserialize<User>(message.messageData);
								Message result = UserService.gI().Login(nguoiDung);
								nguoiDung = UserService.gI().GetUserExist(nguoiDung);
								if (nguoiDung != null)
								{
									client.nguoiDung = nguoiDung;
									client.nguoiDung.isOnline = true;
								}
								ClientService.gI().SendMessagePrivate(client, result);
								UserService.gI().Update();
								ClientService.gI().AddClient(client);
								break;
							}
						case MessageCode.LOGOUT:
							{
								Message msg = new Message();
								msg.messageCode = MessageCode.LOGOUT;
								msg.isSuccess = true;
								ClientService.gI().SendMessagePrivate(client, msg);
								if (client.nguoiDung != null)
								{
									client.nguoiDung.isOnline = false;
									client.nguoiDung = null;
								}
								UserService.gI().Update();
								break;
							}
							
						case MessageCode.REGISTER:
							{
								User nguoiDung = Deserialize<User>(message.messageData);
								Message result = UserService.gI().Register(nguoiDung);
								nguoiDung = UserService.gI().GetUserExist(nguoiDung);
								if (nguoiDung != null)
								{
									client.nguoiDung = nguoiDung;
								}
								ClientService.gI().SendMessagePrivate(client, result);
								break;
							}
						case MessageCode.CREATE_EVENT:
							{
								Event _event = Deserialize<Event>(message.messageData);
								_event.nguoiTao = client.nguoiDung;
								client.nguoiDung.suKienThamGia.Add(_event);
								ClientService.gI().SendMessagePrivate(client, EventService.gI().CreateEvent(_event));
								ClientService.gI().SendMessageGlobal(new Message()
								{
									messageCode = MessageCode.GET_EVENT,
									messageData = EventService.gI().events
								});
								break;
							}
						case MessageCode.GET_EVENT:
						{
							Message msg = new Message();
							msg.messageCode = MessageCode.GET_EVENT;
							msg.messageData = EventService.gI().events;
							ClientService.gI().SendMessagePrivate(client, msg);
							break;
						}
						case MessageCode.GET_INFO_EVENT:
						{
							int id = Deserialize<int>(message.messageData);
							Message msg = new Message();
							msg.messageCode = MessageCode.GET_INFO_EVENT;
							msg.messageData = EventService.gI().GetEventInfo(id);
							ClientService.gI().SendMessagePrivate(client, msg);
							break;
						}
						case MessageCode.GET_LIST_USER_JOIN:
						{
							int id = Deserialize<int>(message.messageData);
							Message msg = new Message();
							msg.messageCode = MessageCode.GET_LIST_USER_JOIN;
							msg.messageData = EventService.gI().GetListUserJoin(id);
							ClientService.gI().SendMessagePrivate(client, msg);
							break;
						}
						case MessageCode.GET_LIST_USER_INVITEABLE:
							{
								int id = Deserialize<int>(message.messageData);
								Message msg = new Message();
								msg.messageCode = MessageCode.GET_LIST_USER_INVITEABLE;
								msg.messageData = EventService.gI().GetListUserInviteable(id);
								ClientService.gI().SendMessagePrivate(client, msg);
								break;
							}
						case MessageCode.GET_LIST_INVITE:
							{
								Message msg = new Message();
								msg.messageCode = MessageCode.GET_LIST_INVITE;
								msg.messageData = client.nguoiDung != null ? EventService.gI().GetListInvite(client.nguoiDung) : new List<InviteEvent>();
								ClientService.gI().SendMessagePrivate(client, msg);
								break;
							}
						case MessageCode.REQUEST_JOIN:
							{
								int idEvent = Deserialize<int>(message.messageData);
								Event e = EventService.gI().GetEventInfo(idEvent);
								Message msg = new Message();
								msg.messageCode = MessageCode.REQUEST_JOIN;
								if (e.GetUserJoined().Contains(client?.nguoiDung))
								{
									msg.isSuccess = false;
									msg.messageData = "Bạn đã tham gia event này rồi !";
								}
								else if(EventService.gI().GetRequests().Any(m => m.nguoiYeuCau == client.nguoiDung && m.suKien == e))
								{
									msg.isSuccess = false;
									msg.messageData = "Yêu cầu tham gia đã được gửi rồi !";
								}
								else
								{
									RequestEvent request = new RequestEvent();
									request.nguoiYeuCau = client.nguoiDung;
									request.suKien = e;
									EventService.gI().AddRequest(request);
									msg.isSuccess = true;
									msg.messageData = "Yêu cầu tham gia đã được gửi";
								}
								ClientService.gI().SendMessagePrivate(client, msg);
								break;
							}
						case MessageCode.IS_OWNER:
							{
								int idEvent = Deserialize<int>(message.messageData);
								Event e = EventService.gI().GetEventInfo(idEvent);
								Message msg = new Message();
								msg.messageCode = MessageCode.IS_OWNER;
								msg.isSuccess = e.nguoiTao == client.nguoiDung;
								ClientService.gI().SendMessagePrivate(client, msg);
								break;
							}
						case MessageCode.INVITE_USER:
							{
								InviteEvent invite = Deserialize<InviteEvent>(message.messageData);
								Message msg = new Message();
								msg.messageCode = MessageCode.INVITE_USER;
								Event e = EventService.gI().GetEventInfo(invite.suKien.ID);
								User nguoiNhan = UserService.gI().GetUserByUsername(invite.nguoiNhan.userName);
								if (e.GetUserJoined().Contains(nguoiNhan))
								{
									msg.isSuccess = false;
									msg.messageData = "Người dùng đã tham gia event này rồi !";
								}
								else if (EventService.gI().GetInvites().Any(m => m.nguoiNhan == nguoiNhan && m.suKien == e))
								{
									msg.isSuccess = false;
									msg.messageData = "Người dùng đã được mời rồi !";
								}
								else
								{
									invite.nguoiNhan = nguoiNhan;
									invite.suKien = e;
									invite.nguoiMoi = client.nguoiDung;
									EventService.gI().AddInvite(invite);
									msg.isSuccess = true;
									msg.messageData = "Mời thành công";
									ClientService.gI().SendMessagePrivate(ClientService.gI().GetClientByUserName(nguoiNhan.userName), new Message()
									{
										messageCode = MessageCode.NEW_INVITE,
										messageData = invite
									});
								}
								ClientService.gI().SendMessagePrivate(client, msg);
								break;
							}
						case MessageCode.GET_LIST_USER_PENDING:
							{
								int idEvent = Deserialize<int>(message.messageData);
								Event e = EventService.gI().GetEventInfo(idEvent);
								Message msg = new Message();
								msg.messageCode = MessageCode.GET_LIST_USER_PENDING;
								msg.messageData = client.nguoiDung != null && client.nguoiDung ==  e.nguoiTao ?
									EventService.gI().GetRequests().Where(m => m.suKien.nguoiTao == client.nguoiDung).Select(m => m.nguoiYeuCau).ToList():
									new List<User>();
								ClientService.gI().SendMessagePrivate(client, msg);
								break;
							}
						case MessageCode.ACCEPT_REQUEST:
							{
								bool isAccept = message.isSuccess;
								string[] data = Deserialize<string[]>(message.messageData);
								int idEvent = int.Parse(data[0]);
								string username = data[1];

								Event e = EventService.gI().GetEventInfo(idEvent);
								User user = UserService.gI().GetUserByUsername(username);
								bool isJoined = e.GetUserJoined().Contains(user);
								bool isHasRequested = EventService.gI().GetRequests().Any(m => m.nguoiYeuCau == user && m.suKien == e);
								if (!isJoined && isHasRequested)
								{
									EventService.gI().GetRequests().RemoveAll(m => m.nguoiYeuCau == user && m.suKien == e);
									if(isAccept)
									{
										e.AddUserJoined(user);
										ClientService.gI().SendMessageForUserEvent(new Message()
										{
											messageCode = MessageCode.GET_LIST_USER_JOIN,
											messageData = EventService.gI().GetListUserJoin(e.ID)
										}, e);
										ClientService.gI().SendMessagePrivate(ClientService.gI().GetClientByUserName(user.userName), new Message()
										{
											messageCode = MessageCode.ACCEPT_REQUEST,
											isSuccess = true
										});
									}
								}
								break;
							}
						case MessageCode.ACCEPT_INVITE:
							{
								bool isAccept = message.isSuccess;
								int idEvent = Deserialize<int>(message.messageData);
								Event e = EventService.gI().GetEventInfo(idEvent);
								InviteEvent invite = EventService.gI().GetInvites().FirstOrDefault(m => m.nguoiNhan == client.nguoiDung && m.suKien == e);
								if (invite != null)
								{
									EventService.gI().RemoveInvite(invite);
									if (isAccept)
									{
										e.AddUserJoined(client.nguoiDung);
										ClientService.gI().SendMessageForUserEvent(new Message()
										{
											messageCode = MessageCode.GET_LIST_USER_JOIN,
											messageData = EventService.gI().GetListUserJoin(e.ID)
										}, e);
									}
								}
								break;
							}
						case MessageCode.NEW_INVITE:
							{
								bool hasNewInvite = EventService.gI().GetInvites().Any(m => m.nguoiNhan == client.nguoiDung);
								Message msg = new Message();
								msg.messageCode = MessageCode.NEW_INVITE;
								msg.isSuccess = hasNewInvite;
								ClientService.gI().SendMessagePrivate(client, msg);
								break;
							}
						default:
							break;
					}
				}
				catch(Exception e)
				{
					if(client.nguoiDung != null)
					{
						client.nguoiDung.isOnline = false;
						client.nguoiDung = null;
					}
					Console.WriteLine("Handle Client: " + e.ToString());
					client.writer.Close();
					client.reader.Close();
					client.socket.Close();
					ClientService.gI().RemoveClient(client);
					isExit = true;
				}
				finally
				{
					
				}
			}
		}
		private void HandleConnection()
		{
			while (isStarted)
			{
				try
				{
					TcpClient clientSocket = socket.AcceptTcpClient();
					new Thread(() =>
					{
						HandleClient(new Client(clientSocket));
					}).Start();
					Console.WriteLine("[NEW CLIENT CONNECTED]");
				}
				catch
				{
					continue;
				}
			}
		}
		
		private bool Connect()
		{
			socket = new TcpListener(IPAddress.Parse(Connection.SERVER_IP), Connection.SERVER_PORT);
			try
			{
				socket.Start();
				Console.WriteLine("Server Socket started in {0}:{1}", Connection.SERVER_IP, Connection.SERVER_PORT);
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine("[StartSocket Exception]: " + e.ToString());
				return false;
			}

		}
		public void Start()
		{
			UserService.gI().Start();
			EventService.gI().Start();
			ClientService.gI().Start();
			isStarted = this.Connect();
			if (isStarted)
				try
				{
					listenerThread = new Thread(() =>
					{
						HandleConnection();
					});
					listenerThread.Start();
					
				}
				catch
				{

				}
		}
		public void Stop()
		{
			isStarted = false;
			if(socket != null)
				socket.Stop();
			UserService.gI().Stop();
			EventService.gI().Stop();
			ClientService.gI().Stop();
			Console.WriteLine("STOPPED");
		}
		public void Update()
		{

		}
	}
}
