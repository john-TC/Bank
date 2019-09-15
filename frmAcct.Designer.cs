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
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblSelectAmount = new System.Windows.Forms.Label();
            this.listAccounts = new System.Windows.Forms.ListBox();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.gbOverdraft = new System.Windows.Forms.GroupBox();
            this.btnDeleteOverdraft = new System.Windows.Forms.Button();
            this.btnCreateOverdraft = new System.Windows.Forms.Button();
            this.txtOverdraft = new System.Windows.Forms.TextBox();
            this.lblOverdraftAmount = new System.Windows.Forms.Label();
            this.gbErrors = new System.Windows.Forms.GroupBox();
            this.lblErrors = new System.Windows.Forms.Label();
            this.gbCreate.SuspendLayout();
            this.gbSelect.SuspendLayout();
            this.gbOverdraft.SuspendLayout();
            this.gbErrors.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreate
            // 
            this.gbCreate.Controls.Add(this.btnDelete);
            this.gbCreate.Controls.Add(this.btnCreate);
            this.gbCreate.Controls.Add(this.txtBal);
            this.gbCreate.Controls.Add(this.lblBalance);
            this.gbCreate.Location = new System.Drawing.Point(18, 17);
            this.gbCreate.Margin = new System.Windows.Forms.Padding(4);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Padding = new System.Windows.Forms.Padding(4);
            this.gbCreate.Size = new System.Drawing.Size(300, 146);
            this.gbCreate.TabIndex = 0;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "Create Account";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(179, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.btnWithdraw);
            this.gbSelect.Controls.Add(this.btnDeposit);
            this.gbSelect.Controls.Add(this.txtAmount);
            this.gbSelect.Controls.Add(this.lblSelectAmount);
            this.gbSelect.Location = new System.Drawing.Point(18, 171);
            this.gbSelect.Margin = new System.Windows.Forms.Padding(4);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Padding = new System.Windows.Forms.Padding(4);
            this.gbSelect.Size = new System.Drawing.Size(300, 146);
            this.gbSelect.TabIndex = 1;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select Account";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(179, 95);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(84, 30);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(35, 95);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(84, 30);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(179, 41);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 27);
            this.txtAmount.TabIndex = 1;
            // 
            // lblSelectAmount
            // 
            this.lblSelectAmount.AutoSize = true;
            this.lblSelectAmount.Location = new System.Drawing.Point(88, 44);
            this.lblSelectAmount.Name = "lblSelectAmount";
            this.lblSelectAmount.Size = new System.Drawing.Size(72, 19);
            this.lblSelectAmount.TabIndex = 0;
            this.lblSelectAmount.Text = "Amount:";
            // 
            // listAccounts
            // 
            this.listAccounts.FormattingEnabled = true;
            this.listAccounts.ItemHeight = 19;
            this.listAccounts.Location = new System.Drawing.Point(325, 49);
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.Size = new System.Drawing.Size(561, 555);
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
            // gbOverdraft
            // 
            this.gbOverdraft.Controls.Add(this.btnDeleteOverdraft);
            this.gbOverdraft.Controls.Add(this.btnCreateOverdraft);
            this.gbOverdraft.Controls.Add(this.txtOverdraft);
            this.gbOverdraft.Controls.Add(this.lblOverdraftAmount);
            this.gbOverdraft.Location = new System.Drawing.Point(18, 325);
            this.gbOverdraft.Margin = new System.Windows.Forms.Padding(4);
            this.gbOverdraft.Name = "gbOverdraft";
            this.gbOverdraft.Padding = new System.Windows.Forms.Padding(4);
            this.gbOverdraft.Size = new System.Drawing.Size(300, 146);
            this.gbOverdraft.TabIndex = 4;
            this.gbOverdraft.TabStop = false;
            this.gbOverdraft.Text = "Overdraft for Selected";
            // 
            // btnDeleteOverdraft
            // 
            this.btnDeleteOverdraft.Location = new System.Drawing.Point(179, 95);
            this.btnDeleteOverdraft.Name = "btnDeleteOverdraft";
            this.btnDeleteOverdraft.Size = new System.Drawing.Size(84, 30);
            this.btnDeleteOverdraft.TabIndex = 3;
            this.btnDeleteOverdraft.Text = "Delete";
            this.btnDeleteOverdraft.UseVisualStyleBackColor = true;
            this.btnDeleteOverdraft.Click += new System.EventHandler(this.BtnDeleteOverdraft_Click);
            // 
            // btnCreateOverdraft
            // 
            this.btnCreateOverdraft.Location = new System.Drawing.Point(35, 95);
            this.btnCreateOverdraft.Name = "btnCreateOverdraft";
            this.btnCreateOverdraft.Size = new System.Drawing.Size(84, 30);
            this.btnCreateOverdraft.TabIndex = 2;
            this.btnCreateOverdraft.Text = "Create";
            this.btnCreateOverdraft.UseVisualStyleBackColor = true;
            this.btnCreateOverdraft.Click += new System.EventHandler(this.btnCreateOverdraft_Click);
            // 
            // txtOverdraft
            // 
            this.txtOverdraft.Location = new System.Drawing.Point(179, 41);
            this.txtOverdraft.Name = "txtOverdraft";
            this.txtOverdraft.Size = new System.Drawing.Size(100, 27);
            this.txtOverdraft.TabIndex = 1;
            // 
            // lblOverdraftAmount
            // 
            this.lblOverdraftAmount.AutoSize = true;
            this.lblOverdraftAmount.Location = new System.Drawing.Point(88, 44);
            this.lblOverdraftAmount.Name = "lblOverdraftAmount";
            this.lblOverdraftAmount.Size = new System.Drawing.Size(72, 19);
            this.lblOverdraftAmount.TabIndex = 0;
            this.lblOverdraftAmount.Text = "Amount:";
            // 
            // gbErrors
            // 
            this.gbErrors.Controls.Add(this.lblErrors);
            this.gbErrors.Location = new System.Drawing.Point(18, 477);
            this.gbErrors.Name = "gbErrors";
            this.gbErrors.Size = new System.Drawing.Size(300, 130);
            this.gbErrors.TabIndex = 5;
            this.gbErrors.TabStop = false;
            this.gbErrors.Text = "Errors";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(6, 23);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(0, 19);
            this.lblErrors.TabIndex = 0;
            // 
            // frmAcct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 619);
            this.Controls.Add(this.gbErrors);
            this.Controls.Add(this.gbOverdraft);
            this.Controls.Add(this.lblAccounts);
            this.Controls.Add(this.listAccounts);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.gbCreate);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAcct";
            this.Text = "WildCards* Banking ";
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.gbOverdraft.ResumeLayout(false);
            this.gbOverdraft.PerformLayout();
            this.gbErrors.ResumeLayout(false);
            this.gbErrors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblSelectAmount;
        private System.Windows.Forms.ListBox listAccounts;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbOverdraft;
        private System.Windows.Forms.Button btnDeleteOverdraft;
        private System.Windows.Forms.Button btnCreateOverdraft;
        private System.Windows.Forms.TextBox txtOverdraft;
        private System.Windows.Forms.Label lblOverdraftAmount;
        private System.Windows.Forms.GroupBox gbErrors;
        private System.Windows.Forms.Label lblErrors;
    }
}

