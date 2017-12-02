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
            this.button1 = new System.Windows.Forms.Button();
            this.button_Delet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobox_Date
            // 
            this.combobox_Date.FormattingEnabled = true;
            this.combobox_Date.Location = new System.Drawing.Point(65, 26);
            this.combobox_Date.Name = "combobox_Date";
            this.combobox_Date.Size = new System.Drawing.Size(173, 21);
            this.combobox_Date.TabIndex = 0;
            this.combobox_Date.SelectedIndexChanged += new System.EventHandler(this.combobox_Date_SelectedIndexChanged);
            // 
            // textbox_Sys
            // 
            this.textbox_Sys.Enabled = false;
            this.textbox_Sys.Location = new System.Drawing.Point(65, 66);
            this.textbox_Sys.Name = "textbox_Sys";
            this.textbox_Sys.Size = new System.Drawing.Size(173, 20);
            this.textbox_Sys.TabIndex = 1;
            // 
            // textbox_Dia
            // 
            this.textbox_Dia.Enabled = false;
            this.textbox_Dia.Location = new System.Drawing.Point(65, 108);
            this.textbox_Dia.Name = "textbox_Dia";
            this.textbox_Dia.Size = new System.Drawing.Size(173, 20);
            this.textbox_Dia.TabIndex = 2;
            // 
            // textbox_Pulse
            // 
            this.textbox_Pulse.Enabled = false;
            this.textbox_Pulse.Location = new System.Drawing.Point(65, 147);
            this.textbox_Pulse.Name = "textbox_Pulse";
            this.textbox_Pulse.Size = new System.Drawing.Size(173, 20);
            this.textbox_Pulse.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_Delet
            // 
            this.button_Delet.Location = new System.Drawing.Point(163, 207);
            this.button_Delet.Name = "button_Delet";
            this.button_Delet.Size = new System.Drawing.Size(75, 23);
            this.button_Delet.TabIndex = 5;
            this.button_Delet.Text = "button2";
            this.button_Delet.UseVisualStyleBackColor = true;
            this.button_Delet.Click += new System.EventHandler(this.button_Delet_Click);
            // 
            // Delet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_Delet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbox_Pulse);
            this.Controls.Add(this.textbox_Dia);
            this.Controls.Add(this.textbox_Sys);
            this.Controls.Add(this.combobox_Date);
            this.Name = "Delet";
            this.Text = "Delet";
            this.Load += new System.EventHandler(this.Delet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_Date;
        private System.Windows.Forms.TextBox textbox_Sys;
        private System.Windows.Forms.TextBox textbox_Dia;
        private System.Windows.Forms.TextBox textbox_Pulse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Delet;
    }
}