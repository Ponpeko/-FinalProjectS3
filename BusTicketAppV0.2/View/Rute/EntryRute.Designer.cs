namespace BusTicketAppV0._2.View
{
    partial class EntryRute
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
            this.txtKotaTujuan = new System.Windows.Forms.TextBox();
            this.txtKotaAsal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWktKeberangkatan = new System.Windows.Forms.TextBox();
            this.txtWktKedatangan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(78, 199);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(200, 199);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtKotaTujuan
            // 
            this.txtKotaTujuan.Location = new System.Drawing.Point(151, 78);
            this.txtKotaTujuan.Name = "txtKotaTujuan";
            this.txtKotaTujuan.Size = new System.Drawing.Size(105, 20);
            this.txtKotaTujuan.TabIndex = 12;
            // 
            // txtKotaAsal
            // 
            this.txtKotaAsal.Location = new System.Drawing.Point(151, 41);
            this.txtKotaAsal.Name = "txtKotaAsal";
            this.txtKotaAsal.Size = new System.Drawing.Size(105, 20);
            this.txtKotaAsal.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Waktu Keberangkatan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kota Tujuan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kota Asal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Waktu Kedatangan";
            // 
            // txtWktKeberangkatan
            // 
            this.txtWktKeberangkatan.Location = new System.Drawing.Point(49, 151);
            this.txtWktKeberangkatan.Name = "txtWktKeberangkatan";
            this.txtWktKeberangkatan.Size = new System.Drawing.Size(105, 20);
            this.txtWktKeberangkatan.TabIndex = 17;
            // 
            // txtWktKedatangan
            // 
            this.txtWktKedatangan.Location = new System.Drawing.Point(200, 151);
            this.txtWktKedatangan.Name = "txtWktKedatangan";
            this.txtWktKedatangan.Size = new System.Drawing.Size(105, 20);
            this.txtWktKedatangan.TabIndex = 18;
            // 
            // EntryRute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 258);
            this.Controls.Add(this.txtWktKedatangan);
            this.Controls.Add(this.txtWktKeberangkatan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtKotaTujuan);
            this.Controls.Add(this.txtKotaAsal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryRute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntryRute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtKotaTujuan;
        private System.Windows.Forms.TextBox txtKotaAsal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWktKeberangkatan;
        private System.Windows.Forms.TextBox txtWktKedatangan;
    }
}