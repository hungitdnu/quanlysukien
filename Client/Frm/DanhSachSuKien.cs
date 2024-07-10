using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Client.Frm;
using Client.Models;

namespace Client
{
	public partial class DanhSachSuKien : Form
	{
		private DangNhap form;
		public DanhSachSuKien(DangNhap form)
		{
			this.form = form;
			InitializeComponent();
			Service.Community.GetInstance().form = this;
			btnNew.Visible = false;
		}

		private void HandleMessage(Models.Message message)
		{
			if(this.IsHandleCreated)
			this.Invoke(new Action(() =>
			{
				if (message.messageCode == Const.MessageCode.GET_EVENT)
				{
					LoadData(Utils.Serialize.Deserialize<List<Event>>(message.messageData));
				}
				else if (message.messageCode == Const.MessageCode.LOGOUT)
				{
					this.Invoke(new Action(() =>
					{
						this.form.Show();
						Service.Community.GetInstance().MessageReceived -= HandleMessage;
						this.Dispose();
					}));
				}
				else if(message.messageCode == Const.MessageCode.NEW_INVITE)
				{
					btnNew.Visible = message.isSuccess;
				}
			}));
		}

		private void DanhSachSuKien_Load(object sender, EventArgs e)
		{
			Service.Community.GetInstance().MessageReceived += HandleMessage;
			Service.Action.GetEvents();
		}
		internal void LoadData(List<Event> events)
		{
			this.Invoke(new Action(() =>
			{
				tableGridView.DataSource = events;
				MappingData();
			}));
		}
		private void MappingData()
		{
			//Header
			tableGridView.Columns["ID"].HeaderText = "ID";
			tableGridView.Columns["tenSuKien"].HeaderText = "Tên sự kiện";
			tableGridView.Columns["_thoiGian"].HeaderText = "Thời gian";
			tableGridView.Columns["DiaDiem"].HeaderText = "Địa điểm";
			tableGridView.Columns["MoTa"].HeaderText = "Mô tả";

			//Width
			tableGridView.Columns["ID"].Width = (int)(tableGridView.Width * 0.1);
			tableGridView.Columns["tenSuKien"].Width = (int)(tableGridView.Width * 0.2);
			tableGridView.Columns["_thoiGian"].Width = (int)(tableGridView.Width * 0.2);
			tableGridView.Columns["DiaDiem"].Width = (int)(tableGridView.Width * 0.2);
			tableGridView.Columns["MoTa"].Width = (int)(tableGridView.Width * 0.3);

			tableGridView.CellFormatting += (sender, e) =>
			{
				if (tableGridView.Columns[e.ColumnIndex].Name == "_thoiGian")
				{
					if (e.Value != null)
					{
						if(e.Value is DateTime)
							e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
						e.FormattingApplied = true;
					}
				}
			};
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Service.Action.GetEvents();
			Service.Action.CheckInvite();
		}

		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			ThemMoiSuKien tmsk = new ThemMoiSuKien(this);
			tmsk.Show();
			this.Hide();
		}

		private void tableGridView_CurrentCellChanged(object sender, EventArgs e)
		{
			btnChitiet.Enabled = tableGridView.CurrentRow != null;
		}

		private void btnChitiet_Click(object sender, EventArgs e)
		{
			int selectedId = int.Parse(tableGridView.CurrentRow.Cells["ID"].Value.ToString());
			ChiTietSuKien ctsk = new ChiTietSuKien(this, selectedId);
			ctsk.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DanhSachLoiMoi dslm = new DanhSachLoiMoi(this);
			dslm.Show();
			this.Hide();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Service.Action.Logout();
		}
	}
}
