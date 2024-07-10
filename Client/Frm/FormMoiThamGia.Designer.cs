namespace Client.Frm
{
	partial class FormMoiThamGia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoiThamGia));
			this.lstUser = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnMoi = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.lstUser)).BeginInit();
			this.SuspendLayout();
			// 
			// lstUser
			// 
			this.lstUser.AllowUserToAddRows = false;
			this.lstUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.lstUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.lstUser.Location = new System.Drawing.Point(29, 99);
			this.lstUser.MultiSelect = false;
			this.lstUser.Name = "lstUser";
			this.lstUser.ReadOnly = true;
			this.lstUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.lstUser.Size = new System.Drawing.Size(435, 440);
			this.lstUser.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Danh sách thành viên";
			// 
			// btnBack
			// 
			this.btnBack.Image = global::Client.Properties.Resources.back;
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.Location = new System.Drawing.Point(350, 38);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(114, 36);
			this.btnBack.TabIndex = 3;
			this.btnBack.Text = "Quay lại";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnMoi
			// 
			this.btnMoi.Image = global::Client.Properties.Resources.invite_user;
			this.btnMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMoi.Location = new System.Drawing.Point(230, 38);
			this.btnMoi.Name = "btnMoi";
			this.btnMoi.Size = new System.Drawing.Size(114, 36);
			this.btnMoi.TabIndex = 2;
			this.btnMoi.Text = "Mời";
			this.btnMoi.UseVisualStyleBackColor = true;
			this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
			// 
			// FormMoiThamGia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 564);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnMoi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstUser);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMoiThamGia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mời tham gia sự kiện";
			this.Load += new System.EventHandler(this.FormMoiThamGia_Load);
			((System.ComponentModel.ISupportInitialize)(this.lstUser)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView lstUser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMoi;
		private System.Windows.Forms.Button btnBack;
	}
}