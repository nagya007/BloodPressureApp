namespace BloodPressureLogApp
{
    partial class Add
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
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textbox_Sys = new System.Windows.Forms.TextBox();
            this.textbox_Dia = new System.Windows.Forms.TextBox();
            this.textbox_Pulse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(17, 241);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 1;
            this.button_Back.Text = "Vissza";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(236, 241);
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
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 290);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_Pulse);
            this.Controls.Add(this.textbox_Dia);
            this.Controls.Add(this.textbox_Sys);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Back);
            this.Name = "Add";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textbox_Sys;
        private System.Windows.Forms.TextBox textbox_Dia;
        private System.Windows.Forms.TextBox textbox_Pulse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}