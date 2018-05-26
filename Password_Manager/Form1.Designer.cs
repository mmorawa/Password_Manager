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
            this.Button_Open = new System.Windows.Forms.Button();
            this.label_Site = new System.Windows.Forms.Label();
            this.Button_change = new System.Windows.Forms.Button();
            this.Button_New = new System.Windows.Forms.Button();
            this.Button_SaveAs = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.label_URL = new System.Windows.Forms.Label();
            this.Button_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Save
            // 
            this.Button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Save.Location = new System.Drawing.Point(378, 45);
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
            this.label_Password.Location = new System.Drawing.Point(718, 128);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(135, 29);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password:";
            this.label_Password.Visible = false;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Login.Location = new System.Drawing.Point(531, 128);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(85, 29);
            this.label_Login.TabIndex = 2;
            this.label_Login.Text = "Login:";
            this.label_Login.Visible = false;
            // 
            // Button_Open
            // 
            this.Button_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Open.Location = new System.Drawing.Point(134, 45);
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
            this.label_Site.Location = new System.Drawing.Point(82, 128);
            this.label_Site.Name = "label_Site";
            this.label_Site.Size = new System.Drawing.Size(66, 29);
            this.label_Site.TabIndex = 9;
            this.label_Site.Text = "Site:";
            this.label_Site.Visible = false;
            // 
            // Button_change
            // 
            this.Button_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_change.Location = new System.Drawing.Point(256, 45);
            this.Button_change.Name = "Button_change";
            this.Button_change.Size = new System.Drawing.Size(116, 34);
            this.Button_change.TabIndex = 11;
            this.Button_change.Text = "Change Key";
            this.Button_change.UseVisualStyleBackColor = true;
            this.Button_change.Click += new System.EventHandler(this.Button_change_Click);
            // 
            // Button_New
            // 
            this.Button_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_New.Location = new System.Drawing.Point(12, 45);
            this.Button_New.Name = "Button_New";
            this.Button_New.Size = new System.Drawing.Size(116, 34);
            this.Button_New.TabIndex = 16;
            this.Button_New.Text = "New";
            this.Button_New.UseVisualStyleBackColor = true;
            this.Button_New.Click += new System.EventHandler(this.Button_New_Click);
            // 
            // Button_SaveAs
            // 
            this.Button_SaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_SaveAs.Location = new System.Drawing.Point(500, 45);
            this.Button_SaveAs.Name = "Button_SaveAs";
            this.Button_SaveAs.Size = new System.Drawing.Size(116, 34);
            this.Button_SaveAs.TabIndex = 17;
            this.Button_SaveAs.Text = "Save as";
            this.Button_SaveAs.UseVisualStyleBackColor = true;
            this.Button_SaveAs.Click += new System.EventHandler(this.Button_SaveAs_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Close.Location = new System.Drawing.Point(622, 45);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(116, 34);
            this.Button_Close.TabIndex = 18;
            this.Button_Close.Text = "Close";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // label_URL
            // 
            this.label_URL.AutoSize = true;
            this.label_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_URL.Location = new System.Drawing.Point(312, 128);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(70, 29);
            this.label_URL.TabIndex = 20;
            this.label_URL.Text = "URL:";
            this.label_URL.Visible = false;
            // 
            // Button_Quit
            // 
            this.Button_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Quit.Location = new System.Drawing.Point(744, 45);
            this.Button_Quit.Name = "Button_Quit";
            this.Button_Quit.Size = new System.Drawing.Size(116, 34);
            this.Button_Quit.TabIndex = 24;
            this.Button_Quit.Text = "Quit";
            this.Button_Quit.UseVisualStyleBackColor = true;
            this.Button_Quit.Click += new System.EventHandler(this.Button_Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 648);
            this.Controls.Add(this.Button_Quit);
            this.Controls.Add(this.label_URL);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_SaveAs);
            this.Controls.Add(this.Button_New);
            this.Controls.Add(this.Button_change);
            this.Controls.Add(this.label_Site);
            this.Controls.Add(this.Button_Open);
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
        private System.Windows.Forms.Button Button_Open;
        private System.Windows.Forms.Label label_Site;
        private System.Windows.Forms.Button Button_change;
        private System.Windows.Forms.Button Button_New;
        private System.Windows.Forms.Button Button_SaveAs;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Label label_URL;
        private System.Windows.Forms.Button Button_Quit;
    }
}

