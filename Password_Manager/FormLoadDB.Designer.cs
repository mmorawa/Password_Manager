/*! \file FormLoadDB.Designer.cs
\brief Plik FormLoadDB.Designer.cs zawiera klasę FormLoadDB z kodem wygenerowanym przez Designera.

Plik FormLoadDB.Designer.cs zawiera klasę FormLoadDB z kodem automatycznie wygenerowanym przez Designera Visual Studio na podstawie zaprojektowanego okna aplikacji.
*/

//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw, która obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Password_Manager
{
    partial class FormLoadDB
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
            this.Button_Load.Location = new System.Drawing.Point(468, 19);
            this.Button_Load.Name = "Button_Load";
            this.Button_Load.Size = new System.Drawing.Size(116, 34);
            this.Button_Load.TabIndex = 9;
            this.Button_Load.Text = "Load";
            this.Button_Load.UseVisualStyleBackColor = true;
            this.Button_Load.Click += new System.EventHandler(this.Button_Load_Click);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Key.Location = new System.Drawing.Point(78, 102);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(506, 29);
            this.textBox_Key.TabIndex = 13;
            this.textBox_Key.UseSystemPasswordChar = true;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_key.Location = new System.Drawing.Point(25, 108);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(47, 24);
            this.label_key.TabIndex = 12;
            this.label_key.Text = "Key:";
            // 
            // textBox_Filename
            // 
            this.textBox_Filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Info.Location = new System.Drawing.Point(30, 23);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(293, 24);
            this.label_Info.TabIndex = 15;
            this.label_Info.Text = "Load Database and enter the Key.";
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
            // FormLoadDB
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
            this.Name = "FormLoadDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //! Przycisk OK.
        /*! Użycie przycisku OK powoduje sprawdzenie czy użytkownik podał wszystkie wymagane dane a następnie użycie funkcji skrótu md5 w odniesieniu do podanego przez użytkownika hasła. */
        private System.Windows.Forms.Button Button_OK;

        //! Przycisk Load.
        /*! Użycie przycisku Load otwiera okno dialogowe, w którym można wybrać bazę do wczytania.
         * Pliki bazy obsługiwane przez aplikację mają postać plików tekstowych z rozszerzeniem .txt.
         */
        private System.Windows.Forms.Button Button_Load;

        //! Textbox, w którym można wpisać klucz szyfrujący.
        /*! Textbox, w którym można wpisać klucz szyfrujący. */
        private System.Windows.Forms.TextBox textBox_Key;

        //! Etykieta ze słowem klucz.
        /*! Etykieta ze słowem klucz. */
        private System.Windows.Forms.Label label_key;

        //! Textbox, w którym wyświetla się nazwa bazy do wczytania.
        /*! Textbox, w którym wyświetla się nazwa bazy do wczytania. */
        private System.Windows.Forms.TextBox textBox_Filename;

        //! Etykieta informacyjna.
        /*! Etykieta informacyjna. */
        private System.Windows.Forms.Label label_Info;

        //! Przycisk Cancel.
        /*! Użycie przycisku Cancel spowoduje anulowanie wczytania bazy do aplikacji. */
        private System.Windows.Forms.Button Button_Cancel;
    }
}