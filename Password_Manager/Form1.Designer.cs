/*! \file Form1.Designer.cs
\brief Plik Form1.Designer.cs zawiera klasę Form1 z kodem wygenerowanym przez Designera.

Plik Form1.Designer.cs zawiera klasę Form1 z kodem automatycznie wygenerowanym przez Designera Visual Studio na podstawie zaprojektowanego okna aplikacji.
*/

//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw, która obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Password_Manager
{
    //! Klasa Form1 zawiera główne okno aplikacji.
    /*! W klasie Form1 znajduje się menu główne aplikacji, przyciski oraz Textboxy z danymi, oraz warstwa logiczna aplikacji */
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.Button_Exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // Button_Exit
            // 
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Exit.Location = new System.Drawing.Point(744, 45);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(116, 34);
            this.Button_Exit.TabIndex = 24;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.CloseToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(168, 6);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.SaveAsToolStripMenuItem.Text = "Save &As";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeKeyToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // ChangeKeyToolStripMenuItem
            // 
            this.ChangeKeyToolStripMenuItem.Name = "ChangeKeyToolStripMenuItem";
            this.ChangeKeyToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.ChangeKeyToolStripMenuItem.Text = "Change &Key";
            this.ChangeKeyToolStripMenuItem.Click += new System.EventHandler(this.ChangeKeyToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.AboutToolStripMenuItem.Text = "&About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripMenuItem.Image")));
            this.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.NewToolStripMenuItem.Text = "&New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CutToolStripMenuItem.Image")));
            this.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.CutToolStripMenuItem.Text = "Cu&t";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CopyToolStripMenuItem.Image")));
            this.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.CopyToolStripMenuItem.Text = "&Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PasteToolStripMenuItem.Image")));
            this.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.PasteToolStripMenuItem.Text = "&Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1051, 648);
            this.Controls.Add(this.Button_Exit);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //! Przycisk Save.
        /*! Użycie przycisku Save powoduje wywołanie metody SaveDatabase, która automatycznie szyfruje wpisy z hasłami, znajdujące się w głównym oknie programu bez konieczności podania ścieżki do pliku bazy. */
        private System.Windows.Forms.Button Button_Save;

        //! Etykieta Password.
        /*! Etykieta Password. */
        private System.Windows.Forms.Label label_Password;

        //! Etykieta Login.
        /*! Etykieta Login. */
        private System.Windows.Forms.Label label_Login;

        //! Przycisk Open.
        /*! Użycie przycisku Open odpowiada za wczytanie pliku z bazą haseł a następnie jego odszyfrowanie przy użyciu podanego przez użytkownika klucza.
         * Następnie generowane zostają Panele z Textboxami, do których podstawiane są odszyfrowane dane tekstowe.
         */
        private System.Windows.Forms.Button Button_Open;

        //! Etykieta Site.
        /*! Etykieta Site. */
        private System.Windows.Forms.Label label_Site;

        //! Przycisk Change.
        /*! Użycie przycisku Change umożliwia zmianę klucza szyfrującego bazę z hasłami.
         */
        private System.Windows.Forms.Button Button_change;

        //! Przycisk New.
        /*! Użycie przycisku New otwiera nowe okno, gdzie pyta użytkownika o podstawowe dane odnośnie nowej bazy a następnie tworzy pierwszy Panel, w którym użytkownik może zacząć wpisywać swoje dane. */
        private System.Windows.Forms.Button Button_New;

        //! Przycisk Save As.
        /*! Użycie przycisku Save As powoduje pojawienie się nowego okna dialogowego, w którym możemy wybrać ścieżkę do pliku bazy, po czym następuje wywołanie metody SaveDatabase, która szyfruje wpisy z hasłami, znajdujące się w głównym oknie programu. */
        private System.Windows.Forms.Button Button_SaveAs;

        //! Przycisk Close.
        /*! Użycie przycisku Close powoduje zamknięcie aktywnej bazy poprzez wywołanie metody CloseDatabase. */
        private System.Windows.Forms.Button Button_Close;

        //! Etykieta URL.
        /*! Etykieta URL. */
        private System.Windows.Forms.Label label_URL;

        //! Przycisk Exit.
        /*! Użycie przycisku Exit skutkuje zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjście z programu. */
        private System.Windows.Forms.Button Button_Exit;

        //! Pasek Menu.
        /*! Pasek Menu. */
        private System.Windows.Forms.MenuStrip menuStrip1;

        //! Zakładka File w pasku menu.
        /*! Zakładka File w pasku menu. */
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;

        //! Przycisk New w pasku menu.
        /*! Użycie przycisku New w pasku menu otwiera nowe okno, gdzie pyta użytkownika o podstawowe dane odnośnie nowej bazy a następnie tworzy pierwszy Panel, w którym użytkownik może zacząć wpisywać swoje dane. */
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;

        //! Przycisk Open w pasku menu.
        /*! Użycie przycisku Open w pasku menu odpowiada za wczytanie pliku z bazą haseł a następnie jego odszyfrowanie przy użyciu podanego przez użytkownika klucza.
         * Następnie generowane zostają Panele z Textboxami, do których podstawiane są odszyfrowane dane tekstowe.
         */
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;

        //! Separator w pasku menu.
        /*! Separator w pasku menu. */
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;

        //! Przycisk Save w pasku menu.
        /*! Użycie przycisku Save w pasku menu powoduje wywołanie metody SaveDatabase, która automatycznie szyfruje wpisy z hasłami, znajdujące się w głównym oknie programu bez konieczności podania ścieżki do pliku bazy. */
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;

        //! Przycisk Save As w pasku menu.
        /*! Użycie przycisku Save As w pasku menu powoduje pojawienie się nowego okna dialogowego, w którym możemy wybrać ścieżkę do pliku bazy, po czym następuje wywołanie metody SaveDatabase, która szyfruje wpisy z hasłami, znajdujące się w głównym oknie programu. */
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;

        //! Separator w pasku menu.
        /*! Separator w pasku menu. */
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        //! Przycisk Exit w pasku menu.
        /*! Użycie przycisku Exit w pasku menu skutkuje zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjście z programu. */
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;

        //! Zakładka Edit w pasku menu.
        /*! Zakładka Edit w pasku menu. */
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

        //! Przycisk Cut na pasku menu.
        /*! Użycie przycisku Cut na pasku Menu wycina zaznaczony tekst i przechowuje go w schowku systemowym. */
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;

        //! Przycisk Copy na pasku menu.
        /*! Użycie przycisku Copy na pasku Menu kopiuje zaznaczony tekst i przechowuje go w schowku systemowym. */
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;

        //! Przycisk Paste na pasku menu.
        /*! Użycie przycisku Paste na pasku menu wkleja tekst ze schowka systemowego w miejscu, gdzie znajduje się aktywny kursor. */
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;

        //! Zakładka Options w pasku menu.
        /*! Zakładka Options w pasku menu. */
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;

        //! Przycisk Change w pasku menu.
        /*! Użycie przycisku Change w pasku menu umożliwia zmianę klucza szyfrującego bazę z hasłami. */
        private System.Windows.Forms.ToolStripMenuItem ChangeKeyToolStripMenuItem;

        //! Zakładka Help w pasku menu.
        /*! Zakładka Help w pasku menu. */
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

        //! Przycisk About na pasku menu.
        /*! Użycie przycisku About na pasku menu powoduje wyświetlenie się okna z informacjami o aplikacji. */
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;

        //! Separator w pasku menu.
        /*! Separator w pasku menu. */
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        //! Przycisk Close w pasku menu.
        /*! Użycie przycisku Close w pasku menu powoduje zamknięcie aktywnej bazy poprzez wywołanie metody CloseDatabase. */
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
    }
}

