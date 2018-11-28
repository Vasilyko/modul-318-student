namespace ÖVApp_KOV
{
    partial class Form1
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
            this.comboBox_Abfahrtsort = new System.Windows.Forms.ComboBox();
            this.comboBox_Ankunftsort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Suchen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_Ausgabe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBox_Abfahrtsort
            // 
            this.comboBox_Abfahrtsort.FormattingEnabled = true;
            this.comboBox_Abfahrtsort.Location = new System.Drawing.Point(12, 94);
            this.comboBox_Abfahrtsort.Name = "comboBox_Abfahrtsort";
            this.comboBox_Abfahrtsort.Size = new System.Drawing.Size(315, 24);
            this.comboBox_Abfahrtsort.TabIndex = 0;
            this.comboBox_Abfahrtsort.TextUpdate += new System.EventHandler(this.comboBox_Abfahrtsort_TextUpdate);
            // 
            // comboBox_Ankunftsort
            // 
            this.comboBox_Ankunftsort.FormattingEnabled = true;
            this.comboBox_Ankunftsort.Location = new System.Drawing.Point(524, 94);
            this.comboBox_Ankunftsort.Name = "comboBox_Ankunftsort";
            this.comboBox_Ankunftsort.Size = new System.Drawing.Size(315, 24);
            this.comboBox_Ankunftsort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "-->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abfahrtsort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ankunftsort:";
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.Location = new System.Drawing.Point(12, 455);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(827, 101);
            this.btn_Suchen.TabIndex = 5;
            this.btn_Suchen.Text = "Suchen";
            this.btn_Suchen.UseVisualStyleBackColor = true;
            this.btn_Suchen.Click += new System.EventHandler(this.btn_Suchen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(827, 36);
            this.progressBar1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 1);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Abfahrtszeit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dauer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(673, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ankuftszeit";
            // 
            // listBox_Ausgabe
            // 
            this.listBox_Ausgabe.FormattingEnabled = true;
            this.listBox_Ausgabe.ItemHeight = 16;
            this.listBox_Ausgabe.Location = new System.Drawing.Point(12, 198);
            this.listBox_Ausgabe.Name = "listBox_Ausgabe";
            this.listBox_Ausgabe.Size = new System.Drawing.Size(826, 244);
            this.listBox_Ausgabe.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 564);
            this.Controls.Add(this.listBox_Ausgabe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Suchen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Ankunftsort);
            this.Controls.Add(this.comboBox_Abfahrtsort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Russianbahn 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Abfahrtsort;
        private System.Windows.Forms.ComboBox comboBox_Ankunftsort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Suchen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox_Ausgabe;
    }
}

