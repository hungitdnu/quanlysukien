using Client.Models;
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
	public partial class FormMoiThamGia : Form
	{
		private Form frm;
		private int idSuKien;
		public FormMoiThamGia(int idSuKien, Form frm)
		{
			InitializeComponent();
			this.frm = frm;
			this.idSuKien = idSuKien;
			Service.Community.GetInstance().MessageReceived += FormMoiThamGia_MessageReceived;
			Service.Community.GetInstance().form = this;
		}

		private void ChangeStyleTable(List<User> users)
		{
			
			DataGridViewImageColumn statusColumn = new DataGridViewImageColumn();
			statusColumn.Name = "StatusColumn";
			statusColumn.HeaderText = "Trạng thái";
			statusColumn.Width = (int)(lstUser.Width * 0.2);
			lstUser.Columns.Add(statusColumn);

			//Header
			lstUser.Columns["userName"].HeaderText = "Tên người dùng";
			lstUser.Columns["fullName"].HeaderText = "Họ tên";
			lstUser.Columns["passWord"].Visible = false;
			lstUser.Columns["isOnline"].Visible = false;


			//Width
			lstUser.Columns["userName"].Width = (int)(lstUser.Width * 0.3);
			lstUser.Columns["fullName"].Width = (int)(lstUser.Width * 0.3);
			lstUser.Columns["isOnline"].Width = (int)(lstUser.Width * 0);
			lstUser.CellFormatting += (sender, e) =>
			{
				if (lstUser.Columns[e.ColumnIndex].Name == "StatusColumn")
				{
					if (e.Value == null)
					{
						// Lấy tên người dùng từ hàng hiện tại
						string username = lstUser.Rows[e.RowIndex].Cells["userName"].Value.ToString();
						// Lấy trạng thái online của người dùng
						bool isOnline = users.FirstOrDefault(x => x.userName == username)?.isOnline ?? false;

						// Đặt giá trị hình ảnh và tooltip dựa trên trạng thái online
						if (isOnline)
						{
							e.Value = Properties.Resources.online;
							lstUser.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Online";
						}
						else
						{
							e.Value = Properties.Resources.offline;
							lstUser.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Offline";
						}
						e.FormattingApplied = true;
					}
				}
			};
		}

		private void FormMoiThamGia_MessageReceived(Models.Message obj)
		{
			if(this.IsHandleCreated)
				this.Invoke((MethodInvoker)delegate
				{
					if (obj.messageCode == Const.MessageCode.GET_LIST_USER_INVITEABLE)
					{
						List<User> users = Utils.Serialize.Deserialize<List<User>>(obj.messageData);
						lstUser.Columns.Clear();
						lstUser.DataSource = users;
						ChangeStyleTable(users);
					}
					else if (obj.messageCode == Const.MessageCode.INVITE_USER)
					{
						if (obj.isSuccess)
						{
							Utils.GUI.ShowSuccess("Mời thành công");
						}
						else
						{
							Utils.GUI.ShowError(Utils.Serialize.Deserialize<string>(obj.messageData));
						}
					}
				});
		}

		private void FormMoiThamGia_Load(object sender, EventArgs e)
		{
			Service.Action.GetListUserInviteable(idSuKien);
		}

		private void btnMoi_Click(object sender, EventArgs e)
		{
			if (lstUser.CurrentRow == null)
			{
				return;
			}
			var username = lstUser.CurrentRow.Cells["userName"].Value.ToString();
			Service.Action.InviteUser(idSuKien, username);
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Invoke(new Action(() =>
			{
				Service.Action.GetListUser(idSuKien);
				this.frm.Show();
				Service.Community.GetInstance().MessageReceived -= FormMoiThamGia_MessageReceived;
				this.Dispose();
			}));
		}
	}
}
