
namespace MigrationsTool_3_Oberfläche
{
    partial class MigrationsTool
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
            this.CmdOpenFile = new System.Windows.Forms.Button();
            this.CmdCloseWindow = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDateiAnzeige = new System.Windows.Forms.Label();
            this.CmdVorschau = new System.Windows.Forms.Button();
            this.CmdOpenBuchungsDaten = new System.Windows.Forms.Button();
            this.LblBuchungsDateiAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdOpenFile
            // 
            this.CmdOpenFile.Location = new System.Drawing.Point(29, 399);
            this.CmdOpenFile.Name = "CmdOpenFile";
            this.CmdOpenFile.Size = new System.Drawing.Size(139, 23);
            this.CmdOpenFile.TabIndex = 0;
            this.CmdOpenFile.Text = "Stammdaten Öffnen";
            this.CmdOpenFile.UseVisualStyleBackColor = true;
            this.CmdOpenFile.Click += new System.EventHandler(this.CmdOpenFile_Click);
            // 
            // CmdCloseWindow
            // 
            this.CmdCloseWindow.Location = new System.Drawing.Point(752, 451);
            this.CmdCloseWindow.Name = "CmdCloseWindow";
            this.CmdCloseWindow.Size = new System.Drawing.Size(80, 24);
            this.CmdCloseWindow.TabIndex = 1;
            this.CmdCloseWindow.Text = "Schließen";
            this.CmdCloseWindow.UseVisualStyleBackColor = true;
            this.CmdCloseWindow.Click += new System.EventHandler(this.CmdCloseWindow_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bitte wählen Sie ein XML-Datei aus. ";
            // 
            // LblDateiAnzeige
            // 
            this.LblDateiAnzeige.AutoSize = true;
            this.LblDateiAnzeige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateiAnzeige.Location = new System.Drawing.Point(241, 400);
            this.LblDateiAnzeige.Name = "LblDateiAnzeige";
            this.LblDateiAnzeige.Size = new System.Drawing.Size(161, 18);
            this.LblDateiAnzeige.TabIndex = 3;
            this.LblDateiAnzeige.Text = "Keine Datei ausgewählt";
            this.LblDateiAnzeige.Click += new System.EventHandler(this.LblDateiAnzeige_Click);
            // 
            // CmdVorschau
            // 
            this.CmdVorschau.Location = new System.Drawing.Point(48, 506);
            this.CmdVorschau.Name = "CmdVorschau";
            this.CmdVorschau.Size = new System.Drawing.Size(75, 23);
            this.CmdVorschau.TabIndex = 4;
            this.CmdVorschau.Text = "Vorschau";
            this.CmdVorschau.UseVisualStyleBackColor = true;
            // 
            // CmdOpenBuchungsDaten
            // 
            this.CmdOpenBuchungsDaten.Location = new System.Drawing.Point(29, 451);
            this.CmdOpenBuchungsDaten.Name = "CmdOpenBuchungsDaten";
            this.CmdOpenBuchungsDaten.Size = new System.Drawing.Size(139, 23);
            this.CmdOpenBuchungsDaten.TabIndex = 5;
            this.CmdOpenBuchungsDaten.Text = "Buchungsdaten Öffnen";
            this.CmdOpenBuchungsDaten.UseVisualStyleBackColor = true;
            this.CmdOpenBuchungsDaten.Click += new System.EventHandler(this.CmdOpenBuchungsDaten_Click);
            // 
            // LblBuchungsDateiAnzeige
            // 
            this.LblBuchungsDateiAnzeige.AutoSize = true;
            this.LblBuchungsDateiAnzeige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuchungsDateiAnzeige.Location = new System.Drawing.Point(241, 452);
            this.LblBuchungsDateiAnzeige.Name = "LblBuchungsDateiAnzeige";
            this.LblBuchungsDateiAnzeige.Size = new System.Drawing.Size(161, 18);
            this.LblBuchungsDateiAnzeige.TabIndex = 6;
            this.LblBuchungsDateiAnzeige.Text = "Keine Datei ausgewählt";
            // 
            // MigrationsTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 551);
            this.Controls.Add(this.LblBuchungsDateiAnzeige);
            this.Controls.Add(this.CmdOpenBuchungsDaten);
            this.Controls.Add(this.CmdVorschau);
            this.Controls.Add(this.LblDateiAnzeige);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdCloseWindow);
            this.Controls.Add(this.CmdOpenFile);
            this.Name = "MigrationsTool";
            this.Text = "Migrations Tool XRechnung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdOpenFile;
        private System.Windows.Forms.Button CmdCloseWindow;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDateiAnzeige;
        private System.Windows.Forms.Button CmdVorschau;
        private System.Windows.Forms.Button CmdOpenBuchungsDaten;
        private System.Windows.Forms.Label LblBuchungsDateiAnzeige;
    }
}

