namespace BloodPressureLogApp
{
    partial class Delet
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
            this.textbox_Sys = new System.Windows.Forms.TextBox();
            this.textbox_Dia = new System.Windows.Forms.TextBox();
            this.textbox_Pulse = new System.Windows.Forms.TextBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Delet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combobox_Date
            // 
            this.combobox_Date.FormattingEnabled = true;
            this.combobox_Date.Location = new System.Drawing.Point(141, 26);
            this.combobox_Date.Name = "combobox_Date";
            this.combobox_Date.Size = new System.Drawing.Size(173, 21);
            this.combobox_Date.TabIndex = 0;
            this.combobox_Date.SelectedIndexChanged += new System.EventHandler(this.combobox_Date_SelectedIndexChanged);
            // 
            // textbox_Sys
            // 
            this.textbox_Sys.Enabled = false;
            this.textbox_Sys.Location = new System.Drawing.Point(141, 64);
            this.textbox_Sys.Name = "textbox_Sys";
            this.textbox_Sys.Size = new System.Drawing.Size(173, 20);
            this.textbox_Sys.TabIndex = 1;
            // 
            // textbox_Dia
            // 
            this.textbox_Dia.Enabled = false;
            this.textbox_Dia.Location = new System.Drawing.Point(141, 105);
            this.textbox_Dia.Name = "textbox_Dia";
            this.textbox_Dia.Size = new System.Drawing.Size(173, 20);
            this.textbox_Dia.TabIndex = 2;
            // 
            // textbox_Pulse
            // 
            this.textbox_Pulse.Enabled = false;
            this.textbox_Pulse.Location = new System.Drawing.Point(141, 145);
            this.textbox_Pulse.Name = "textbox_Pulse";
            this.textbox_Pulse.Size = new System.Drawing.Size(173, 20);
            this.textbox_Pulse.TabIndex = 3;
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(54, 207);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 4;
            this.button_Back.Text = "Vissza";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Delet
            // 
            this.button_Delet.Location = new System.Drawing.Point(239, 207);
            this.button_Delet.Name = "button_Delet";
            this.button_Delet.Size = new System.Drawing.Size(75, 23);
            this.button_Delet.TabIndex = 5;
            this.button_Delet.Text = "Törlés";
            this.button_Delet.UseVisualStyleBackColor = true;
            this.button_Delet.Click += new System.EventHandler(this.button_Delet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Válassz dátumot:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sys:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pulse: ";
            // 
            // Delet
            // 
            this.AcceptButton = this.button_Delet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Delet);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.textbox_Pulse);
            this.Controls.Add(this.textbox_Dia);
            this.Controls.Add(this.textbox_Sys);
            this.Controls.Add(this.combobox_Date);
            this.Name = "Delet";
            this.Text = "Törlés";
            this.Load += new System.EventHandler(this.Delet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_Date;
        private System.Windows.Forms.TextBox textbox_Sys;
        private System.Windows.Forms.TextBox textbox_Dia;
        private System.Windows.Forms.TextBox textbox_Pulse;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Delet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}