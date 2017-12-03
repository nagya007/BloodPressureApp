namespace BloodPressureLogApp
{
    partial class Fr_belep
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
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.bt_Reg = new System.Windows.Forms.Button();
            this.bt_LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó:";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(97, 24);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(168, 20);
            this.tb_UserName.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(97, 61);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(168, 20);
            this.tb_Password.TabIndex = 3;
            // 
            // bt_Reg
            // 
            this.bt_Reg.Location = new System.Drawing.Point(31, 145);
            this.bt_Reg.Name = "bt_Reg";
            this.bt_Reg.Size = new System.Drawing.Size(75, 23);
            this.bt_Reg.TabIndex = 4;
            this.bt_Reg.Text = "Regisztráció";
            this.bt_Reg.UseVisualStyleBackColor = true;
            this.bt_Reg.Click += new System.EventHandler(this.bt_Reg_Click);
            // 
            // bt_LogIn
            // 
            this.bt_LogIn.Location = new System.Drawing.Point(190, 145);
            this.bt_LogIn.Name = "bt_LogIn";
            this.bt_LogIn.Size = new System.Drawing.Size(75, 23);
            this.bt_LogIn.TabIndex = 5;
            this.bt_LogIn.Text = "Belépés";
            this.bt_LogIn.UseVisualStyleBackColor = true;
            this.bt_LogIn.Click += new System.EventHandler(this.bt_LogIn_Click);
            // 
            // Fr_belep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 217);
            this.Controls.Add(this.bt_LogIn);
            this.Controls.Add(this.bt_Reg);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fr_belep";
            this.Text = "Belépés";
            this.Load += new System.EventHandler(this.Fr_belep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button bt_Reg;
        private System.Windows.Forms.Button bt_LogIn;
    }
}

