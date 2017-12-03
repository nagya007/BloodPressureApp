namespace BloodPressureLogApp
{
    partial class UpdateEntry
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
            this.button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sys = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combobox_Date
            // 
            this.combobox_Date.FormattingEnabled = true;
            this.combobox_Date.Location = new System.Drawing.Point(114, 30);
            this.combobox_Date.Name = "combobox_Date";
            this.combobox_Date.Size = new System.Drawing.Size(211, 21);
            this.combobox_Date.TabIndex = 0;
            this.combobox_Date.SelectedIndexChanged += new System.EventHandler(this.combobox_Date_SelectedIndexChanged);
            // 
            // textbox_Sys
            // 
            this.textbox_Sys.Location = new System.Drawing.Point(114, 86);
            this.textbox_Sys.Name = "textbox_Sys";
            this.textbox_Sys.Size = new System.Drawing.Size(160, 20);
            this.textbox_Sys.TabIndex = 1;
            this.textbox_Sys.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Sys_KeyPress);
            // 
            // textbox_Dia
            // 
            this.textbox_Dia.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.textbox_Dia.Location = new System.Drawing.Point(114, 121);
            this.textbox_Dia.Name = "textbox_Dia";
            this.textbox_Dia.Size = new System.Drawing.Size(160, 20);
            this.textbox_Dia.TabIndex = 2;
            this.textbox_Dia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Dia_KeyPress);
            // 
            // textbox_Pulse
            // 
            this.textbox_Pulse.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.textbox_Pulse.Location = new System.Drawing.Point(114, 161);
            this.textbox_Pulse.Name = "textbox_Pulse";
            this.textbox_Pulse.Size = new System.Drawing.Size(160, 20);
            this.textbox_Pulse.TabIndex = 3;
            this.textbox_Pulse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Pulse_KeyPress);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(46, 221);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 4;
            this.button_Back.Text = "Vissza";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(238, 221);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Mentés";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Válassz dátumot:";
            // 
            // Sys
            // 
            this.Sys.AutoSize = true;
            this.Sys.Location = new System.Drawing.Point(46, 89);
            this.Sys.Name = "Sys";
            this.Sys.Size = new System.Drawing.Size(27, 13);
            this.Sys.TabIndex = 7;
            this.Sys.Text = "Sys:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pulzus:";
            // 
            // UpdateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.textbox_Pulse);
            this.Controls.Add(this.textbox_Dia);
            this.Controls.Add(this.textbox_Sys);
            this.Controls.Add(this.combobox_Date);
            this.Name = "UpdateEntry";
            this.Text = "UpdateEntry";
            this.Load += new System.EventHandler(this.UpdateEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_Date;
        private System.Windows.Forms.TextBox textbox_Sys;
        private System.Windows.Forms.TextBox textbox_Dia;
        private System.Windows.Forms.TextBox textbox_Pulse;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Sys;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}