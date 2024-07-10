using System.Windows.Forms;

namespace Client.Frm
{
	partial class DanhSachLoiMoi: Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachLoiMoi));
			this.dsLoiMoi = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dsLoiMoi)).BeginInit();
			this.SuspendLayout();
			// 
			// dsLoiMoi
			// 
			this.dsLoiMoi.AllowUserToAddRows = false;
			this.dsLoiMoi.AllowUserToDeleteRows = false;
			this.dsLoiMoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dsLoiMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dsLoiMoi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dsLoiMoi.Location = new System.Drawing.Point(25, 65);
			this.dsLoiMoi.MultiSelect = false;
			this.dsLoiMoi.Name = "dsLoiMoi";
			this.dsLoiMoi.ReadOnly = true;
			this.dsLoiMoi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dsLoiMoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dsLoiMoi.Size = new System.Drawing.Size(443, 373);
			this.dsLoiMoi.TabIndex = 0;
			this.dsLoiMoi.CurrentCellChanged += new System.EventHandler(this.dsLoiMoi_CurrentCellChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Danh sách lời mời tham gia sự kiện";
			// 
			// btnBack
			// 
			this.btnBack.Image = global::Client.Properties.Resources.back;
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.Location = new System.Drawing.Point(501, 66);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 35);
			this.btnBack.TabIndex = 4;
			this.btnBack.Text = "Quay lại";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnAccept
			// 
			this.btnAccept.Image = global::Client.Properties.Resources.accept;
			this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAccept.Location = new System.Drawing.Point(501, 352);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(120, 35);
			this.btnAccept.TabIndex = 3;
			this.btnAccept.Text = "Chấp nhận";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Image = global::Client.Properties.Resources.remove;
			this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemove.Location = new System.Drawing.Point(501, 404);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(120, 35);
			this.btnRemove.TabIndex = 2;
			this.btnRemove.Text = "Từ chối";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// DanhSachLoiMoi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 450);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dsLoiMoi);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DanhSachLoiMoi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách lời mời tham gia sự kiện";
			this.Load += new System.EventHandler(this.DanhSachLoiMoi_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsLoiMoi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dsLoiMoi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Button btnBack;
	}
}