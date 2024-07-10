namespace Client.Frm
{
	partial class DanhSachYeuCau
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachYeuCau));
			this.label1 = new System.Windows.Forms.Label();
			this.dsYeuCau = new System.Windows.Forms.DataGridView();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dsYeuCau)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 19);
			this.label1.TabIndex = 6;
			this.label1.Text = "Danh sách yêu cầu tham gia sự kiện";
			// 
			// dsYeuCau
			// 
			this.dsYeuCau.AllowUserToAddRows = false;
			this.dsYeuCau.AllowUserToDeleteRows = false;
			this.dsYeuCau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dsYeuCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dsYeuCau.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dsYeuCau.Location = new System.Drawing.Point(21, 58);
			this.dsYeuCau.MultiSelect = false;
			this.dsYeuCau.Name = "dsYeuCau";
			this.dsYeuCau.ReadOnly = true;
			this.dsYeuCau.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dsYeuCau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dsYeuCau.Size = new System.Drawing.Size(348, 373);
			this.dsYeuCau.TabIndex = 5;
			// 
			// btnBack
			// 
			this.btnBack.Image = global::Client.Properties.Resources.back;
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.Location = new System.Drawing.Point(406, 58);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 35);
			this.btnBack.TabIndex = 9;
			this.btnBack.Text = "Quay lại";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnAccept
			// 
			this.btnAccept.Image = global::Client.Properties.Resources.accept;
			this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAccept.Location = new System.Drawing.Point(406, 338);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(120, 35);
			this.btnAccept.TabIndex = 8;
			this.btnAccept.Text = "Chấp nhận";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Image = global::Client.Properties.Resources.remove;
			this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemove.Location = new System.Drawing.Point(406, 396);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(120, 35);
			this.btnRemove.TabIndex = 7;
			this.btnRemove.Text = "Từ chối";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// DanhSachYeuCau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 468);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dsYeuCau);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DanhSachYeuCau";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách yêu cầu ";
			this.Load += new System.EventHandler(this.DanhSachYeuCau_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsYeuCau)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dsYeuCau;
	}
}