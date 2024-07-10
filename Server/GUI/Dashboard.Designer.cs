namespace Server.GUI
{
	partial class Dashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			this.label1 = new System.Windows.Forms.Label();
			this.txtStatus = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvUser = new System.Windows.Forms.DataGridView();
			this.dsSuKien = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOnOff = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsSuKien)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Trạng thái: ";
			// 
			// txtStatus
			// 
			this.txtStatus.AutoSize = true;
			this.txtStatus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStatus.ForeColor = System.Drawing.Color.Red;
			this.txtStatus.Location = new System.Drawing.Point(141, 79);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(64, 23);
			this.txtStatus.TabIndex = 3;
			this.txtStatus.Text = "Offline";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Danh sách user";
			// 
			// dgvUser
			// 
			this.dgvUser.AllowUserToAddRows = false;
			this.dgvUser.AllowUserToDeleteRows = false;
			this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUser.Location = new System.Drawing.Point(16, 194);
			this.dgvUser.Name = "dgvUser";
			this.dgvUser.ReadOnly = true;
			this.dgvUser.Size = new System.Drawing.Size(504, 233);
			this.dgvUser.TabIndex = 6;
			// 
			// dsSuKien
			// 
			this.dsSuKien.AllowUserToAddRows = false;
			this.dsSuKien.AllowUserToDeleteRows = false;
			this.dsSuKien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dsSuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dsSuKien.Location = new System.Drawing.Point(16, 518);
			this.dsSuKien.Name = "dsSuKien";
			this.dsSuKien.ReadOnly = true;
			this.dsSuKien.Size = new System.Drawing.Size(504, 236);
			this.dsSuKien.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 465);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Danh sách event";
			// 
			// btnOnOff
			// 
			this.btnOnOff.Image = global::Server.Properties.Resources.start;
			this.btnOnOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOnOff.Location = new System.Drawing.Point(300, 77);
			this.btnOnOff.Name = "btnOnOff";
			this.btnOnOff.Size = new System.Drawing.Size(86, 33);
			this.btnOnOff.TabIndex = 1;
			this.btnOnOff.Text = "Start";
			this.btnOnOff.UseVisualStyleBackColor = true;
			this.btnOnOff.Click += new System.EventHandler(this.button1_Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 835);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dsSuKien);
			this.Controls.Add(this.dgvUser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOnOff);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
			this.Load += new System.EventHandler(this.Dashboard_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsSuKien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOnOff;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label txtStatus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvUser;
		private System.Windows.Forms.DataGridView dsSuKien;
		private System.Windows.Forms.Label label3;
	}
}