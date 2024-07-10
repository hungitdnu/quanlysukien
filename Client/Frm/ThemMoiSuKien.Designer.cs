namespace Client
{
	partial class ThemMoiSuKien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemMoiSuKien));
			this.label1 = new System.Windows.Forms.Label();
			this.txtTenSuKien = new System.Windows.Forms.TextBox();
			this.txtDiaDiem = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMoTa = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateSk = new System.Windows.Forms.DateTimePicker();
			this.button2 = new System.Windows.Forms.Button();
			this.btnThemMoi = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(42, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tên sự kiện";
			// 
			// txtTenSuKien
			// 
			this.txtTenSuKien.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenSuKien.Location = new System.Drawing.Point(196, 66);
			this.txtTenSuKien.Name = "txtTenSuKien";
			this.txtTenSuKien.Size = new System.Drawing.Size(303, 30);
			this.txtTenSuKien.TabIndex = 2;
			// 
			// txtDiaDiem
			// 
			this.txtDiaDiem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaDiem.Location = new System.Drawing.Point(196, 387);
			this.txtDiaDiem.Name = "txtDiaDiem";
			this.txtDiaDiem.Size = new System.Drawing.Size(303, 30);
			this.txtDiaDiem.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(49, 390);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Địa điểm";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(78, 281);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Mô tả";
			// 
			// txtMoTa
			// 
			this.txtMoTa.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMoTa.Location = new System.Drawing.Point(196, 240);
			this.txtMoTa.Multiline = true;
			this.txtMoTa.Name = "txtMoTa";
			this.txtMoTa.Size = new System.Drawing.Size(303, 112);
			this.txtMoTa.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(42, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Thời gian";
			// 
			// dateSk
			// 
			this.dateSk.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateSk.Location = new System.Drawing.Point(196, 168);
			this.dateSk.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
			this.dateSk.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateSk.Name = "dateSk";
			this.dateSk.Size = new System.Drawing.Size(303, 30);
			this.dateSk.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(316, 449);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 42);
			this.button2.TabIndex = 7;
			this.button2.Text = "Quay lại";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnThemMoi
			// 
			this.btnThemMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
			this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThemMoi.Location = new System.Drawing.Point(196, 449);
			this.btnThemMoi.Name = "btnThemMoi";
			this.btnThemMoi.Size = new System.Drawing.Size(104, 42);
			this.btnThemMoi.TabIndex = 6;
			this.btnThemMoi.Text = "Thêm mới";
			this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThemMoi.UseVisualStyleBackColor = true;
			this.btnThemMoi.Click += new System.EventHandler(this.button1_Click);
			// 
			// ThemMoiSuKien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 538);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dateSk);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMoTa);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDiaDiem);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTenSuKien);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnThemMoi);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ThemMoiSuKien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý sự kiện - Thêm mới";
			this.Load += new System.EventHandler(this.ThemMoiSuKien_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnThemMoi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenSuKien;
		private System.Windows.Forms.TextBox txtDiaDiem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMoTa;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateSk;
		private System.Windows.Forms.Button button2;
	}
}