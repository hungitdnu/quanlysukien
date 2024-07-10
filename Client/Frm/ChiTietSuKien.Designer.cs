namespace Client.Frm
{
	partial class ChiTietSuKien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietSuKien));
			this.txtDiaDiem = new System.Windows.Forms.Label();
			this.txtMoTa = new System.Windows.Forms.Label();
			this.txtThoiGian = new System.Windows.Forms.Label();
			this.dsThamGia = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDuyet = new System.Windows.Forms.Button();
			this.btnMoiThamGia = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnJoin = new System.Windows.Forms.Button();
			this.txtTenSuKien = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dsThamGia)).BeginInit();
			this.SuspendLayout();
			// 
			// txtDiaDiem
			// 
			this.txtDiaDiem.AutoSize = true;
			this.txtDiaDiem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaDiem.Location = new System.Drawing.Point(75, 109);
			this.txtDiaDiem.Name = "txtDiaDiem";
			this.txtDiaDiem.Size = new System.Drawing.Size(97, 23);
			this.txtDiaDiem.TabIndex = 0;
			this.txtDiaDiem.Text = "Địa điểm: ";
			// 
			// txtMoTa
			// 
			this.txtMoTa.AutoSize = true;
			this.txtMoTa.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMoTa.Location = new System.Drawing.Point(75, 161);
			this.txtMoTa.Name = "txtMoTa";
			this.txtMoTa.Size = new System.Drawing.Size(70, 23);
			this.txtMoTa.TabIndex = 1;
			this.txtMoTa.Text = "Mô tả: ";
			// 
			// txtThoiGian
			// 
			this.txtThoiGian.AutoSize = true;
			this.txtThoiGian.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtThoiGian.Location = new System.Drawing.Point(71, 212);
			this.txtThoiGian.Name = "txtThoiGian";
			this.txtThoiGian.Size = new System.Drawing.Size(101, 23);
			this.txtThoiGian.TabIndex = 2;
			this.txtThoiGian.Text = "Thời gian: ";
			// 
			// dsThamGia
			// 
			this.dsThamGia.AllowUserToAddRows = false;
			this.dsThamGia.AllowUserToDeleteRows = false;
			this.dsThamGia.AllowUserToOrderColumns = true;
			this.dsThamGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dsThamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dsThamGia.Location = new System.Drawing.Point(75, 295);
			this.dsThamGia.Name = "dsThamGia";
			this.dsThamGia.ReadOnly = true;
			this.dsThamGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dsThamGia.Size = new System.Drawing.Size(454, 294);
			this.dsThamGia.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(75, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(179, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Danh sách tham gia";
			// 
			// btnDuyet
			// 
			this.btnDuyet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDuyet.Image = global::Client.Properties.Resources.pending;
			this.btnDuyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDuyet.Location = new System.Drawing.Point(591, 109);
			this.btnDuyet.Name = "btnDuyet";
			this.btnDuyet.Size = new System.Drawing.Size(161, 42);
			this.btnDuyet.TabIndex = 8;
			this.btnDuyet.Text = "Yêu cầu tham gia";
			this.btnDuyet.UseVisualStyleBackColor = true;
			this.btnDuyet.Visible = false;
			this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
			// 
			// btnMoiThamGia
			// 
			this.btnMoiThamGia.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoiThamGia.Image = ((System.Drawing.Image)(resources.GetObject("btnMoiThamGia.Image")));
			this.btnMoiThamGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMoiThamGia.Location = new System.Drawing.Point(591, 485);
			this.btnMoiThamGia.Name = "btnMoiThamGia";
			this.btnMoiThamGia.Size = new System.Drawing.Size(161, 42);
			this.btnMoiThamGia.TabIndex = 7;
			this.btnMoiThamGia.Text = "Mời bạn bè";
			this.btnMoiThamGia.UseVisualStyleBackColor = true;
			this.btnMoiThamGia.Click += new System.EventHandler(this.btnMoiThamGia_Click);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.Location = new System.Drawing.Point(591, 533);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(161, 42);
			this.btnBack.TabIndex = 6;
			this.btnBack.Text = "Quay lại";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnJoin
			// 
			this.btnJoin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJoin.Image = ((System.Drawing.Image)(resources.GetObject("btnJoin.Image")));
			this.btnJoin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnJoin.Location = new System.Drawing.Point(591, 53);
			this.btnJoin.Name = "btnJoin";
			this.btnJoin.Size = new System.Drawing.Size(161, 42);
			this.btnJoin.TabIndex = 3;
			this.btnJoin.Text = "Xin vào";
			this.btnJoin.UseVisualStyleBackColor = true;
			this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
			// 
			// txtTenSuKien
			// 
			this.txtTenSuKien.AutoSize = true;
			this.txtTenSuKien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenSuKien.Location = new System.Drawing.Point(71, 53);
			this.txtTenSuKien.Name = "txtTenSuKien";
			this.txtTenSuKien.Size = new System.Drawing.Size(121, 23);
			this.txtTenSuKien.TabIndex = 9;
			this.txtTenSuKien.Text = "Tên sự kiện: ";
			// 
			// ChiTietSuKien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 601);
			this.Controls.Add(this.txtTenSuKien);
			this.Controls.Add(this.btnDuyet);
			this.Controls.Add(this.btnMoiThamGia);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dsThamGia);
			this.Controls.Add(this.btnJoin);
			this.Controls.Add(this.txtThoiGian);
			this.Controls.Add(this.txtMoTa);
			this.Controls.Add(this.txtDiaDiem);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChiTietSuKien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chi tiết sự kiện";
			this.Load += new System.EventHandler(this.ChiTietSuKien_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsThamGia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txtDiaDiem;
		private System.Windows.Forms.Label txtMoTa;
		private System.Windows.Forms.Label txtThoiGian;
		private System.Windows.Forms.Button btnJoin;
		private System.Windows.Forms.DataGridView dsThamGia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnMoiThamGia;
		private System.Windows.Forms.Button btnDuyet;
		private System.Windows.Forms.Label txtTenSuKien;
	}
}