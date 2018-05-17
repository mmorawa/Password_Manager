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
            this.Button_Encrypt = new System.Windows.Forms.Button();
            this.label_key = new System.Windows.Forms.Label();
            this.label_Text = new System.Windows.Forms.Label();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_Text = new System.Windows.Forms.TextBox();
            this.Button_Decrypt = new System.Windows.Forms.Button();
            this.label_Decrypted = new System.Windows.Forms.Label();
            this.textBox_Decrypted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Encrypt
            // 
            this.Button_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Encrypt.Location = new System.Drawing.Point(363, 48);
            this.Button_Encrypt.Name = "Button_Encrypt";
            this.Button_Encrypt.Size = new System.Drawing.Size(116, 34);
            this.Button_Encrypt.TabIndex = 0;
            this.Button_Encrypt.Text = "Save";
            this.Button_Encrypt.UseVisualStyleBackColor = true;
            this.Button_Encrypt.Click += new System.EventHandler(this.Button_Encrypt_Click);
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_key.Location = new System.Drawing.Point(358, 95);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(64, 29);
            this.label_key.TabIndex = 1;
            this.label_key.Text = "Key:";
            // 
            // label_Text
            // 
            this.label_Text.AutoSize = true;
            this.label_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Text.Location = new System.Drawing.Point(358, 140);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(71, 29);
            this.label_Text.TabIndex = 2;
            this.label_Text.Text = "Text:";
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Key.Location = new System.Drawing.Point(438, 92);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(179, 35);
            this.textBox_Key.TabIndex = 4;
            this.textBox_Key.UseSystemPasswordChar = true;
            // 
            // textBox_Text
            // 
            this.textBox_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Text.Location = new System.Drawing.Point(438, 137);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.Size = new System.Drawing.Size(179, 35);
            this.textBox_Text.TabIndex = 5;
            // 
            // Button_Decrypt
            // 
            this.Button_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Decrypt.Location = new System.Drawing.Point(34, 48);
            this.Button_Decrypt.Name = "Button_Decrypt";
            this.Button_Decrypt.Size = new System.Drawing.Size(116, 34);
            this.Button_Decrypt.TabIndex = 7;
            this.Button_Decrypt.Text = "Open";
            this.Button_Decrypt.UseVisualStyleBackColor = true;
            this.Button_Decrypt.Click += new System.EventHandler(this.Button_Decrypt_Click);
            // 
            // label_Decrypted
            // 
            this.label_Decrypted.AutoSize = true;
            this.label_Decrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Decrypted.Location = new System.Drawing.Point(29, 95);
            this.label_Decrypted.Name = "label_Decrypted";
            this.label_Decrypted.Size = new System.Drawing.Size(139, 29);
            this.label_Decrypted.TabIndex = 9;
            this.label_Decrypted.Text = "Decrypted:";
            // 
            // textBox_Decrypted
            // 
            this.textBox_Decrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Decrypted.Location = new System.Drawing.Point(33, 127);
            this.textBox_Decrypted.Multiline = true;
            this.textBox_Decrypted.Name = "textBox_Decrypted";
            this.textBox_Decrypted.ReadOnly = true;
            this.textBox_Decrypted.Size = new System.Drawing.Size(244, 60);
            this.textBox_Decrypted.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 648);
            this.Controls.Add(this.textBox_Decrypted);
            this.Controls.Add(this.label_Decrypted);
            this.Controls.Add(this.Button_Decrypt);
            this.Controls.Add(this.textBox_Text);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.label_Text);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.Button_Encrypt);
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Encrypt;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label_Text;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_Text;
        private System.Windows.Forms.Button Button_Decrypt;
        private System.Windows.Forms.Label label_Decrypted;
        private System.Windows.Forms.TextBox textBox_Decrypted;
    }
}

