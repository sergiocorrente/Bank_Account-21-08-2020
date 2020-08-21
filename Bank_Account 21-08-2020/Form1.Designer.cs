namespace Bank_Account_21_08_2020
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.ballanceButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.accountIdTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(214, 44);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 1;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(214, 103);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Widraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            // 
            // ballanceButton
            // 
            this.ballanceButton.Location = new System.Drawing.Point(214, 168);
            this.ballanceButton.Name = "ballanceButton";
            this.ballanceButton.Size = new System.Drawing.Size(75, 23);
            this.ballanceButton.TabIndex = 3;
            this.ballanceButton.Text = "Ballance";
            this.ballanceButton.UseVisualStyleBackColor = true;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(32, 205);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // accountIdTextBox
            // 
            this.accountIdTextBox.Location = new System.Drawing.Point(32, 168);
            this.accountIdTextBox.Name = "accountIdTextBox";
            this.accountIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountIdTextBox.TabIndex = 5;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(32, 146);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(49, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "              ";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(214, 238);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(214, 23);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create  account";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.accountIdTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.ballanceButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button ballanceButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox accountIdTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button createButton;
    }
}

