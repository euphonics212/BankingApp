namespace BankingApp
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.btnStatemnet = new System.Windows.Forms.Button();
            this.lbBalance = new System.Windows.Forms.Label();
            this.textBoxMainBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.formMainTimer = new System.Windows.Forms.Timer(this.components);
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.Location = new System.Drawing.Point(426, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 43);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Cornsilk;
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTransfer.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTransfer.Location = new System.Drawing.Point(12, 334);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(158, 43);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Transfer Money";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.BackColor = System.Drawing.Color.Cornsilk;
            this.btnViewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAccount.FlatAppearance.BorderSize = 0;
            this.btnViewAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnViewAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewAccount.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAccount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnViewAccount.Location = new System.Drawing.Point(426, 334);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(158, 43);
            this.btnViewAccount.TabIndex = 1;
            this.btnViewAccount.Text = "View Account Details";
            this.btnViewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAccount.UseVisualStyleBackColor = false;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // mainLogo
            // 
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.Location = new System.Drawing.Point(152, -300);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(300, 300);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainLogo.TabIndex = 0;
            this.mainLogo.TabStop = false;
            // 
            // btnStatemnet
            // 
            this.btnStatemnet.BackColor = System.Drawing.Color.Cornsilk;
            this.btnStatemnet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatemnet.FlatAppearance.BorderSize = 0;
            this.btnStatemnet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnStatemnet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStatemnet.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatemnet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStatemnet.Location = new System.Drawing.Point(12, 387);
            this.btnStatemnet.Name = "btnStatemnet";
            this.btnStatemnet.Size = new System.Drawing.Size(158, 43);
            this.btnStatemnet.TabIndex = 1;
            this.btnStatemnet.Text = "ViewStatement";
            this.btnStatemnet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatemnet.UseVisualStyleBackColor = false;
            this.btnStatemnet.Click += new System.EventHandler(this.btnStatemnet_Click);
            // 
            // lbBalance
            // 
            this.lbBalance.BackColor = System.Drawing.Color.Transparent;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbBalance.Location = new System.Drawing.Point(240, 242);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(126, 35);
            this.lbBalance.TabIndex = 24;
            this.lbBalance.Text = "Balance ";
            this.lbBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMainBalance
            // 
            this.textBoxMainBalance.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxMainBalance.Enabled = false;
            this.textBoxMainBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMainBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMainBalance.Location = new System.Drawing.Point(185, 280);
            this.textBoxMainBalance.Name = "textBoxMainBalance";
            this.textBoxMainBalance.ReadOnly = true;
            this.textBoxMainBalance.Size = new System.Drawing.Size(226, 31);
            this.textBoxMainBalance.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(162, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "€";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formMainTimer
            // 
            this.formMainTimer.Interval = 1;
            this.formMainTimer.Tick += new System.EventHandler(this.timerAnimateMainLogo_Tick);
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblFullName.Location = new System.Drawing.Point(419, 19);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(165, 35);
            this.lblFullName.TabIndex = 27;
            this.lblFullName.Text = "...";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Gray;
            this.btnHelp.Location = new System.Drawing.Point(3, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(33, 29);
            this.btnHelp.TabIndex = 31;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankingApp.Properties.Resources.dudeson_background;
            this.ClientSize = new System.Drawing.Size(593, 442);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMainBalance);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.btnViewAccount);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStatemnet);
            this.Controls.Add(this.mainLogo);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.PictureBox mainLogo;
        private System.Windows.Forms.Button btnStatemnet;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxMainBalance;
        private System.Windows.Forms.Timer formMainTimer;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnHelp;
    }
}