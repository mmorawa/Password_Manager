/*! \file FormChangeKey.Designer.cs
\brief Plik FormChangeKey.Designer.cs zawiera klasę FormChangeKey z kodem wygenerowanym przez Designera.

Plik FormChangeKey.Designer.cs zawiera klasę FormChangeKey z kodem automatycznie wygenerowanym przez Designera Visual Studio na podstawie zaprojektowanego okna aplikacji.
*/

//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw, która obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Password_Manager
{
    partial class FormChangeKey
    {
        /// <summary>
        /// Zmienna wymagana przez Designera.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Zwolnienie używanych zasobów. 
        /// </summary>
        /// <param name="disposing"> parametr typu bool - prawda, jeśli zasób ma być zwolniony, w przeciwynym wypadku fałsz.</param>
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
        /// Metoda wymagana przez Designera.
        /// Nie należy modyfikować jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label_key = new System.Windows.Forms.Label();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.label_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Key.Location = new System.Drawing.Point(85, 70);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(501, 29);
            this.textBox_Key.TabIndex = 22;
            this.textBox_Key.UseSystemPasswordChar = true;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_key.Location = new System.Drawing.Point(27, 73);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(47, 24);
            this.label_key.TabIndex = 21;
            this.label_key.Text = "Key:";
            // 
            // Button_OK
            // 
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_OK.Location = new System.Drawing.Point(180, 133);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(116, 34);
            this.Button_OK.TabIndex = 20;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Cancel.Location = new System.Drawing.Point(302, 133);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(116, 34);
            this.Button_Cancel.TabIndex = 23;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Info.Location = new System.Drawing.Point(27, 21);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(138, 24);
            this.label_Info.TabIndex = 24;
            this.label_Info.Text = "Enter new Key:";
            // 
            // FormChangeKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 191);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.Button_OK);
            this.Name = "FormChangeKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //! Textbox, w którym można wpisać nowy klucz szyfrujący.
        /*! Textbox, w którym można wpisać nowy klucz szyfrujący. */
        private System.Windows.Forms.TextBox textBox_Key;

        //! Etykieta ze słowem klucz.
        /*! Etykieta ze słowem klucz. */
        private System.Windows.Forms.Label label_key;

        //! Przycisk OK.
        /*! Użycie przycisku OK powoduje sprawdzenie czy użytkownik podał nowy klucz szyfrujący a następnie użycie funkcji skrótu md5 w odniesieniu do niego. */
        private System.Windows.Forms.Button Button_OK;

        //! Przycisk Cancel.
        /*! Użycie przycisku Cancel spowoduje anulowanie zmiany klucza szyfrującego. */
        private System.Windows.Forms.Button Button_Cancel;

        //! Etykieta informacyjna.
        /*! Etykieta informacyjna. */
        private System.Windows.Forms.Label label_Info;
    }
}