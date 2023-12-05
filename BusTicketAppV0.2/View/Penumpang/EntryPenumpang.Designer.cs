namespace BusTicketAppV0._2.View
{
    partial class EntryPenumpang
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtNoKontak = new System.Windows.Forms.TextBox();
            this.txtNamaPenumpang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioLaki = new System.Windows.Forms.RadioButton();
            this.radioPr = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoKursi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(127, 206);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(218, 206);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtNoKontak
            // 
            this.txtNoKontak.Location = new System.Drawing.Point(127, 90);
            this.txtNoKontak.Name = "txtNoKontak";
            this.txtNoKontak.Size = new System.Drawing.Size(105, 20);
            this.txtNoKontak.TabIndex = 12;
            // 
            // txtNamaPenumpang
            // 
            this.txtNamaPenumpang.Location = new System.Drawing.Point(127, 49);
            this.txtNamaPenumpang.Name = "txtNamaPenumpang";
            this.txtNamaPenumpang.Size = new System.Drawing.Size(166, 20);
            this.txtNamaPenumpang.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "No Kontak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama";
            // 
            // radioLaki
            // 
            this.radioLaki.AutoSize = true;
            this.radioLaki.Location = new System.Drawing.Point(127, 130);
            this.radioLaki.Name = "radioLaki";
            this.radioLaki.Size = new System.Drawing.Size(68, 17);
            this.radioLaki.TabIndex = 16;
            this.radioLaki.TabStop = true;
            this.radioLaki.Text = "Laki-Laki";
            this.radioLaki.UseVisualStyleBackColor = true;
            // 
            // radioPr
            // 
            this.radioPr.AutoSize = true;
            this.radioPr.Location = new System.Drawing.Point(208, 130);
            this.radioPr.Name = "radioPr";
            this.radioPr.Size = new System.Drawing.Size(79, 17);
            this.radioPr.TabIndex = 17;
            this.radioPr.TabStop = true;
            this.radioPr.Text = "Perempuan";
            this.radioPr.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "No Kursi";
            // 
            // txtNoKursi
            // 
            this.txtNoKursi.Location = new System.Drawing.Point(127, 163);
            this.txtNoKursi.Name = "txtNoKursi";
            this.txtNoKursi.Size = new System.Drawing.Size(105, 20);
            this.txtNoKursi.TabIndex = 19;
            // 
            // EntryPenumpang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(346, 263);
            this.Controls.Add(this.txtNoKursi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioPr);
            this.Controls.Add(this.radioLaki);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNoKontak);
            this.Controls.Add(this.txtNamaPenumpang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryPenumpang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntryPenumpang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtNoKontak;
        private System.Windows.Forms.TextBox txtNamaPenumpang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioLaki;
        private System.Windows.Forms.RadioButton radioPr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoKursi;
    }
}