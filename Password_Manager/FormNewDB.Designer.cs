/*! \file FormNewDB.Designer.cs
\brief Plik FormNewDB.Designer.cs zawiera klasę FormNewDB z kodem wygenerowanym przez Designera.

Plik FormNewDB.Designer.cs zawiera klasę MainForm z kodem automatycznie wygenerowanym przez Designera Visual Studio na podstawie zaprojektowanego okna aplikacji.
*/

//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw, która obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Password_Manager
{
    partial class FormNewDB
    {
        /// <summary>
        /// Zmienna wymagana przez Designera.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Zwolnienie używanych zasobów. 
        /// </summary>
        /// <param name="disposing">parametr typu bool - prawda, jeśli zasób ma być zwolniony, w przeciwynym wypadku fałsz.</param>
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
            this.label_Info = new System.Windows.Forms.Label();
            this.textBox_Filename = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label_key = new System.Windows.Forms.Label();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Info.Location = new System.Drawing.Point(22, 23);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(473, 29);
            this.label_Info.TabIndex = 21;
            this.label_Info.Text = "Save new Database and enter new Key.";
            // 
            // textBox_Filename
            // 
            this.textBox_Filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Filename.Location = new System.Drawing.Point(22, 63);
            this.textBox_Filename.Multiline = true;
            this.textBox_Filename.Name = "textBox_Filename";
            this.textBox_Filename.ReadOnly = true;
            this.textBox_Filename.Size = new System.Drawing.Size(595, 33);
            this.textBox_Filename.TabIndex = 20;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Key.Location = new System.Drawing.Point(87, 102);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(530, 35);
            this.textBox_Key.TabIndex = 19;
            this.textBox_Key.UseSystemPasswordChar = true;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_key.Location = new System.Drawing.Point(17, 108);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(64, 29);
            this.label_key.TabIndex = 18;
            this.label_key.Text = "Key:";
            // 
            // Button_Save
            // 
            this.Button_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Save.Location = new System.Drawing.Point(501, 21);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(116, 34);
            this.Button_Save.TabIndex = 17;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_OK.Location = new System.Drawing.Point(232, 169);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(116, 34);
            this.Button_OK.TabIndex = 16;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Cancel.Location = new System.Drawing.Point(354, 169);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(116, 34);
            this.Button_Cancel.TabIndex = 22;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // FormNewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 237);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.textBox_Filename);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_OK);
            this.Name = "FormNewDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //! Etykieta informacyjna.
        /*! Etykieta informacyjna. */
        private System.Windows.Forms.Label label_Info;

        //! Textbox, w którym wyświetla się nazwa nowej bazy.
        /*! Textbox, w którym wyświetla się nazwa nowej bazy. */
        private System.Windows.Forms.TextBox textBox_Filename;

        //! Textbox, w którym można wpisać klucz szyfrujący.
        /*! Textbox, w którym można wpisać klucz szyfrujący. */
        private System.Windows.Forms.TextBox textBox_Key;

        //! Etykieta ze słowem klucz.
        /*! Etykieta ze słowem klucz. */
        private System.Windows.Forms.Label label_key;

        //! Przycisk Load.
        /*! Użycie przycisku Load otwiera okno dialogowe, w którym można wybrać plik, do którego zapisana będzie nowo utworzona baza z hasłami.
         * Nowy plik tekstowy z bazą nie będzie zawierał żadnych wpisów z hasłami aż do momentu ich wprowadzenia w oknie głównym aplikacji i zapisania ich.
         */
        private System.Windows.Forms.Button Button_Save;

        //! Przycisk OK.
        /*! Użycie przycisku OK powoduje sprawdzenie czy użytkownik podał wszystkie wymagane dane a następnie użycie funkcji skrótu md5 w odniesieniu do podanego przez użytkownika hasła. */
        private System.Windows.Forms.Button Button_OK;

        //! Przycisk Cancel.
        /*! Użycie przycisku Cancel spowoduje anulowanie utworzenia nowej bazy z hasłami. */
        private System.Windows.Forms.Button Button_Cancel;
    }
}