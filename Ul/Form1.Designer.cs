namespace Ul
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPrzydzialPrac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownIloscZmian = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrzypiszPracePszczole = new System.Windows.Forms.Button();
            this.btnPrzepracujNastepnaZmiane = new System.Windows.Forms.Button();
            this.richTextBoxRaport = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIloscZmian)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrzypiszPracePszczole);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownIloscZmian);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxPrzydzialPrac);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydział prac robotnicom";
            // 
            // comboBoxPrzydzialPrac
            // 
            this.comboBoxPrzydzialPrac.FormattingEnabled = true;
            this.comboBoxPrzydzialPrac.Items.AddRange(new object[] {
            "Zbieranie nektaru",
            "Wytwarzanie miodu",
            "Pielęgnacja jaj",
            "Nauczanie pszczółek",
            "Utrzymanie ula",
            "Patrol z żądłami"});
            this.comboBoxPrzydzialPrac.Location = new System.Drawing.Point(6, 34);
            this.comboBoxPrzydzialPrac.Name = "comboBoxPrzydzialPrac";
            this.comboBoxPrzydzialPrac.Size = new System.Drawing.Size(149, 21);
            this.comboBoxPrzydzialPrac.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zadanie robotnicy:";
            // 
            // numericUpDownIloscZmian
            // 
            this.numericUpDownIloscZmian.Location = new System.Drawing.Point(177, 34);
            this.numericUpDownIloscZmian.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownIloscZmian.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIloscZmian.Name = "numericUpDownIloscZmian";
            this.numericUpDownIloscZmian.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownIloscZmian.TabIndex = 2;
            this.numericUpDownIloscZmian.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zmiany";
            // 
            // btnPrzypiszPracePszczole
            // 
            this.btnPrzypiszPracePszczole.Location = new System.Drawing.Point(6, 62);
            this.btnPrzypiszPracePszczole.Name = "btnPrzypiszPracePszczole";
            this.btnPrzypiszPracePszczole.Size = new System.Drawing.Size(149, 23);
            this.btnPrzypiszPracePszczole.TabIndex = 4;
            this.btnPrzypiszPracePszczole.Text = "Przypisz tę pracę pszczole";
            this.btnPrzypiszPracePszczole.UseVisualStyleBackColor = true;
            // 
            // btnPrzepracujNastepnaZmiane
            // 
            this.btnPrzepracujNastepnaZmiane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzepracujNastepnaZmiane.Location = new System.Drawing.Point(263, 21);
            this.btnPrzepracujNastepnaZmiane.Name = "btnPrzepracujNastepnaZmiane";
            this.btnPrzepracujNastepnaZmiane.Size = new System.Drawing.Size(87, 91);
            this.btnPrzepracujNastepnaZmiane.TabIndex = 1;
            this.btnPrzepracujNastepnaZmiane.Text = "Przepracuj następną zmianę";
            this.btnPrzepracujNastepnaZmiane.UseVisualStyleBackColor = true;
            // 
            // richTextBoxRaport
            // 
            this.richTextBoxRaport.Location = new System.Drawing.Point(13, 119);
            this.richTextBoxRaport.Name = "richTextBoxRaport";
            this.richTextBoxRaport.Size = new System.Drawing.Size(337, 130);
            this.richTextBoxRaport.TabIndex = 2;
            this.richTextBoxRaport.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.richTextBoxRaport);
            this.Controls.Add(this.btnPrzepracujNastepnaZmiane);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "System zarządzania ulem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIloscZmian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPrzydzialPrac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrzypiszPracePszczole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownIloscZmian;
        private System.Windows.Forms.Button btnPrzepracujNastepnaZmiane;
        private System.Windows.Forms.RichTextBox richTextBoxRaport;
    }
}

