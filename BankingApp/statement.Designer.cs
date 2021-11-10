namespace BankingApp
{
    partial class frmStatement
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
            this.dgTransactions = new System.Windows.Forms.DataGridView();
            this.lbStatement = new System.Windows.Forms.Label();
            this.btnPayeeBack = new System.Windows.Forms.Button();
            this.lbAccountNum = new System.Windows.Forms.Label();
            this.lbStatementName = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTransactions
            // 
            this.dgTransactions.AllowUserToAddRows = false;
            this.dgTransactions.AllowUserToDeleteRows = false;
            this.dgTransactions.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactions.Location = new System.Drawing.Point(30, 65);
            this.dgTransactions.Name = "dgTransactions";
            this.dgTransactions.ReadOnly = true;
            this.dgTransactions.Size = new System.Drawing.Size(531, 307);
            this.dgTransactions.TabIndex = 0;
            // 
            // lbStatement
            // 
            this.lbStatement.BackColor = System.Drawing.Color.Transparent;
            this.lbStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatement.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbStatement.Location = new System.Drawing.Point(25, 27);
            this.lbStatement.Name = "lbStatement";
            this.lbStatement.Size = new System.Drawing.Size(156, 35);
            this.lbStatement.TabIndex = 24;
            this.lbStatement.Text = "Statement";
            this.lbStatement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPayeeBack
            // 
            this.btnPayeeBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnPayeeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayeeBack.FlatAppearance.BorderSize = 0;
            this.btnPayeeBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnPayeeBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPayeeBack.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayeeBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPayeeBack.Location = new System.Drawing.Point(30, 387);
            this.btnPayeeBack.Name = "btnPayeeBack";
            this.btnPayeeBack.Size = new System.Drawing.Size(158, 43);
            this.btnPayeeBack.TabIndex = 28;
            this.btnPayeeBack.Text = "<<Back";
            this.btnPayeeBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayeeBack.UseVisualStyleBackColor = false;
            this.btnPayeeBack.Click += new System.EventHandler(this.btnPayeeBack_Click);
            // 
            // lbAccountNum
            // 
            this.lbAccountNum.BackColor = System.Drawing.Color.Transparent;
            this.lbAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountNum.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbAccountNum.Location = new System.Drawing.Point(173, 27);
            this.lbAccountNum.Name = "lbAccountNum";
            this.lbAccountNum.Size = new System.Drawing.Size(156, 35);
            this.lbAccountNum.TabIndex = 24;
            this.lbAccountNum.Text = "Acc Num: ";
            this.lbAccountNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStatementName
            // 
            this.lbStatementName.BackColor = System.Drawing.Color.Transparent;
            this.lbStatementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatementName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbStatementName.Location = new System.Drawing.Point(405, 27);
            this.lbStatementName.Name = "lbStatementName";
            this.lbStatementName.Size = new System.Drawing.Size(156, 35);
            this.lbStatementName.TabIndex = 24;
            this.lbStatementName.Text = "Name";
            this.lbStatementName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Gray;
            this.btnHelp.Location = new System.Drawing.Point(1, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(33, 29);
            this.btnHelp.TabIndex = 29;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankingApp.Properties.Resources.dudeson_background;
            this.ClientSize = new System.Drawing.Size(593, 442);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnPayeeBack);
            this.Controls.Add(this.lbStatementName);
            this.Controls.Add(this.lbAccountNum);
            this.Controls.Add(this.lbStatement);
            this.Controls.Add(this.dgTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statement";
            this.Load += new System.EventHandler(this.frmStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbStatement;
        private System.Windows.Forms.Button btnPayeeBack;
        private System.Windows.Forms.Label lbAccountNum;
        private System.Windows.Forms.Label lbStatementName;
        public System.Windows.Forms.DataGridView dgTransactions;
        private System.Windows.Forms.Button btnHelp;
    }
}