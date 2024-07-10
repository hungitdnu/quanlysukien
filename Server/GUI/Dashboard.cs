using Server.Models;
using Server.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Server.GUI
{
	public partial class Dashboard : Form
	{
		private bool isStarted = false;
		public Dashboard()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(isStarted)
			{
				Service.Service.GetInstance().Stop();
				btnOnOff.Text = "Start";
				txtStatus.Text = "Offline";
				txtStatus.ForeColor = Color.Red;
			}
			else
			{
				Service.Service.GetInstance().Start();
				btnOnOff.Text = "Stop";
				txtStatus.Text = "Online";
				txtStatus.ForeColor = Color.Green;
			}
			isStarted = !isStarted;
		}

		private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
		{
			Service.Service.GetInstance().Stop();
		}

		private BindingList<User> bindingListUsers = new BindingList<User>();
		private BindingList<Event> bindingListEvents = new BindingList<Event>();
		private List<User> listUsers = new List<User>();
		private void Dashboard_Load(object sender, EventArgs e)
		{
            UserService.gI().UserUpdate += HandleUpdateUsers;
			EventService.gI().EventUpdate += HandleUpdateEvents;
			dsSuKien.DataSource = bindingListEvents;
			dgvUser.DataSource = bindingListUsers;
			dgvUser.CellFormatting += DgvUser_CellFormatting;
			dsSuKien.CellFormatting += DgvEvent_CellFormatting;
		}
		private void DgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvUser.Columns[e.ColumnIndex].Name == "StatusColumn")
			{
				if (e.Value == null)
				{
					// Lấy tên người dùng từ hàng hiện tại
					string username = dgvUser.Rows[e.RowIndex].Cells["userName"].Value.ToString();
					// Lấy trạng thái online của người dùng
					bool isOnline = listUsers.FirstOrDefault(x => x.userName == username)?.isOnline ?? false;

					// Đặt giá trị hình ảnh và tooltip dựa trên trạng thái online
					if (isOnline)
					{
						e.Value = Properties.Resources.online;
						dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Online";
					}
					else
					{
						e.Value = Properties.Resources.offline;
						dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Offline";
					}
					e.FormattingApplied = true;
				}
			}
		}
		private void HandleUpdateUsers(List<User> users)
		{
			if (this.IsHandleCreated)
			{
				this.Invoke((MethodInvoker)delegate
				{
					listUsers = users;
					bindingListUsers.Clear();
					foreach (var user in users)
					{
						bindingListUsers.Add(user);
					}
					ChangeStyleDgvUser();
				});
			}

		}
		private void ChangeStyleDgvUser()
		{
			if (dgvUser.Columns["StatusColumn"] == null)
			{
				DataGridViewImageColumn statusColumn = new DataGridViewImageColumn();
				statusColumn.Name = "StatusColumn";
				statusColumn.HeaderText = "Trạng thái";
				statusColumn.Width = (int)(dgvUser.Width * 0.2);
				dgvUser.Columns.Add(statusColumn);
			}
			

			//Header
			dgvUser.Columns["userName"].HeaderText = "Tên người dùng";
			dgvUser.Columns["fullName"].HeaderText = "Họ tên";
			dgvUser.Columns["passWord"].Visible = false;
			dgvUser.Columns["isOnline"].Visible = false;


			//Width
			dgvUser.Columns["userName"].Width = (int)(dgvUser.Width * 0.3);
			dgvUser.Columns["fullName"].Width = (int)(dgvUser.Width * 0.3);
			dgvUser.Columns["isOnline"].Width = (int)(dgvUser.Width * 0);
			dgvUser.Refresh();
		}

		private void HandleUpdateEvents(List<Event> events)
		{
			if (events == null) return;
			if (this.IsHandleCreated)
			{
				this.Invoke((MethodInvoker)delegate
				{
					bindingListEvents.Clear();
					foreach (var ev in events)
					{
						bindingListEvents.Add(ev);
					}
					ChangeStyleDgvEvent();
				});
			}

		}
		private void ChangeStyleDgvEvent()
		{
			//Header
			dsSuKien.Columns["tenSuKien"].HeaderText = "Sự kiện";
			dsSuKien.Columns["_thoiGian"].HeaderText = "Thời gian";
			dsSuKien.Columns["diaDiem"].HeaderText = "Địa điểm";
			dsSuKien.Columns["ID"].Visible = false;
			dsSuKien.Columns["moTa"].Visible = false;

			//Width
			dsSuKien.Columns["tenSuKien"].Width = (int)(dsSuKien.Width * 0.3);
			dsSuKien.Columns["_thoiGian"].Width = (int)(dsSuKien.Width * 0.3);
			dsSuKien.Columns["diaDiem"].Width = (int)(dsSuKien.Width * 0.2);
			dsSuKien.Refresh();
		}

		private void DgvEvent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value is DateTime)
			{
				e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
				e.FormattingApplied = true;
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			
		}
	}
}
