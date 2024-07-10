namespace Client
{
	partial class DanhSachSuKien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSuKien));
			this.tableGridView = new System.Windows.Forms.DataGridView();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnChitiet = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnThemMoi = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.tableGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
			this.SuspendLayout();
			// 
			// tableGridView
			// 
			this.tableGridView.AllowUserToAddRows = false;
			this.tableGridView.AllowUserToDeleteRows = false;
			this.tableGridView.AllowUserToOrderColumns = true;
			this.tableGridView.AllowUserToResizeRows = false;
			this.tableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.tableGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.tableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableGridView.Location = new System.Drawing.Point(35, 37);
			this.tableGridView.Name = "tableGridView";
			this.tableGridView.ReadOnly = true;
			this.tableGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tableGridView.Size = new System.Drawing.Size(732, 464);
			this.tableGridView.TabIndex = 0;
			this.tableGridView.CurrentCellChanged += new System.EventHandler(this.tableGridView_CurrentCellChanged);
			// 
			// btnLogout
			// 
			this.btnLogout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.Image = global::Client.Properties.Resources.logout;
			this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogout.Location = new System.Drawing.Point(810, 452);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(128, 49);
			this.btnLogout.TabIndex = 8;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnChitiet
			// 
			this.btnChitiet.Enabled = false;
			this.btnChitiet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChitiet.Image = ((System.Drawing.Image)(resources.GetObject("btnChitiet.Image")));
			this.btnChitiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnChitiet.Location = new System.Drawing.Point(810, 342);
			this.btnChitiet.Name = "btnChitiet";
			this.btnChitiet.Size = new System.Drawing.Size(128, 49);
			this.btnChitiet.TabIndex = 7;
			this.btnChitiet.Text = "Chi tiết";
			this.btnChitiet.UseVisualStyleBackColor = true;
			this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
			// 
			// btnNew
			// 
			this.btnNew.BackColor = System.Drawing.Color.Transparent;
			this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
			this.btnNew.Location = new System.Drawing.Point(914, 107);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(24, 24);
			this.btnNew.TabIndex = 6;
			this.btnNew.TabStop = false;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(810, 107);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 49);
			this.button1.TabIndex = 4;
			this.button1.Text = "Lời mời";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(810, 37);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 49);
			this.button3.TabIndex = 3;
			this.button3.Text = "Refresh";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnThemMoi
			// 
			this.btnThemMoi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
			this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThemMoi.Location = new System.Drawing.Point(810, 397);
			this.btnThemMoi.Name = "btnThemMoi";
			this.btnThemMoi.Size = new System.Drawing.Size(128, 49);
			this.btnThemMoi.TabIndex = 1;
			this.btnThemMoi.Text = "Thêm mới";
			this.btnThemMoi.UseVisualStyleBackColor = true;
			this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
			// 
			// DanhSachSuKien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(969, 530);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnChitiet);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnThemMoi);
			this.Controls.Add(this.tableGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DanhSachSuKien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách sự kiện";
			this.Load += new System.EventHandler(this.DanhSachSuKien_Load);
			((System.ComponentModel.ISupportInitialize)(this.tableGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView tableGridView;
		private System.Windows.Forms.Button btnThemMoi;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox btnNew;
		private System.Windows.Forms.Button btnChitiet;
		private System.Windows.Forms.Button btnLogout;
	}
}