using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class DangKy : Form
	{
		private Form _formDangNhap;
		public DangKy(Form formDangNhap)
		{
			_formDangNhap = formDangNhap;
			InitializeComponent();
		}

		private void btnDangKy_Click(object sender, EventArgs e)
		{
			string fullName = txtHoTen.Text;
			string userName = txtUsername.Text;
			string passWord = txtPassword.Text;
			Service.Action.Register(userName, passWord, fullName);
		}

		private void DangKy_Load(object sender, EventArgs e)
		{
			Service.Community.GetInstance().form = this;
			Service.Community.GetInstance().MessageReceived += HandleMessage;

		}

		private void HandleMessage(Models.Message message)
		{
			if (this.IsHandleCreated)
			{
				this.Invoke((MethodInvoker)delegate
				{
					if (message.messageCode == Const.MessageCode.REGISTER)
					{
						if (message.isSuccess)
						{
							Utils.GUI.ShowSuccess(message.messageData.ToString());
						}
						else
						{
							Utils.GUI.ShowError(message.messageData.ToString());
						}
					}
				});
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			_formDangNhap.Show();
			Service.Community.GetInstance().MessageReceived -= HandleMessage;
			this.Dispose();
		}
	}
}
