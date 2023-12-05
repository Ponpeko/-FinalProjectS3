namespace BusTicketAppV0._2.View
{
    partial class InfoRute
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
            this.txtCariRute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCariRute = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnTambahRute = new System.Windows.Forms.Button();
            this.btnUpdateRute = new System.Windows.Forms.Button();
            this.btnHapusBus = new System.Windows.Forms.Button();
            this.lvwRute = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtCariRute
            // 
            this.txtCariRute.Location = new System.Drawing.Point(140, 48);
            this.txtCariRute.Name = "txtCariRute";
            this.txtCariRute.Size = new System.Drawing.Size(399, 20);
            this.txtCariRute.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cari Kota Tujuan";
            // 
            // btnCariRute
            // 
            this.btnCariRute.Location = new System.Drawing.Point(545, 46);
            this.btnCariRute.Name = "btnCariRute";
            this.btnCariRute.Size = new System.Drawing.Size(61, 23);
            this.btnCariRute.TabIndex = 15;
            this.btnCariRute.Text = "Cari";
            this.btnCariRute.UseVisualStyleBackColor = true;
            this.btnCariRute.Click += new System.EventHandler(this.btnCariRute_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(54, 247);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(61, 36);
            this.btnKembali.TabIndex = 14;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click_1);
            // 
            // btnTambahRute
            // 
            this.btnTambahRute.Location = new System.Drawing.Point(367, 247);
            this.btnTambahRute.Name = "btnTambahRute";
            this.btnTambahRute.Size = new System.Drawing.Size(78, 36);
            this.btnTambahRute.TabIndex = 13;
            this.btnTambahRute.Text = "Tambah Rute";
            this.btnTambahRute.UseVisualStyleBackColor = true;
            this.btnTambahRute.Click += new System.EventHandler(this.btnTambahRute_Click);
            // 
            // btnUpdateRute
            // 
            this.btnUpdateRute.Location = new System.Drawing.Point(451, 247);
            this.btnUpdateRute.Name = "btnUpdateRute";
            this.btnUpdateRute.Size = new System.Drawing.Size(79, 36);
            this.btnUpdateRute.TabIndex = 12;
            this.btnUpdateRute.Text = "Update Rute";
            this.btnUpdateRute.UseVisualStyleBackColor = true;
            this.btnUpdateRute.Click += new System.EventHandler(this.btnUpdateRute_Click);
            // 
            // btnHapusBus
            // 
            this.btnHapusBus.Location = new System.Drawing.Point(536, 247);
            this.btnHapusBus.Name = "btnHapusBus";
            this.btnHapusBus.Size = new System.Drawing.Size(70, 36);
            this.btnHapusBus.TabIndex = 11;
            this.btnHapusBus.Text = "Hapus Rute";
            this.btnHapusBus.UseVisualStyleBackColor = true;
            this.btnHapusBus.Click += new System.EventHandler(this.btnHapusBus_Click_1);
            // 
            // lvwRute
            // 
            this.lvwRute.HideSelection = false;
            this.lvwRute.Location = new System.Drawing.Point(54, 77);
            this.lvwRute.Name = "lvwRute";
            this.lvwRute.Size = new System.Drawing.Size(552, 151);
            this.lvwRute.TabIndex = 10;
            this.lvwRute.UseCompatibleStateImageBehavior = false;
            // 
            // InfoRute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 304);
            this.Controls.Add(this.txtCariRute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCariRute);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnTambahRute);
            this.Controls.Add(this.btnUpdateRute);
            this.Controls.Add(this.btnHapusBus);
            this.Controls.Add(this.lvwRute);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoRute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoRute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCariRute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCariRute;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnTambahRute;
        private System.Windows.Forms.Button btnUpdateRute;
        private System.Windows.Forms.Button btnHapusBus;
        private System.Windows.Forms.ListView lvwRute;
    }
}