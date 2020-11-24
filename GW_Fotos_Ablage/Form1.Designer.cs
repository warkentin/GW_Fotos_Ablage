namespace GW_Fotos_Ablage
{
    partial class frm_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.txt_pfad = new System.Windows.Forms.TextBox();
            this.btn_pfad = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pfad_export = new System.Windows.Forms.TextBox();
            this.btn_pfad_ziel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_daten = new System.Windows.Forms.ListView();
            this.Nummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Verzeichnis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Anzahl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txt_pfad
            // 
            this.txt_pfad.Location = new System.Drawing.Point(25, 44);
            this.txt_pfad.Name = "txt_pfad";
            this.txt_pfad.Size = new System.Drawing.Size(574, 20);
            this.txt_pfad.TabIndex = 0;
            this.txt_pfad.Text = "C:\\Temp\\";
            // 
            // btn_pfad
            // 
            this.btn_pfad.Location = new System.Drawing.Point(623, 40);
            this.btn_pfad.Name = "btn_pfad";
            this.btn_pfad.Size = new System.Drawing.Size(128, 27);
            this.btn_pfad.TabIndex = 1;
            this.btn_pfad.Text = "1. Quellpfad wählen";
            this.btn_pfad.UseVisualStyleBackColor = true;
            this.btn_pfad.Click += new System.EventHandler(this.Btn_pfad_Click);
            // 
            // btn_export
            // 
            this.btn_export.Enabled = false;
            this.btn_export.Location = new System.Drawing.Point(469, 187);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(128, 62);
            this.btn_export.TabIndex = 3;
            this.btn_export.Text = "3. Ausführen";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.Btn_export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quellverzeichnis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zielverzeichnis:";
            // 
            // txt_pfad_export
            // 
            this.txt_pfad_export.Location = new System.Drawing.Point(25, 109);
            this.txt_pfad_export.Name = "txt_pfad_export";
            this.txt_pfad_export.Size = new System.Drawing.Size(574, 20);
            this.txt_pfad_export.TabIndex = 6;
            this.txt_pfad_export.Text = "C:\\Temp\\Export\\";
            // 
            // btn_pfad_ziel
            // 
            this.btn_pfad_ziel.Location = new System.Drawing.Point(623, 104);
            this.btn_pfad_ziel.Name = "btn_pfad_ziel";
            this.btn_pfad_ziel.Size = new System.Drawing.Size(128, 28);
            this.btn_pfad_ziel.TabIndex = 7;
            this.btn_pfad_ziel.Text = "2. Zielpfad wählen";
            this.btn_pfad_ziel.UseVisualStyleBackColor = true;
            this.btn_pfad_ziel.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Daten:";
            // 
            // lv_daten
            // 
            this.lv_daten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Verzeichnis,
            this.Nummer,
            this.Anzahl});
            this.lv_daten.HideSelection = false;
            this.lv_daten.Location = new System.Drawing.Point(24, 187);
            this.lv_daten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lv_daten.Name = "lv_daten";
            this.lv_daten.Size = new System.Drawing.Size(415, 419);
            this.lv_daten.TabIndex = 9;
            this.lv_daten.UseCompatibleStateImageBehavior = false;
            this.lv_daten.View = System.Windows.Forms.View.Details;
            // 
            // Nummer
            // 
            this.Nummer.Text = "Nummer";
            this.Nummer.Width = 94;
            // 
            // Verzeichnis
            // 
            this.Verzeichnis.Text = "Verzeichnis";
            this.Verzeichnis.Width = 213;
            // 
            // Anzahl
            // 
            this.Anzahl.Text = "Anzahl";
            this.Anzahl.Width = 78;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.lv_daten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_pfad_ziel);
            this.Controls.Add(this.txt_pfad_export);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_pfad);
            this.Controls.Add(this.txt_pfad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.Text = "GW Fotos Ablage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pfad;
        private System.Windows.Forms.Button btn_pfad;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pfad_export;
        private System.Windows.Forms.Button btn_pfad_ziel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lv_daten;
        private System.Windows.Forms.ColumnHeader Nummer;
        private System.Windows.Forms.ColumnHeader Verzeichnis;
        private System.Windows.Forms.ColumnHeader Anzahl;
    }
}

