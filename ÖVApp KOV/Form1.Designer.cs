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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_Abfahrtsort = new System.Windows.Forms.ComboBox();
            this.comboBox_Ankunftsort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Suchen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_Mail = new System.Windows.Forms.Button();
            this.listBox_Ausgabe = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Help = new System.Windows.Forms.Button();
            this.button_Sponoring = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Abfahrtsort
            // 
            this.comboBox_Abfahrtsort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox_Abfahrtsort.FormattingEnabled = true;
            this.comboBox_Abfahrtsort.Location = new System.Drawing.Point(14, 76);
            this.comboBox_Abfahrtsort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Abfahrtsort.Name = "comboBox_Abfahrtsort";
            this.comboBox_Abfahrtsort.Size = new System.Drawing.Size(232, 21);
            this.comboBox_Abfahrtsort.TabIndex = 0;
            this.comboBox_Abfahrtsort.TextUpdate += new System.EventHandler(this.comboBox_Abfahrtsort_TextUpdate);
            // 
            // comboBox_Ankunftsort
            // 
            this.comboBox_Ankunftsort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox_Ankunftsort.FormattingEnabled = true;
            this.comboBox_Ankunftsort.Location = new System.Drawing.Point(393, 76);
            this.comboBox_Ankunftsort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Ankunftsort.Name = "comboBox_Ankunftsort";
            this.comboBox_Ankunftsort.Size = new System.Drawing.Size(237, 21);
            this.comboBox_Ankunftsort.TabIndex = 1;
            this.comboBox_Ankunftsort.TextUpdate += new System.EventHandler(this.comboBox_Ankunftsort_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "-->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abfahrtsort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ankunftsort:";
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Suchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suchen.Location = new System.Drawing.Point(9, 285);
            this.btn_Suchen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(620, 167);
            this.btn_Suchen.TabIndex = 5;
            this.btn_Suchen.Text = "Suchen";
            this.btn_Suchen.UseVisualStyleBackColor = false;
            this.btn_Suchen.Click += new System.EventHandler(this.btn_Suchen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(9, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 1);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Abfahrtszeit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dauer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(505, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ankuftszeit";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // button_Mail
            // 
            this.button_Mail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Mail.Location = new System.Drawing.Point(14, 3);
            this.button_Mail.Name = "button_Mail";
            this.button_Mail.Size = new System.Drawing.Size(616, 32);
            this.button_Mail.TabIndex = 13;
            this.button_Mail.Text = "Resultat via Mail Teilen";
            this.button_Mail.UseVisualStyleBackColor = true;
            this.button_Mail.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_Ausgabe
            // 
            this.listBox_Ausgabe.BackColor = System.Drawing.Color.AliceBlue;
            this.listBox_Ausgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Ausgabe.FormattingEnabled = true;
            this.listBox_Ausgabe.ItemHeight = 22;
            this.listBox_Ausgabe.Location = new System.Drawing.Point(9, 161);
            this.listBox_Ausgabe.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Ausgabe.Name = "listBox_Ausgabe";
            this.listBox_Ausgabe.Size = new System.Drawing.Size(620, 114);
            this.listBox_Ausgabe.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button_Help
            // 
            this.button_Help.BackColor = System.Drawing.Color.HotPink;
            this.button_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Help.Location = new System.Drawing.Point(9, 457);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(502, 40);
            this.button_Help.TabIndex = 14;
            this.button_Help.Text = "Bei fragen klicken Sie bitte hier drauf, Sie werden sofort eine Lösung finden";
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // button_Sponoring
            // 
            this.button_Sponoring.BackColor = System.Drawing.Color.Red;
            this.button_Sponoring.Location = new System.Drawing.Point(518, 457);
            this.button_Sponoring.Name = "button_Sponoring";
            this.button_Sponoring.Size = new System.Drawing.Size(108, 40);
            this.button_Sponoring.TabIndex = 15;
            this.button_Sponoring.Text = "Sponsoring";
            this.button_Sponoring.UseVisualStyleBackColor = false;
            this.button_Sponoring.Click += new System.EventHandler(this.button_Sponoring_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Suchen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(638, 499);
            this.Controls.Add(this.button_Sponoring);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.button_Mail);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox_Ausgabe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Suchen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Ankunftsort);
            this.Controls.Add(this.comboBox_Abfahrtsort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sibirische Eisenbahn";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_Mail;
        private System.Windows.Forms.ListBox listBox_Ausgabe;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Button button_Sponoring;
    }
}

