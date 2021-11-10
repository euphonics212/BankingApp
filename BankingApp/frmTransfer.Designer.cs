namespace BankingApp
{
    partial class frmTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfer));
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.btTranserCancel = new System.Windows.Forms.Button();
            this.lbChoosePayee = new System.Windows.Forms.Label();
            this.cmbBoxPayee = new System.Windows.Forms.ComboBox();
            this.btnSelectPayee = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLogo
            // 
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.Location = new System.Drawing.Point(3, 2);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(300, 300);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainLogo.TabIndex = 1;
            this.mainLogo.TabStop = false;
            // 
            // btTranserCancel
            // 
            this.btTranserCancel.BackColor = System.Drawing.Color.Cornsilk;
            this.btTranserCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTranserCancel.FlatAppearance.BorderSize = 0;
            this.btTranserCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btTranserCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btTranserCancel.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTranserCancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btTranserCancel.Location = new System.Drawing.Point(12, 387);
            this.btTranserCancel.Name = "btTranserCancel";
            this.btTranserCancel.Size = new System.Drawing.Size(158, 43);
            this.btTranserCancel.TabIndex = 2;
            this.btTranserCancel.Text = "<< Back";
            this.btTranserCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTranserCancel.UseVisualStyleBackColor = false;
            this.btTranserCancel.Click += new System.EventHandler(this.btTranserCancel_Click);
            // 
            // lbChoosePayee
            // 
            this.lbChoosePayee.BackColor = System.Drawing.Color.Transparent;
            this.lbChoosePayee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChoosePayee.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbChoosePayee.Location = new System.Drawing.Point(360, 66);
            this.lbChoosePayee.Name = "lbChoosePayee";
            this.lbChoosePayee.Size = new System.Drawing.Size(158, 35);
            this.lbChoosePayee.TabIndex = 24;
            this.lbChoosePayee.Text = "Select Payee";
            this.lbChoosePayee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxPayee
            // 
            this.cmbBoxPayee.BackColor = System.Drawing.Color.Cornsilk;
            this.cmbBoxPayee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPayee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxPayee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxPayee.FormattingEnabled = true;
            this.cmbBoxPayee.Location = new System.Drawing.Point(380, 117);
            this.cmbBoxPayee.Name = "cmbBoxPayee";
            this.cmbBoxPayee.Size = new System.Drawing.Size(158, 28);
            this.cmbBoxPayee.TabIndex = 25;
            // 
            // btnSelectPayee
            // 
            this.btnSelectPayee.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSelectPayee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPayee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelectPayee.Location = new System.Drawing.Point(380, 177);
            this.btnSelectPayee.Name = "btnSelectPayee";
            this.btnSelectPayee.Size = new System.Drawing.Size(158, 43);
            this.btnSelectPayee.TabIndex = 26;
            this.btnSelectPayee.Text = "Select Payee";
            this.btnSelectPayee.UseVisualStyleBackColor = false;
            this.btnSelectPayee.Click += new System.EventHandler(this.btnSelectPayee_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Gray;
            this.btnHelp.Location = new System.Drawing.Point(3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(33, 29);
            this.btnHelp.TabIndex = 31;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankingApp.Properties.Resources.dudeson_background;
            this.ClientSize = new System.Drawing.Size(593, 442);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSelectPayee);
            this.Controls.Add(this.cmbBoxPayee);
            this.Controls.Add(this.lbChoosePayee);
            this.Controls.Add(this.btTranserCancel);
            this.Controls.Add(this.mainLogo);
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Money";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainLogo;
        private System.Windows.Forms.Button btTranserCancel;
        private System.Windows.Forms.Label lbChoosePayee;
        private System.Windows.Forms.ComboBox cmbBoxPayee;
        private System.Windows.Forms.Button btnSelectPayee;
        private System.Windows.Forms.Button btnHelp;
    }
}