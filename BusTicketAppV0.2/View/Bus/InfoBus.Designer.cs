namespace BusTicketAppV0._2.View
{
    partial class InfoBus
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
            this.lvwBus = new System.Windows.Forms.ListView();
            this.btnHapusBus = new System.Windows.Forms.Button();
            this.btnUpdateBus = new System.Windows.Forms.Button();
            this.btnTambahBus = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnCariBus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCariBus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvwBus
            // 
            this.lvwBus.HideSelection = false;
            this.lvwBus.Location = new System.Drawing.Point(23, 60);
            this.lvwBus.Name = "lvwBus";
            this.lvwBus.Size = new System.Drawing.Size(345, 151);
            this.lvwBus.TabIndex = 0;
            this.lvwBus.UseCompatibleStateImageBehavior = false;
            // 
            // btnHapusBus
            // 
            this.btnHapusBus.Location = new System.Drawing.Point(298, 230);
            this.btnHapusBus.Name = "btnHapusBus";
            this.btnHapusBus.Size = new System.Drawing.Size(70, 27);
            this.btnHapusBus.TabIndex = 3;
            this.btnHapusBus.Text = "Hapus Bus";
            this.btnHapusBus.UseVisualStyleBackColor = true;
            this.btnHapusBus.Click += new System.EventHandler(this.btnHapusBus_Click);
            // 
            // btnUpdateBus
            // 
            this.btnUpdateBus.Location = new System.Drawing.Point(213, 230);
            this.btnUpdateBus.Name = "btnUpdateBus";
            this.btnUpdateBus.Size = new System.Drawing.Size(79, 27);
            this.btnUpdateBus.TabIndex = 4;
            this.btnUpdateBus.Text = "Update Bus";
            this.btnUpdateBus.UseVisualStyleBackColor = true;
            this.btnUpdateBus.Click += new System.EventHandler(this.btnUpdateBus_Click);
            // 
            // btnTambahBus
            // 
            this.btnTambahBus.Location = new System.Drawing.Point(129, 230);
            this.btnTambahBus.Name = "btnTambahBus";
            this.btnTambahBus.Size = new System.Drawing.Size(78, 27);
            this.btnTambahBus.TabIndex = 5;
            this.btnTambahBus.Text = "Tambah Bus";
            this.btnTambahBus.UseVisualStyleBackColor = true;
            this.btnTambahBus.Click += new System.EventHandler(this.btnTambahBus_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(23, 230);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(61, 27);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnCariBus
            // 
            this.btnCariBus.Location = new System.Drawing.Point(307, 29);
            this.btnCariBus.Name = "btnCariBus";
            this.btnCariBus.Size = new System.Drawing.Size(61, 23);
            this.btnCariBus.TabIndex = 7;
            this.btnCariBus.Text = "Cari";
            this.btnCariBus.UseVisualStyleBackColor = true;
            this.btnCariBus.Click += new System.EventHandler(this.btnCariBus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cari Jenis Bus";
            // 
            // txtCariBus
            // 
            this.txtCariBus.Location = new System.Drawing.Point(103, 31);
            this.txtCariBus.Name = "txtCariBus";
            this.txtCariBus.Size = new System.Drawing.Size(198, 20);
            this.txtCariBus.TabIndex = 9;
            // 
            // InfoBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 284);
            this.Controls.Add(this.txtCariBus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCariBus);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnTambahBus);
            this.Controls.Add(this.btnUpdateBus);
            this.Controls.Add(this.btnHapusBus);
            this.Controls.Add(this.lvwBus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoBus";
            this.Load += new System.EventHandler(this.InfoBus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwBus;
        private System.Windows.Forms.Button btnHapusBus;
        private System.Windows.Forms.Button btnUpdateBus;
        private System.Windows.Forms.Button btnTambahBus;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnCariBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCariBus;
    }
}