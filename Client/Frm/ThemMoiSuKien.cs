using Client.Const;
using Client.Models;
using Client.Utils;
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
	public partial class ThemMoiSuKien : Form
	{
		private DanhSachSuKien frm;
		public ThemMoiSuKien(DanhSachSuKien frm)
		{
			InitializeComponent();
			this.frm = frm;
			Service.Community.GetInstance().form = this;
			Service.Community.GetInstance().MessageReceived += (message) =>
			{
				if (message.messageCode == MessageCode.CREATE_EVENT)
				{
					if(this.InvokeRequired)
					this.Invoke(new Action(() =>
					{
						Service.Action.GetEvents();
						if (message.isSuccess)
						{
							GUI.ShowSuccess("Thêm sự kiện mới thành công");
							this.frm.Show();
							this.Dispose();
						}
						else
						{
							GUI.ShowError("Thêm sự kiện mới thất bại");
						}
					}));
				}
			};
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtTenSuKien.Text) || string.IsNullOrEmpty(txtMoTa.Text)|| 
				string.IsNullOrEmpty(txtDiaDiem.Text) || dateSk.Value < DateTime.Now)
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn ngày sau ngày hiện tại");
				return;
			}
			Event _event = new Event(txtTenSuKien.Text, dateSk.Value, txtDiaDiem.Text, txtMoTa.Text);
			Service.Action.CreateEvent(_event);
		}

		private void ThemMoiSuKien_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Invoke(new Action(() =>
			{
				Service.Action.GetEvents();
				this.frm.Show();
				this.Dispose();
			}));
		}
	}
}
