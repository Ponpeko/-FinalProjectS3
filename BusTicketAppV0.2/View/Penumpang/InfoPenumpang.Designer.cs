namespace BusTicketAppV0._2.View
{
    partial class InfoPenumpang
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
            this.txtCariPenumpang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCariPenumpang = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnTambahPenumpang = new System.Windows.Forms.Button();
            this.btnUpdatePenumpang = new System.Windows.Forms.Button();
            this.btnHapusPenumpang = new System.Windows.Forms.Button();
            this.lvwPenumpang = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtCariPenumpang
            // 
            this.txtCariPenumpang.Location = new System.Drawing.Point(104, 62);
            this.txtCariPenumpang.Name = "txtCariPenumpang";
            this.txtCariPenumpang.Size = new System.Drawing.Size(278, 20);
            this.txtCariPenumpang.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cari Nama";
            // 
            // btnCariPenumpang
            // 
            this.btnCariPenumpang.Location = new System.Drawing.Point(388, 60);
            this.btnCariPenumpang.Name = "btnCariPenumpang";
            this.btnCariPenumpang.Size = new System.Drawing.Size(61, 23);
            this.btnCariPenumpang.TabIndex = 23;
            this.btnCariPenumpang.Text = "Cari";
            this.btnCariPenumpang.UseVisualStyleBackColor = true;
            this.btnCariPenumpang.Click += new System.EventHandler(this.btnCariPenumpang_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(45, 331);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(61, 36);
            this.btnKembali.TabIndex = 22;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnTambahPenumpang
            // 
            this.btnTambahPenumpang.Location = new System.Drawing.Point(199, 331);
            this.btnTambahPenumpang.Name = "btnTambahPenumpang";
            this.btnTambahPenumpang.Size = new System.Drawing.Size(78, 36);
            this.btnTambahPenumpang.TabIndex = 21;
            this.btnTambahPenumpang.Text = "Tambah Penumpang";
            this.btnTambahPenumpang.UseVisualStyleBackColor = true;
            this.btnTambahPenumpang.Click += new System.EventHandler(this.btnTambahPenumpang_Click);
            // 
            // btnUpdatePenumpang
            // 
            this.btnUpdatePenumpang.Location = new System.Drawing.Point(283, 331);
            this.btnUpdatePenumpang.Name = "btnUpdatePenumpang";
            this.btnUpdatePenumpang.Size = new System.Drawing.Size(79, 36);
            this.btnUpdatePenumpang.TabIndex = 20;
            this.btnUpdatePenumpang.Text = "Update Penumpang";
            this.btnUpdatePenumpang.UseVisualStyleBackColor = true;
            this.btnUpdatePenumpang.Click += new System.EventHandler(this.btnUpdatePenumpang_Click);
            // 
            // btnHapusPenumpang
            // 
            this.btnHapusPenumpang.Location = new System.Drawing.Point(368, 331);
            this.btnHapusPenumpang.Name = "btnHapusPenumpang";
            this.btnHapusPenumpang.Size = new System.Drawing.Size(81, 36);
            this.btnHapusPenumpang.TabIndex = 19;
            this.btnHapusPenumpang.Text = "Hapus Penumpang";
            this.btnHapusPenumpang.UseVisualStyleBackColor = true;
            this.btnHapusPenumpang.Click += new System.EventHandler(this.btnHapusPenumpang_Click);
            // 
            // lvwPenumpang
            // 
            this.lvwPenumpang.HideSelection = false;
            this.lvwPenumpang.Location = new System.Drawing.Point(45, 92);
            this.lvwPenumpang.Name = "lvwPenumpang";
            this.lvwPenumpang.Size = new System.Drawing.Size(404, 233);
            this.lvwPenumpang.TabIndex = 18;
            this.lvwPenumpang.UseCompatibleStateImageBehavior = false;
            // 
            // InfoPenumpang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 408);
            this.Controls.Add(this.txtCariPenumpang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCariPenumpang);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnTambahPenumpang);
            this.Controls.Add(this.btnUpdatePenumpang);
            this.Controls.Add(this.btnHapusPenumpang);
            this.Controls.Add(this.lvwPenumpang);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoPenumpang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoPenumpang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCariPenumpang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCariPenumpang;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnTambahPenumpang;
        private System.Windows.Forms.Button btnUpdatePenumpang;
        private System.Windows.Forms.Button btnHapusPenumpang;
        private System.Windows.Forms.ListView lvwPenumpang;
    }
}