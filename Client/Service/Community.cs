using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Client.Const;
using Client.Models;
using Client.Utils;

namespace Client.Service
{
	internal class Community
	{
		private Thread listenerThread;
		private TcpClient socket;
		private StreamReader streamReader;
		private StreamWriter streamWriter;
		private static Community service = new Community();
		//Data reference
		public event Action<Models.Message> MessageReceived;
		//GUI reference
		private Form _form;
		public Form form
		{
			set
			{
				value.FormClosed += (sender, e) =>
				{
					Stop();
					Application.Exit();
				};
				_form = value;
			}
			get
			{
				return _form;
			}
		}
		private Community()
		{
		}
		private T Deserialize<T>(object obj)
		{
			return JsonSerializer.Deserialize<T>((System.Text.Json.JsonElement)obj);
		}
		public static Community GetInstance()
		{
			return service;
		}
		private void ListenMessage()
		{
			while (true)
			{
				try
				{
					string jsonString = streamReader.ReadLine();
					if(string.IsNullOrEmpty(jsonString))
					{
						continue;
					}
					Models.Message message = JsonSerializer.Deserialize<Models.Message>(jsonString);
					HandleMessage(message);
					MessageReceived?.Invoke(message);
				}
				catch(Exception e)
				{
					Console.WriteLine("[ListenMessage]: " + e.ToString());
					break;
				}
			}
		}
		public void SendMessage(Models.Message message)
		{
			Console.WriteLine("[SENT CLIENT] " + message.ToString());
			string jsonString = JsonSerializer.Serialize(message);
			streamWriter.WriteLine(jsonString);
		}
		private bool Connect()
		{
			try
			{
				socket = new TcpClient(Connection.IP, Connection.PORT);
				var stream = socket.GetStream();
				streamReader = new StreamReader(stream, Encoding.UTF8);
				streamWriter = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine("Line 65: " + e.ToString());
				return false;
			}

		}
		public void Start()
		{
			bool connected = this.Connect();
			if(connected) 
				try
				{
					listenerThread = new Thread(() =>
					{
						ListenMessage();
					});
					listenerThread.Start();
				}
				catch
				{

				}
		}
		public void Stop()
		{
			try
			{
				listenerThread?.Abort();
				streamReader?.Close();
				streamWriter?.Close();
				socket?.Close();
			}
			catch
			{

			}
		}
		public void HandleMessage(Models.Message message)
		{
			Console.WriteLine("[RECEIVE CLIENT] " +message.ToString());
			switch (message.messageCode)
			{
				case Const.MessageCode.LOGIN:
					{
						if (!message.isSuccess)
						{
							break;
						}
						Service.DataSource.user = Deserialize<User>(message.messageData);
						break;
					}
				default:
					break;
			}
		}

	}
}
