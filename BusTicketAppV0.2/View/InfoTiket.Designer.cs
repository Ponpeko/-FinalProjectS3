namespace BusTicketAppV0._2.View
{
    partial class InfoTiket
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
            this.lvwRute = new System.Windows.Forms.ListView();
            this.lvwBus = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lvwPenumpang = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.txtCariBus = new System.Windows.Forms.TextBox();
            this.btnCariBus = new System.Windows.Forms.Button();
            this.txtCariRute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCariRute = new System.Windows.Forms.Button();
            this.txtCariPenumpang = new System.Windows.Forms.TextBox();
            this.btnCariPenumpang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwRute
            // 
            this.lvwRute.HideSelection = false;
            this.lvwRute.Location = new System.Drawing.Point(28, 52);
            this.lvwRute.Name = "lvwRute";
            this.lvwRute.Size = new System.Drawing.Size(552, 151);
            this.lvwRute.TabIndex = 11;
            this.lvwRute.UseCompatibleStateImageBehavior = false;
            // 
            // lvwBus
            // 
            this.lvwBus.HideSelection = false;
            this.lvwBus.Location = new System.Drawing.Point(608, 52);
            this.lvwBus.Name = "lvwBus";
            this.lvwBus.Size = new System.Drawing.Size(345, 151);
            this.lvwBus.TabIndex = 13;
            this.lvwBus.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cari Jenis Bus";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lvwPenumpang
            // 
            this.lvwPenumpang.HideSelection = false;
            this.lvwPenumpang.Location = new System.Drawing.Point(28, 265);
            this.lvwPenumpang.Name = "lvwPenumpang";
            this.lvwPenumpang.Size = new System.Drawing.Size(404, 165);
            this.lvwPenumpang.TabIndex = 19;
            this.lvwPenumpang.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cari Nama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(28, 463);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(84, 29);
            this.btnKembali.TabIndex = 21;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCariBus
            // 
            this.txtCariBus.Location = new System.Drawing.Point(689, 26);
            this.txtCariBus.Name = "txtCariBus";
            this.txtCariBus.Size = new System.Drawing.Size(198, 20);
            this.txtCariBus.TabIndex = 23;
            // 
            // btnCariBus
            // 
            this.btnCariBus.Location = new System.Drawing.Point(893, 24);
            this.btnCariBus.Name = "btnCariBus";
            this.btnCariBus.Size = new System.Drawing.Size(61, 23);
            this.btnCariBus.TabIndex = 22;
            this.btnCariBus.Text = "Cari";
            this.btnCariBus.UseVisualStyleBackColor = true;
            // 
            // txtCariRute
            // 
            this.txtCariRute.Location = new System.Drawing.Point(124, 26);
            this.txtCariRute.Name = "txtCariRute";
            this.txtCariRute.Size = new System.Drawing.Size(389, 20);
            this.txtCariRute.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cari Kota Tujuan";
            // 
            // btnCariRute
            // 
            this.btnCariRute.Location = new System.Drawing.Point(519, 24);
            this.btnCariRute.Name = "btnCariRute";
            this.btnCariRute.Size = new System.Drawing.Size(61, 23);
            this.btnCariRute.TabIndex = 24;
            this.btnCariRute.Text = "Cari";
            this.btnCariRute.UseVisualStyleBackColor = true;
            // 
            // txtCariPenumpang
            // 
            this.txtCariPenumpang.Location = new System.Drawing.Point(94, 238);
            this.txtCariPenumpang.Name = "txtCariPenumpang";
            this.txtCariPenumpang.Size = new System.Drawing.Size(272, 20);
            this.txtCariPenumpang.TabIndex = 28;
            // 
            // btnCariPenumpang
            // 
            this.btnCariPenumpang.Location = new System.Drawing.Point(372, 236);
            this.btnCariPenumpang.Name = "btnCariPenumpang";
            this.btnCariPenumpang.Size = new System.Drawing.Size(61, 23);
            this.btnCariPenumpang.TabIndex = 27;
            this.btnCariPenumpang.Text = "Cari";
            this.btnCariPenumpang.UseVisualStyleBackColor = true;
            // 
            // InfoTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.txtCariPenumpang);
            this.Controls.Add(this.btnCariPenumpang);
            this.Controls.Add(this.txtCariRute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCariRute);
            this.Controls.Add(this.txtCariBus);
            this.Controls.Add(this.btnCariBus);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvwPenumpang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwBus);
            this.Controls.Add(this.lvwRute);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoTiket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoTiket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwRute;
        private System.Windows.Forms.ListView lvwBus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwPenumpang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.TextBox txtCariBus;
        private System.Windows.Forms.Button btnCariBus;
        private System.Windows.Forms.TextBox txtCariRute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCariRute;
        private System.Windows.Forms.TextBox txtCariPenumpang;
        private System.Windows.Forms.Button btnCariPenumpang;
    }
}