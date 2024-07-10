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
	public partial class DanhSachLoiMoi : Form
	{
		private Form frm;
		private List<Models.InviteEvent> inviteEvents = new List<InviteEvent>();
		public DanhSachLoiMoi(Form frm)
		{
			this.frm = frm;
			InitializeComponent();
			Service.Community.GetInstance().form = this;
			
			btnAccept.Enabled = btnRemove.Enabled = false;
		}

		private void HandleMessage(Models.Message message)
		{
			if(this.IsHandleCreated)
				this.Invoke((MethodInvoker)delegate
				{
					if (message.messageCode == Const.MessageCode.GET_LIST_INVITE)
					{
						inviteEvents = Utils.Serialize.Deserialize<List<Models.InviteEvent>>(message.messageData);
						dsLoiMoi.DataSource = inviteEvents;
						dsLoiMoi.Columns[0].HeaderText = "Sự kiện";
						dsLoiMoi.Columns[1].HeaderText = "Người mời";
						dsLoiMoi.Columns[2].HeaderText = "Người nhận";
					}
				});
		}

		private void DanhSachLoiMoi_Load(object sender, EventArgs e)
		{
			Service.Community.GetInstance().MessageReceived += HandleMessage;
			Service.Action.GetListInviteForMe();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Invoke((MethodInvoker)delegate
			{
				Service.Action.GetEvents();
				frm.Show();
				Service.Community.GetInstance().MessageReceived -= HandleMessage;
				this.Dispose();
			});
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			if(dsLoiMoi.CurrentRow == null)
				return;
			var index = dsLoiMoi.CurrentRow.Index;
			if(index >= 0)
			{
				var item = inviteEvents[index];
				Service.Action.AcceptInvite(item.suKien.ID, true);
				Service.Action.GetListInviteForMe();
			}
		}

		private void dsLoiMoi_CurrentCellChanged(object sender, EventArgs e)
		{
			if(dsLoiMoi.CurrentRow == null)
			{
				btnRemove.Enabled = btnAccept.Enabled = false;
				return;
			}
			var index = dsLoiMoi.CurrentRow.Index;
			btnRemove.Enabled = btnAccept.Enabled = index >= 0;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (dsLoiMoi.CurrentRow == null)
				return;
			var index = dsLoiMoi.CurrentRow.Index;
			if (index >= 0)
			{
				var item = inviteEvents[index];
				Service.Action.AcceptInvite(item.suKien.ID, false);
				Service.Action.GetListInviteForMe();
			}
		}
	}
}
