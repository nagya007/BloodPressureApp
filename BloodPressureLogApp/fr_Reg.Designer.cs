namespace BloodPressureLogApp
{
    partial class fr_Reg
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
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_PhoneNumber = new System.Windows.Forms.TextBox();
            this.tb_Addres = new System.Windows.Forms.TextBox();
            this.bt_Back = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.dtp_BirhDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefonszám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cím";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Születésnap";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(115, 41);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(200, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_PhoneNumber
            // 
            this.tb_PhoneNumber.Location = new System.Drawing.Point(115, 122);
            this.tb_PhoneNumber.Name = "tb_PhoneNumber";
            this.tb_PhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.tb_PhoneNumber.TabIndex = 3;
            // 
            // tb_Addres
            // 
            this.tb_Addres.Location = new System.Drawing.Point(115, 82);
            this.tb_Addres.Name = "tb_Addres";
            this.tb_Addres.Size = new System.Drawing.Size(200, 20);
            this.tb_Addres.TabIndex = 2;
            // 
            // bt_Back
            // 
            this.bt_Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Back.Location = new System.Drawing.Point(43, 251);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(75, 23);
            this.bt_Back.TabIndex = 6;
            this.bt_Back.Text = "Vissza";
            this.bt_Back.UseVisualStyleBackColor = true;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Save.Location = new System.Drawing.Point(202, 251);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 5;
            this.bt_Save.Text = "Mentés";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // dtp_BirhDate
            // 
            this.dtp_BirhDate.Location = new System.Drawing.Point(115, 167);
            this.dtp_BirhDate.Name = "dtp_BirhDate";
            this.dtp_BirhDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_BirhDate.TabIndex = 4;
            // 
            // fr_Reg
            // 
            this.AcceptButton = this.bt_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 310);
            this.Controls.Add(this.dtp_BirhDate);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.tb_Addres);
            this.Controls.Add(this.tb_PhoneNumber);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fr_Reg";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_PhoneNumber;
        private System.Windows.Forms.TextBox tb_Addres;
        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.DateTimePicker dtp_BirhDate;
    }
}