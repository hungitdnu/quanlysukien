using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Server.Service
{
	internal class UserService: IService
	{
		public List<User> users = new List<User>();
		public event Action<List<User>> UserUpdate;
		public List<string> queries = new List<string>();
		private UserService() { }
		private static UserService instance;
		public static UserService gI()
		{
			if (instance == null)
			{
				instance = new UserService();
			}
			return instance;
		}

		public User GetUserExist(User user)
		{
			foreach (User u in users)
			{
				if (user.userName.Trim().Equals(u.userName) 
					&& u.passWord.Equals(user.passWord))
				{
					return u;
				}
			}
			return null;
		}
		public bool GetUserNameExist(string userName)
		{
			foreach (User u in users)
			{
				if (userName.Trim().Equals(u.userName))
				{
					return true;
				}
			}
			return false;
		}
		public User GetUserByUsername(string userName)
		{
			foreach (User u in users)
			{
				if (userName.Trim().Equals(u.userName))
				{
					return u;
				}
			}
			return null;
		}
		public Message Login(User user)
		{
			Message message = new Message();
			message.messageCode = Const.MessageCode.LOGIN;
			User usr = GetUserExist(user);
			if (usr == null)
			{
				message.isSuccess = false;
			}
			message.messageData = usr;
			return message;
		}
		public Message Register(User user)
		{
			Message message = new Message();
			message.messageCode = Const.MessageCode.REGISTER;
			bool account_exist = GetUserNameExist(user.userName);
			bool valid = Utils.Validate.IsValidUsername(user.userName) 
				&& Utils.Validate.IsValidPassword(user.passWord);
			if (account_exist)
			{
				message.messageData = "Người dùng đã tồn tại";
				message.isSuccess = false;
			}
			else if (!valid)
			{
				message.messageData = "Tài khoản hoặc mật khẩu không hợp lệ (chấp nhận 6-32 ký tự)";
				message.isSuccess = false;
			}
			else
			{
				users.Add(user);
				message.messageData = "Đăng ký thành công";
				queries.Add($"INSERT INTO NguoiDung VALUES (N'{user.fullName}', N'{user.userName}', N'{user.passWord}')");
			}
			Update();
			return message;
		}

		public void Start()
		{
			users = SqlService.gI().GetUSers();
			Update();
		}

		public void Stop()
		{
			users.Clear();
			Update();
		}
		public void Update()
		{
			foreach (var query in queries)
			{
				SqlService.gI().ExecuteQuery(query);
			}
			queries.Clear();
			UserUpdate?.Invoke(users);
		}
	}
}
