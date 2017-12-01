namespace BloodPressureLogApp
{
    partial class AddUpdateRemove
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
            this.combobox_Date = new System.Windows.Forms.ComboBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textbox_Sys = new System.Windows.Forms.TextBox();
            this.textbox_Dia = new System.Windows.Forms.TextBox();
            this.textbox_Pulse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobox_Date
            // 
            this.combobox_Date.FormatString = "f";
            this.combobox_Date.FormattingEnabled = true;
            this.combobox_Date.Location = new System.Drawing.Point(98, 40);
            this.combobox_Date.Name = "combobox_Date";
            this.combobox_Date.Size = new System.Drawing.Size(178, 21);
            this.combobox_Date.TabIndex = 0;
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(17, 241);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 1;
            this.button_Back.Text = "Vissza";
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(109, 241);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textbox_Sys
            // 
            this.textbox_Sys.Location = new System.Drawing.Point(98, 83);
            this.textbox_Sys.Name = "textbox_Sys";
            this.textbox_Sys.Size = new System.Drawing.Size(178, 20);
            this.textbox_Sys.TabIndex = 4;
            // 
            // textbox_Dia
            // 
            this.textbox_Dia.Location = new System.Drawing.Point(98, 132);
            this.textbox_Dia.Name = "textbox_Dia";
            this.textbox_Dia.Size = new System.Drawing.Size(178, 20);
            this.textbox_Dia.TabIndex = 5;
            // 
            // textbox_Pulse
            // 
            this.textbox_Pulse.Location = new System.Drawing.Point(98, 180);
            this.textbox_Pulse.Name = "textbox_Pulse";
            this.textbox_Pulse.Size = new System.Drawing.Size(178, 20);
            this.textbox_Pulse.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Eredmény ideje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sys";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pulse";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(190, 241);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 12;
            this.button_Update.Text = "Frissítés";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(271, 241);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 13;
            this.button_Remove.Text = "Törlés";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // AddUpdateRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 329);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_Pulse);
            this.Controls.Add(this.textbox_Dia);
            this.Controls.Add(this.textbox_Sys);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.combobox_Date);
            this.Name = "AddUpdateRemove";
            this.Text = "S";
            this.Load += new System.EventHandler(this.AddUpdateRemove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_Date;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textbox_Sys;
        private System.Windows.Forms.TextBox textbox_Dia;
        private System.Windows.Forms.TextBox textbox_Pulse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Remove;
    }
}