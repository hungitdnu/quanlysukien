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
	public partial class DanhSachYeuCau : Form
	{
		private int idSuKien;
		private Form frm;
		private List<Models.User> users;
		public DanhSachYeuCau(int idSuKien, Form frm)
		{
			InitializeComponent();
			this.idSuKien = idSuKien;
			this.frm = frm;
			Service.Community.GetInstance().form = this;
			
		}
		private void ListenerMessage(Models.Message message)
		{
			if(this.IsHandleCreated)
			this.Invoke(new Action(() =>
			{
				if (message.messageCode == Const.MessageCode.GET_LIST_USER_PENDING)
				{
					users = Utils.Serialize.Deserialize<List<Models.User>>(message.messageData);
					dsYeuCau.Columns.Clear();
					dsYeuCau.DataSource = users;
					ChangeStyleTable(users);
				}
			}));
		}

		private void ChangeStyleTable(List<Models.User> users)
		{

			try
			{
				DataGridViewImageColumn statusColumn = new DataGridViewImageColumn();
				statusColumn.Name = "StatusColumn";
				statusColumn.HeaderText = "Trạng thái";
				statusColumn.Width = (int)(dsYeuCau.Width * 0.2);
				dsYeuCau.Columns.Add(statusColumn);

				//Header
				dsYeuCau.Columns["userName"].HeaderText = "Tên người dùng";
				dsYeuCau.Columns["fullName"].HeaderText = "Họ tên";
				dsYeuCau.Columns["passWord"].Visible = false;
				dsYeuCau.Columns["isOnline"].Visible = false;


				//Width
				dsYeuCau.Columns["userName"].Width = (int)(dsYeuCau.Width * 0.3);
				dsYeuCau.Columns["fullName"].Width = (int)(dsYeuCau.Width * 0.3);
				dsYeuCau.Columns["isOnline"].Width = (int)(dsYeuCau.Width * 0);
				dsYeuCau.CellFormatting += (sender, e) =>
				{
					if (dsYeuCau.Columns[e.ColumnIndex].Name == "StatusColumn")
					{
						if (e.Value == null)
						{
							// Lấy tên người dùng từ hàng hiện tại
							string username = dsYeuCau.Rows[e.RowIndex].Cells["userName"].Value.ToString();
							// Lấy trạng thái online của người dùng
							bool isOnline = users.FirstOrDefault(x => x.userName == username)?.isOnline ?? false;

							// Đặt giá trị hình ảnh và tooltip dựa trên trạng thái online
							if (isOnline)
							{
								e.Value = Properties.Resources.online;
								dsYeuCau.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Online";
							}
							else
							{
								e.Value = Properties.Resources.offline;
								dsYeuCau.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Offline";
							}
							e.FormattingApplied = true;
						}
					}
				};
			}
			catch
			{

			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Invoke(new Action(() =>
			{
				Service.Action.GetListUser(idSuKien);
				frm.Show();
				Service.Community.GetInstance().MessageReceived -= ListenerMessage;
				this.Dispose();
			}));
		}

		private void DanhSachYeuCau_Load(object sender, EventArgs e)
		{
			Service.Community.GetInstance().MessageReceived += ListenerMessage;
			Service.Action.GetListUserPending(idSuKien);
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			if(dsYeuCau == null || dsYeuCau.CurrentRow == null)
			{
				return;
			}
			int index = dsYeuCau?.CurrentRow.Index ?? -1;
			if (index >= 0)
			{
				Service.Action.AcceptJoinEvent(idSuKien, dsYeuCau.Rows[index].Cells["userName"].Value.ToString(), true);
				Service.Action.GetListUserPending(idSuKien);
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (dsYeuCau == null || dsYeuCau.CurrentRow == null)
			{
				return;
			}
			int index = dsYeuCau?.CurrentRow.Index ?? -1;
			if (index >= 0)
			{
				Service.Action.AcceptJoinEvent(idSuKien, dsYeuCau.Rows[index].Cells["userName"].Value.ToString(), false);
				Service.Action.GetListUserPending(idSuKien);
			}
		}
	}
}
