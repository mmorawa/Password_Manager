namespace Password_Manager
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
            this.Button_Save = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.textBox_Site1 = new System.Windows.Forms.TextBox();
            this.textBox_Login1 = new System.Windows.Forms.TextBox();
            this.Button_Open = new System.Windows.Forms.Button();
            this.label_Site = new System.Windows.Forms.Label();
            this.Button_change = new System.Windows.Forms.Button();
            this.textBox_Pass1 = new System.Windows.Forms.TextBox();
            this.textBox_Pass2 = new System.Windows.Forms.TextBox();
            this.textBox_Login2 = new System.Windows.Forms.TextBox();
            this.textBox_Site2 = new System.Windows.Forms.TextBox();
            this.button_New = new System.Windows.Forms.Button();
            this.Button_SaveAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Save
            // 
            this.Button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Save.Location = new System.Drawing.Point(411, 45);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(116, 34);
            this.Button_Save.TabIndex = 0;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Password.Location = new System.Drawing.Point(453, 130);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(135, 29);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password:";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Login.Location = new System.Drawing.Point(284, 130);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(85, 29);
            this.label_Login.TabIndex = 2;
            this.label_Login.Text = "Login:";
            // 
            // textBox_Site1
            // 
            this.textBox_Site1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Site1.Location = new System.Drawing.Point(34, 162);
            this.textBox_Site1.Name = "textBox_Site1";
            this.textBox_Site1.Size = new System.Drawing.Size(179, 35);
            this.textBox_Site1.TabIndex = 4;
            // 
            // textBox_Login1
            // 
            this.textBox_Login1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Login1.Location = new System.Drawing.Point(231, 162);
            this.textBox_Login1.Name = "textBox_Login1";
            this.textBox_Login1.Size = new System.Drawing.Size(179, 35);
            this.textBox_Login1.TabIndex = 5;
            // 
            // Button_Open
            // 
            this.Button_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Open.Location = new System.Drawing.Point(156, 45);
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.Size = new System.Drawing.Size(116, 34);
            this.Button_Open.TabIndex = 7;
            this.Button_Open.Text = "Open";
            this.Button_Open.UseVisualStyleBackColor = true;
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // label_Site
            // 
            this.label_Site.AutoSize = true;
            this.label_Site.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Site.Location = new System.Drawing.Point(91, 130);
            this.label_Site.Name = "label_Site";
            this.label_Site.Size = new System.Drawing.Size(66, 29);
            this.label_Site.TabIndex = 9;
            this.label_Site.Text = "Site:";
            // 
            // Button_change
            // 
            this.Button_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_change.Location = new System.Drawing.Point(283, 45);
            this.Button_change.Name = "Button_change";
            this.Button_change.Size = new System.Drawing.Size(116, 34);
            this.Button_change.TabIndex = 11;
            this.Button_change.Text = "Change Key";
            this.Button_change.UseVisualStyleBackColor = true;
            this.Button_change.Click += new System.EventHandler(this.Button_change_Click);
            // 
            // textBox_Pass1
            // 
            this.textBox_Pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Pass1.Location = new System.Drawing.Point(427, 162);
            this.textBox_Pass1.Name = "textBox_Pass1";
            this.textBox_Pass1.Size = new System.Drawing.Size(179, 35);
            this.textBox_Pass1.TabIndex = 12;
            this.textBox_Pass1.UseSystemPasswordChar = true;
            // 
            // textBox_Pass2
            // 
            this.textBox_Pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Pass2.Location = new System.Drawing.Point(427, 203);
            this.textBox_Pass2.Name = "textBox_Pass2";
            this.textBox_Pass2.Size = new System.Drawing.Size(179, 35);
            this.textBox_Pass2.TabIndex = 15;
            this.textBox_Pass2.UseSystemPasswordChar = true;
            // 
            // textBox_Login2
            // 
            this.textBox_Login2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Login2.Location = new System.Drawing.Point(231, 203);
            this.textBox_Login2.Name = "textBox_Login2";
            this.textBox_Login2.Size = new System.Drawing.Size(179, 35);
            this.textBox_Login2.TabIndex = 14;
            // 
            // textBox_Site2
            // 
            this.textBox_Site2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Site2.Location = new System.Drawing.Point(34, 203);
            this.textBox_Site2.Name = "textBox_Site2";
            this.textBox_Site2.Size = new System.Drawing.Size(179, 35);
            this.textBox_Site2.TabIndex = 13;
            // 
            // button_New
            // 
            this.button_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_New.Location = new System.Drawing.Point(25, 45);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(116, 34);
            this.button_New.TabIndex = 16;
            this.button_New.Text = "New";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // Button_SaveAs
            // 
            this.Button_SaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_SaveAs.Location = new System.Drawing.Point(542, 45);
            this.Button_SaveAs.Name = "Button_SaveAs";
            this.Button_SaveAs.Size = new System.Drawing.Size(116, 34);
            this.Button_SaveAs.TabIndex = 17;
            this.Button_SaveAs.Text = "Save as";
            this.Button_SaveAs.UseVisualStyleBackColor = true;
            this.Button_SaveAs.Click += new System.EventHandler(this.Button_SaveAs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 648);
            this.Controls.Add(this.Button_SaveAs);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.textBox_Pass2);
            this.Controls.Add(this.textBox_Login2);
            this.Controls.Add(this.textBox_Site2);
            this.Controls.Add(this.textBox_Pass1);
            this.Controls.Add(this.Button_change);
            this.Controls.Add(this.label_Site);
            this.Controls.Add(this.Button_Open);
            this.Controls.Add(this.textBox_Login1);
            this.Controls.Add(this.textBox_Site1);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.Button_Save);
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.TextBox textBox_Site1;
        private System.Windows.Forms.TextBox textBox_Login1;
        private System.Windows.Forms.Button Button_Open;
        private System.Windows.Forms.Label label_Site;
        private System.Windows.Forms.Button Button_change;
        private System.Windows.Forms.TextBox textBox_Pass1;
        private System.Windows.Forms.TextBox textBox_Pass2;
        private System.Windows.Forms.TextBox textBox_Login2;
        private System.Windows.Forms.TextBox textBox_Site2;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button Button_SaveAs;
    }
}

