namespace Account_Simulation_EC
{
    partial class bankaccountSimulator
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
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balancecallabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.withdrawLabel = new System.Windows.Forms.Label();
            this.depamountLabel = new System.Windows.Forms.Label();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.withdrawamountLabel = new System.Windows.Forms.Label();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawlbutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(308, 86);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(96, 27);
            this.balanceLabel.TabIndex = 0;
            this.balanceLabel.Text = "Balance: ";
            // 
            // balancecallabel
            // 
            this.balancecallabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.balancecallabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balancecallabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancecallabel.Location = new System.Drawing.Point(399, 86);
            this.balancecallabel.Name = "balancecallabel";
            this.balancecallabel.Size = new System.Drawing.Size(139, 31);
            this.balancecallabel.TabIndex = 1;
            this.balancecallabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.Location = new System.Drawing.Point(183, 135);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(167, 27);
            this.depositLabel.TabIndex = 2;
            this.depositLabel.Text = "Make a Deposit ";
            // 
            // withdrawLabel
            // 
            this.withdrawLabel.AutoSize = true;
            this.withdrawLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawLabel.Location = new System.Drawing.Point(459, 135);
            this.withdrawLabel.Name = "withdrawLabel";
            this.withdrawLabel.Size = new System.Drawing.Size(185, 27);
            this.withdrawLabel.TabIndex = 3;
            this.withdrawLabel.Text = "Make a Withdrawl";
            // 
            // depamountLabel
            // 
            this.depamountLabel.AutoSize = true;
            this.depamountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depamountLabel.Location = new System.Drawing.Point(161, 168);
            this.depamountLabel.Name = "depamountLabel";
            this.depamountLabel.Size = new System.Drawing.Size(94, 27);
            this.depamountLabel.TabIndex = 4;
            this.depamountLabel.Text = "Amount:";
            // 
            // depositTextBox
            // 
            this.depositTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositTextBox.Location = new System.Drawing.Point(261, 165);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(106, 34);
            this.depositTextBox.TabIndex = 5;
            this.depositTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // withdrawamountLabel
            // 
            this.withdrawamountLabel.AutoSize = true;
            this.withdrawamountLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawamountLabel.Location = new System.Drawing.Point(459, 168);
            this.withdrawamountLabel.Name = "withdrawamountLabel";
            this.withdrawamountLabel.Size = new System.Drawing.Size(100, 27);
            this.withdrawamountLabel.TabIndex = 6;
            this.withdrawamountLabel.Text = "Amount: ";
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawTextBox.Location = new System.Drawing.Point(565, 168);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(114, 34);
            this.withdrawTextBox.TabIndex = 7;
            this.withdrawTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.SystemColors.Control;
            this.depositButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(188, 202);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(155, 37);
            this.depositButton.TabIndex = 8;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawlbutton
            // 
            this.withdrawlbutton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawlbutton.Location = new System.Drawing.Point(475, 208);
            this.withdrawlbutton.Name = "withdrawlbutton";
            this.withdrawlbutton.Size = new System.Drawing.Size(169, 39);
            this.withdrawlbutton.TabIndex = 9;
            this.withdrawlbutton.Text = "Withdrawl";
            this.withdrawlbutton.UseVisualStyleBackColor = true;
            this.withdrawlbutton.Click += new System.EventHandler(this.withdrawlbutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(335, 271);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 32);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bankaccountSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 343);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.withdrawlbutton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.withdrawTextBox);
            this.Controls.Add(this.withdrawamountLabel);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.depamountLabel);
            this.Controls.Add(this.withdrawLabel);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.balancecallabel);
            this.Controls.Add(this.balanceLabel);
            this.Name = "bankaccountSimulator";
            this.Text = "Bank Account Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label balancecallabel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label withdrawLabel;
        private System.Windows.Forms.Label depamountLabel;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label withdrawamountLabel;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawlbutton;
        private System.Windows.Forms.Button exitButton;
    }
}

