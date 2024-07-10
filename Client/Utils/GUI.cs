using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client.Utils
{
	internal class GUI
	{
		public static void ShowMessage(string message)
		{
			new Thread(() => 
			MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)).Start();
		}
		public static void ShowError(string message)
		{
			new Thread(() =>
			MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)).Start();
		}
		public static void ShowSuccess(string message)
		{
			new Thread(() =>
			MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)).Start();
		}
	}
}
