namespace BankingApp
{
    partial class frmAcct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.listAccounts = new System.Windows.Forms.ListBox();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.txtBal);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(300, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Account";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(35, 95);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(81, 30);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBal
            // 
            this.txtBal.Location = new System.Drawing.Point(179, 41);
            this.txtBal.Name = "txtBal";
            this.txtBal.Size = new System.Drawing.Size(100, 27);
            this.txtBal.TabIndex = 1;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(31, 44);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(113, 19);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Initial Balance:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWithdraw);
            this.groupBox2.Controls.Add(this.btnDeposit);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.lblAmount);
            this.groupBox2.Location = new System.Drawing.Point(18, 173);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(300, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Acount";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(179, 95);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(84, 30);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(35, 95);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(84, 30);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(179, 41);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 27);
            this.txtAmount.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(88, 44);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(72, 19);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount:";
            // 
            // listAccounts
            // 
            this.listAccounts.FormattingEnabled = true;
            this.listAccounts.ItemHeight = 19;
            this.listAccounts.Location = new System.Drawing.Point(325, 49);
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.Size = new System.Drawing.Size(211, 270);
            this.listAccounts.TabIndex = 2;
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Location = new System.Drawing.Point(325, 17);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(79, 19);
            this.lblAccounts.TabIndex = 3;
            this.lblAccounts.Text = "Accounts:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 3;
            // 
            // frmAcct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 339);
            this.Controls.Add(this.lblAccounts);
            this.Controls.Add(this.listAccounts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAcct";
            this.Text = "WildCards* Banking ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ListBox listAccounts;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

