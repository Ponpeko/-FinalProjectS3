namespace BusTicketAppV0._2.View
{
    partial class EntryBus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaBus = new System.Windows.Forms.TextBox();
            this.txtJenisBus = new System.Windows.Forms.TextBox();
            this.cmbKapasitas = new System.Windows.Forms.ComboBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Bus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Bus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kapasitas";
            // 
            // txtNamaBus
            // 
            this.txtNamaBus.Location = new System.Drawing.Point(108, 67);
            this.txtNamaBus.Name = "txtNamaBus";
            this.txtNamaBus.Size = new System.Drawing.Size(166, 20);
            this.txtNamaBus.TabIndex = 3;
            // 
            // txtJenisBus
            // 
            this.txtJenisBus.Location = new System.Drawing.Point(108, 104);
            this.txtJenisBus.Name = "txtJenisBus";
            this.txtJenisBus.Size = new System.Drawing.Size(105, 20);
            this.txtJenisBus.TabIndex = 4;
            // 
            // cmbKapasitas
            // 
            this.cmbKapasitas.FormattingEnabled = true;
            this.cmbKapasitas.Items.AddRange(new object[] {
            "30",
            "40",
            "50",
            "60"});
            this.cmbKapasitas.Location = new System.Drawing.Point(108, 141);
            this.cmbKapasitas.Name = "cmbKapasitas";
            this.cmbKapasitas.Size = new System.Drawing.Size(54, 21);
            this.cmbKapasitas.TabIndex = 5;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(199, 200);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(118, 200);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // EntryBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 247);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cmbKapasitas);
            this.Controls.Add(this.txtJenisBus);
            this.Controls.Add(this.txtNamaBus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntryBus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaBus;
        private System.Windows.Forms.TextBox txtJenisBus;
        private System.Windows.Forms.ComboBox cmbKapasitas;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
    }
}