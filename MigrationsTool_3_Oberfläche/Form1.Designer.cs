
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
            this.SuspendLayout();
            // 
            // CmdOpenFile
            // 
            this.CmdOpenFile.Location = new System.Drawing.Point(56, 307);
            this.CmdOpenFile.Name = "CmdOpenFile";
            this.CmdOpenFile.Size = new System.Drawing.Size(75, 23);
            this.CmdOpenFile.TabIndex = 0;
            this.CmdOpenFile.Text = "Datei Öffnen";
            this.CmdOpenFile.UseVisualStyleBackColor = true;
            this.CmdOpenFile.Click += new System.EventHandler(this.CmdOpenFile_Click);
            // 
            // CmdCloseWindow
            // 
            this.CmdCloseWindow.Location = new System.Drawing.Point(652, 307);
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
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bitte wählen Sie ein XML-Datei aus. ";
            // 
            // LblDateiAnzeige
            // 
            this.LblDateiAnzeige.AutoSize = true;
            this.LblDateiAnzeige.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateiAnzeige.Location = new System.Drawing.Point(201, 308);
            this.LblDateiAnzeige.Name = "LblDateiAnzeige";
            this.LblDateiAnzeige.Size = new System.Drawing.Size(161, 18);
            this.LblDateiAnzeige.TabIndex = 3;
            this.LblDateiAnzeige.Text = "Keine Datei ausgewählt";
            // 
            // CmdVorschau
            // 
            this.CmdVorschau.Location = new System.Drawing.Point(56, 363);
            this.CmdVorschau.Name = "CmdVorschau";
            this.CmdVorschau.Size = new System.Drawing.Size(75, 23);
            this.CmdVorschau.TabIndex = 4;
            this.CmdVorschau.Text = "Vorschau";
            this.CmdVorschau.UseVisualStyleBackColor = true;
            // 
            // MigrationsTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

