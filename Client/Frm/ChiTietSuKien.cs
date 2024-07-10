using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Frm
{
	public partial class ChiTietSuKien : Form
	{
		private readonly Form frmDashboard;
		private int idSuKien;
		public ChiTietSuKien(Form frmDashboard, int idSuKien)
		{
			InitializeComponent();
			this.frmDashboard = frmDashboard;
			Service.Community.GetInstance().form = this;
			Service.Community.GetInstance().MessageReceived += ListenerMessage;
			this.idSuKien = idSuKien;
		}

		private void ChiTietSuKien_Load(object sender, EventArgs e)
		{
			Service.Action.IsOwner(idSuKien);
			Service.Action.GetInfoEvent(idSuKien);
			Service.Action.GetListUser(idSuKien);
		}

		internal void LoadData(Models.Event _event)
		{
			if(this.IsHandleCreated)
			this.Invoke(new Action(() =>
			{
				txtTenSuKien.Text = "Tên sự kiện: " + _event.tenSuKien;
				txtDiaDiem.Text = "Địa điểm: " + _event.diaDiem;
				txtMoTa.Text = "Mô tả: " + _event.moTa;
				txtThoiGian.Text = "Thời gian: "+ _event._thoiGian.ToString("dd/MM/yyyy");
			}));
		}

		internal void LoadListUser(List<Models.User> users)
		{
			this.Invoke(new Action(() =>
			{
				dsThamGia.DataSource = users;
				bool isJoined = users.Any(x => x!= null && x.userName == Service.DataSource.user.userName);
				btnJoin.Enabled = !isJoined;
				btnMoiThamGia.Enabled = isJoined;
				MappingData();
			}));
		}

		private void MappingData()
		{
			dsThamGia.Columns["fullName"].HeaderText = "Họ tên";
			dsThamGia.Columns["userName"].HeaderText = "Username";

			//Width
			dsThamGia.Columns["fullName"].Width = (int)(dsThamGia.Width * 0.5);
			dsThamGia.Columns["userName"].Width = (int)(dsThamGia.Width * 0.5);
			
			foreach(DataGridViewColumn col in dsThamGia.Columns)
			{
				if(col.Name != "fullName" && col.Name != "userName")
				{
					col.Visible = false;
				}
			}
		}

		private void ListenerMessage(Models.Message message)
		{
			if(this.IsHandleCreated)
			this.Invoke(new Action(() =>
			{
				if (message.messageCode == Const.MessageCode.GET_INFO_EVENT)
				{
					LoadData(Utils.Serialize.Deserialize<Models.Event>(message.messageData));
				}
				else if (message.messageCode == Const.MessageCode.GET_LIST_USER_JOIN)
				{
					LoadListUser(Utils.Serialize.Deserialize<List<Models.User>>(message.messageData));
				}
				else if (message.messageCode == Const.MessageCode.ACCEPT_REQUEST)
				{
					if (message.isSuccess)
					{
						Utils.GUI.ShowSuccess("Bạn đã tham gia sự kiện !");
						btnJoin.Enabled = false;
						btnMoiThamGia.Enabled = true;
					}
					Service.Action.GetListUser(idSuKien);
				}
				else if (message.messageCode == Const.MessageCode.REQUEST_JOIN)
				{
					if (message.isSuccess)
					{
						Utils.GUI.ShowSuccess(Utils.Serialize.Deserialize<string>(message.messageData));
					}
					else
					{
						Utils.GUI.ShowError(Utils.Serialize.Deserialize<string>(message.messageData));
					}
				}
				else if (message.messageCode == Const.MessageCode.IS_OWNER)
				{
					if(message.isSuccess)
					{
						btnDuyet.Visible = true;
					}
				}
			}));
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			if(this.IsHandleCreated)
			this.Invoke(new Action(() =>
			{
				Service.Action.GetEvents();
				frmDashboard.Show();
				Service.Community.GetInstance().MessageReceived -= ListenerMessage;
				this.Dispose();
			}));
		}

		private void btnMoiThamGia_Click(object sender, EventArgs e)
		{
			FormMoiThamGia form = new FormMoiThamGia(idSuKien, this);
			form.Show();
			this.Hide();
		}

		private void btnJoin_Click(object sender, EventArgs e)
		{
			Service.Action.RequestJoinEvent(idSuKien);
		}

		private void btnDuyet_Click(object sender, EventArgs e)
		{
			DanhSachYeuCau dsyc = new DanhSachYeuCau(idSuKien, this);
			dsyc.Show();
			this.Hide();
		}
	}
}
