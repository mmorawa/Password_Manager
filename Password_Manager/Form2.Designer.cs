namespace Password_Manager
{
    partial class Form2
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
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Load = new System.Windows.Forms.Button();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label_key = new System.Windows.Forms.Label();
            this.textBox_Filename = new System.Windows.Forms.TextBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_OK
            // 
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_OK.Location = new System.Drawing.Point(240, 169);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(116, 34);
            this.Button_OK.TabIndex = 8;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Load
            // 
            this.Button_Load.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Load.Location = new System.Drawing.Point(444, 18);
            this.Button_Load.Name = "Button_Load";
            this.Button_Load.Size = new System.Drawing.Size(116, 34);
            this.Button_Load.TabIndex = 9;
            this.Button_Load.Text = "Load";
            this.Button_Load.UseVisualStyleBackColor = true;
            this.Button_Load.Click += new System.EventHandler(this.Button_Load_Click);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Key.Location = new System.Drawing.Point(95, 102);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(489, 35);
            this.textBox_Key.TabIndex = 13;
            this.textBox_Key.UseSystemPasswordChar = true;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_key.Location = new System.Drawing.Point(25, 108);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(64, 29);
            this.label_key.TabIndex = 12;
            this.label_key.Text = "Key:";
            // 
            // textBox_Filename
            // 
            this.textBox_Filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Filename.Location = new System.Drawing.Point(30, 63);
            this.textBox_Filename.Multiline = true;
            this.textBox_Filename.Name = "textBox_Filename";
            this.textBox_Filename.ReadOnly = true;
            this.textBox_Filename.Size = new System.Drawing.Size(554, 33);
            this.textBox_Filename.TabIndex = 14;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Info.Location = new System.Drawing.Point(30, 23);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(392, 29);
            this.label_Info.TabIndex = 15;
            this.label_Info.Text = "Load the base and enter the key.";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Cancel.Location = new System.Drawing.Point(362, 169);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(116, 34);
            this.Button_Cancel.TabIndex = 16;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 237);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.textBox_Filename);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.Button_Load);
            this.Controls.Add(this.Button_OK);
            this.Name = "Form2";
            this.Text = "Load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Load;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.TextBox textBox_Filename;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button Button_Cancel;
    }
}