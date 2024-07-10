using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Client.Service;

namespace Client
{
	public partial class DangNhap : Form
	{
		public DangNhap()
		{
			InitializeComponent();
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			string userName = txtUsername.Text;
			string passWord = txtPassword.Text;
			Service.Action.Login(userName, passWord);
			new Thread(() =>
			{
				Thread.Sleep(500);
				if(this.IsHandleCreated) 
				this.Invoke((MethodInvoker)delegate
				{
					if (Service.DataSource.user != null)
					{
						ChangeToDashboard();
					}
					else
					{
						Utils.GUI.ShowError("Đăng nhập thất bại");
					}
				});
			}).Start();
		}

		public void ChangeToDashboard()
		{
			txtPassword.Clear();
			DanhSachSuKien dssk = new DanhSachSuKien(this);
			dssk.Show();
			this.Hide();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Service.Community.GetInstance().form = this;
		}

		private void btnDangKy_Click(object sender, EventArgs e)
		{
			txtUsername.Clear();
			txtPassword.Clear();
			DangKy dk = new DangKy(this);
			dk.Show();
			this.Hide();
		}
	}
}
