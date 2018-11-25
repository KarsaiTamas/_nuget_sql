namespace Szukanuget
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
            this.Nev_TextBox = new System.Windows.Forms.TextBox();
            this.Jelszo_TextBox = new System.Windows.Forms.TextBox();
            this.Ev_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Kuld_Button = new System.Windows.Forms.Button();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Select_ListBox = new System.Windows.Forms.ListBox();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nev_TextBox
            // 
            this.Nev_TextBox.Location = new System.Drawing.Point(12, 12);
            this.Nev_TextBox.Name = "Nev_TextBox";
            this.Nev_TextBox.Size = new System.Drawing.Size(267, 20);
            this.Nev_TextBox.TabIndex = 0;
            // 
            // Jelszo_TextBox
            // 
            this.Jelszo_TextBox.Location = new System.Drawing.Point(13, 52);
            this.Jelszo_TextBox.Name = "Jelszo_TextBox";
            this.Jelszo_TextBox.PasswordChar = '*';
            this.Jelszo_TextBox.Size = new System.Drawing.Size(266, 20);
            this.Jelszo_TextBox.TabIndex = 1;
            // 
            // Ev_DateTimePicker
            // 
            this.Ev_DateTimePicker.Location = new System.Drawing.Point(13, 98);
            this.Ev_DateTimePicker.Name = "Ev_DateTimePicker";
            this.Ev_DateTimePicker.Size = new System.Drawing.Size(266, 20);
            this.Ev_DateTimePicker.TabIndex = 2;
            // 
            // Kuld_Button
            // 
            this.Kuld_Button.Location = new System.Drawing.Point(204, 137);
            this.Kuld_Button.Name = "Kuld_Button";
            this.Kuld_Button.Size = new System.Drawing.Size(75, 23);
            this.Kuld_Button.TabIndex = 3;
            this.Kuld_Button.Text = "Regisztracio";
            this.Kuld_Button.UseVisualStyleBackColor = true;
            this.Kuld_Button.Click += new System.EventHandler(this.Kuld_Button_Click);
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(117, 137);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(180, 197);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Visible = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(180, 240);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(75, 23);
            this.Update_Button.TabIndex = 7;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Visible = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Select_ListBox
            // 
            this.Select_ListBox.FormattingEnabled = true;
            this.Select_ListBox.Location = new System.Drawing.Point(15, 168);
            this.Select_ListBox.Name = "Select_ListBox";
            this.Select_ListBox.Size = new System.Drawing.Size(159, 95);
            this.Select_ListBox.TabIndex = 8;
            this.Select_ListBox.Visible = false;
            // 
            // Logout_Button
            // 
            this.Logout_Button.Location = new System.Drawing.Point(31, 137);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(75, 23);
            this.Logout_Button.TabIndex = 9;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseVisualStyleBackColor = true;
            this.Logout_Button.Visible = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 450);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.Select_ListBox);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Kuld_Button);
            this.Controls.Add(this.Ev_DateTimePicker);
            this.Controls.Add(this.Jelszo_TextBox);
            this.Controls.Add(this.Nev_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nev_TextBox;
        private System.Windows.Forms.TextBox Jelszo_TextBox;
        private System.Windows.Forms.DateTimePicker Ev_DateTimePicker;
        private System.Windows.Forms.Button Kuld_Button;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.ListBox Select_ListBox;
        private System.Windows.Forms.Button Logout_Button;
    }
}

