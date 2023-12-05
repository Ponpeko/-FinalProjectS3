namespace BusTicketAppV0._2.View
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
            this.btnRute = new System.Windows.Forms.Button();
            this.btnBus = new System.Windows.Forms.Button();
            this.btnPenumpang = new System.Windows.Forms.Button();
            this.btnTiket = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRute
            // 
            this.btnRute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRute.Location = new System.Drawing.Point(73, 101);
            this.btnRute.Name = "btnRute";
            this.btnRute.Size = new System.Drawing.Size(203, 41);
            this.btnRute.TabIndex = 1;
            this.btnRute.Text = "Rute";
            this.btnRute.UseVisualStyleBackColor = true;
            this.btnRute.Click += new System.EventHandler(this.btnRute_Click);
            // 
            // btnBus
            // 
            this.btnBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBus.Location = new System.Drawing.Point(73, 159);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(203, 41);
            this.btnBus.TabIndex = 2;
            this.btnBus.Text = "Bus";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // btnPenumpang
            // 
            this.btnPenumpang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenumpang.Location = new System.Drawing.Point(73, 220);
            this.btnPenumpang.Name = "btnPenumpang";
            this.btnPenumpang.Size = new System.Drawing.Size(203, 41);
            this.btnPenumpang.TabIndex = 3;
            this.btnPenumpang.Text = "Penumpang";
            this.btnPenumpang.UseVisualStyleBackColor = true;
            this.btnPenumpang.Click += new System.EventHandler(this.btnPenumpang_Click);
            // 
            // btnTiket
            // 
            this.btnTiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiket.Location = new System.Drawing.Point(73, 281);
            this.btnTiket.Name = "btnTiket";
            this.btnTiket.Size = new System.Drawing.Size(203, 41);
            this.btnTiket.TabIndex = 4;
            this.btnTiket.Text = "Tiket";
            this.btnTiket.UseVisualStyleBackColor = true;
            this.btnTiket.Click += new System.EventHandler(this.btnTiket_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(26, 402);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTiket);
            this.Controls.Add(this.btnPenumpang);
            this.Controls.Add(this.btnBus);
            this.Controls.Add(this.btnRute);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRute;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Button btnPenumpang;
        private System.Windows.Forms.Button btnTiket;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}