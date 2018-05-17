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
            this.label_Encrypted = new System.Windows.Forms.Label();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_Text = new System.Windows.Forms.TextBox();
            this.textBox_Encrypted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Encrypt
            // 
            this.Button_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Encrypt.Location = new System.Drawing.Point(12, 39);
            this.Button_Encrypt.Name = "Button_Encrypt";
            this.Button_Encrypt.Size = new System.Drawing.Size(116, 34);
            this.Button_Encrypt.TabIndex = 0;
            this.Button_Encrypt.Text = "Encrypt";
            this.Button_Encrypt.UseVisualStyleBackColor = true;
            this.Button_Encrypt.Click += new System.EventHandler(this.Button_Encrypt_Click);
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_key.Location = new System.Drawing.Point(12, 92);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(39, 20);
            this.label_key.TabIndex = 1;
            this.label_key.Text = "Key:";
            // 
            // label_Text
            // 
            this.label_Text.AutoSize = true;
            this.label_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Text.Location = new System.Drawing.Point(12, 128);
            this.label_Text.Name = "label_Text";
            this.label_Text.Size = new System.Drawing.Size(43, 20);
            this.label_Text.TabIndex = 2;
            this.label_Text.Text = "Text:";
            // 
            // label_Encrypted
            // 
            this.label_Encrypted.AutoSize = true;
            this.label_Encrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Encrypted.Location = new System.Drawing.Point(12, 163);
            this.label_Encrypted.Name = "label_Encrypted";
            this.label_Encrypted.Size = new System.Drawing.Size(85, 20);
            this.label_Encrypted.TabIndex = 3;
            this.label_Encrypted.Text = "Encrypted:";
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Key.Location = new System.Drawing.Point(135, 86);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(125, 26);
            this.textBox_Key.TabIndex = 4;
            this.textBox_Key.UseSystemPasswordChar = true;
            // 
            // textBox_Text
            // 
            this.textBox_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Text.Location = new System.Drawing.Point(135, 122);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.Size = new System.Drawing.Size(125, 26);
            this.textBox_Text.TabIndex = 5;
            // 
            // textBox_Encrypted
            // 
            this.textBox_Encrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Encrypted.Location = new System.Drawing.Point(16, 186);
            this.textBox_Encrypted.Multiline = true;
            this.textBox_Encrypted.Name = "textBox_Encrypted";
            this.textBox_Encrypted.ReadOnly = true;
            this.textBox_Encrypted.Size = new System.Drawing.Size(244, 60);
            this.textBox_Encrypted.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 258);
            this.Controls.Add(this.textBox_Encrypted);
            this.Controls.Add(this.textBox_Text);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.label_Encrypted);
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
        private System.Windows.Forms.Label label_Encrypted;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_Text;
        private System.Windows.Forms.TextBox textBox_Encrypted;
    }
}

