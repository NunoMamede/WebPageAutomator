namespace WebPageAutomator
{
    partial class View
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testCasePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.url_txt = new System.Windows.Forms.TextBox();
            this.testStepsPanel = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loggerPanel = new System.Windows.Forms.Panel();
            this.logger_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.testCasePanel.SuspendLayout();
            this.testStepsPanel.SuspendLayout();
            this.loggerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(191, 263);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(280, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(245, 29);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "WebPageAutomator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(488, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // testCasePanel
            // 
            this.testCasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testCasePanel.Controls.Add(this.label1);
            this.testCasePanel.Controls.Add(this.url_txt);
            this.testCasePanel.Controls.Add(this.testStepsPanel);
            this.testCasePanel.Controls.Add(this.start_btn);
            this.testCasePanel.Location = new System.Drawing.Point(12, 51);
            this.testCasePanel.Name = "testCasePanel";
            this.testCasePanel.Size = new System.Drawing.Size(470, 300);
            this.testCasePanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // url_txt
            // 
            this.url_txt.Location = new System.Drawing.Point(96, 18);
            this.url_txt.Name = "url_txt";
            this.url_txt.Size = new System.Drawing.Size(361, 20);
            this.url_txt.TabIndex = 2;
            this.url_txt.Text = "https://www.portal.uab.pt/";
            // 
            // testStepsPanel
            // 
            this.testStepsPanel.Controls.Add(this.textBox7);
            this.testStepsPanel.Controls.Add(this.textBox6);
            this.testStepsPanel.Controls.Add(this.textBox5);
            this.testStepsPanel.Controls.Add(this.textBox4);
            this.testStepsPanel.Controls.Add(this.textBox3);
            this.testStepsPanel.Controls.Add(this.textBox2);
            this.testStepsPanel.Controls.Add(this.textBox1);
            this.testStepsPanel.Controls.Add(this.comboBox7);
            this.testStepsPanel.Controls.Add(this.comboBox6);
            this.testStepsPanel.Controls.Add(this.comboBox5);
            this.testStepsPanel.Controls.Add(this.comboBox4);
            this.testStepsPanel.Controls.Add(this.comboBox3);
            this.testStepsPanel.Controls.Add(this.comboBox2);
            this.testStepsPanel.Controls.Add(this.comboBox1);
            this.testStepsPanel.Location = new System.Drawing.Point(12, 54);
            this.testStepsPanel.Name = "testStepsPanel";
            this.testStepsPanel.Size = new System.Drawing.Size(445, 203);
            this.testStepsPanel.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(194, 173);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(238, 20);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(194, 147);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(238, 20);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(194, 120);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(238, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(194, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(15, 174);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(173, 21);
            this.comboBox7.TabIndex = 6;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(15, 147);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(173, 21);
            this.comboBox6.TabIndex = 5;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(15, 120);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(173, 21);
            this.comboBox5.TabIndex = 4;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(15, 93);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(173, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(15, 66);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(173, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // loggerPanel
            // 
            this.loggerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loggerPanel.Controls.Add(this.logger_lbl);
            this.loggerPanel.Location = new System.Drawing.Point(12, 357);
            this.loggerPanel.Name = "loggerPanel";
            this.loggerPanel.Size = new System.Drawing.Size(776, 114);
            this.loggerPanel.TabIndex = 4;
            // 
            // logger_lbl
            // 
            this.logger_lbl.Location = new System.Drawing.Point(5, 4);
            this.logger_lbl.Name = "logger_lbl";
            this.logger_lbl.Size = new System.Drawing.Size(765, 105);
            this.logger_lbl.TabIndex = 0;
            this.logger_lbl.Text = "Logger";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.loggerPanel);
            this.Controls.Add(this.testCasePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title_lbl);
            this.Name = "View";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.testCasePanel.ResumeLayout(false);
            this.testCasePanel.PerformLayout();
            this.testStepsPanel.ResumeLayout(false);
            this.testStepsPanel.PerformLayout();
            this.loggerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel testCasePanel;
        private System.Windows.Forms.Panel testStepsPanel;
        private System.Windows.Forms.Panel loggerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url_txt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label logger_lbl;
    }
}

