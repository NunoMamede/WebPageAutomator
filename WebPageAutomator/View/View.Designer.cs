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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.start_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.screenshotBox = new System.Windows.Forms.PictureBox();
            this.testCasePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.url_txt = new System.Windows.Forms.TextBox();
            this.testStepsPanel = new System.Windows.Forms.Panel();
            this.teststepsTable = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.loggerPanel = new System.Windows.Forms.Panel();
            this.logger_lbl = new System.Windows.Forms.Label();
            this.addRow_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotBox)).BeginInit();
            this.testCasePanel.SuspendLayout();
            this.testStepsPanel.SuspendLayout();
            this.teststepsTable.SuspendLayout();
            this.loggerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(205, 415);
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
            this.title_lbl.Location = new System.Drawing.Point(123, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(245, 29);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "WebPageAutomator";
            // 
            // screenshotBox
            // 
            this.screenshotBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenshotBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("screenshotBox.InitialImage")));
            this.screenshotBox.Location = new System.Drawing.Point(488, 51);
            this.screenshotBox.Name = "screenshotBox";
            this.screenshotBox.Size = new System.Drawing.Size(770, 388);
            this.screenshotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screenshotBox.TabIndex = 2;
            this.screenshotBox.TabStop = false;
            // 
            // testCasePanel
            // 
            this.testCasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testCasePanel.Controls.Add(this.label1);
            this.testCasePanel.Controls.Add(this.url_txt);
            this.testCasePanel.Controls.Add(this.testStepsPanel);
            this.testCasePanel.Location = new System.Drawing.Point(12, 51);
            this.testCasePanel.Name = "testCasePanel";
            this.testCasePanel.Size = new System.Drawing.Size(470, 358);
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
            this.testStepsPanel.AutoScroll = true;
            this.testStepsPanel.Controls.Add(this.teststepsTable);
            this.testStepsPanel.Location = new System.Drawing.Point(3, 44);
            this.testStepsPanel.Name = "testStepsPanel";
            this.testStepsPanel.Size = new System.Drawing.Size(466, 309);
            this.testStepsPanel.TabIndex = 1;
            // 
            // teststepsTable
            // 
            this.teststepsTable.AutoSize = true;
            this.teststepsTable.ColumnCount = 2;
            this.teststepsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.08909F));
            this.teststepsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.91091F));
            this.teststepsTable.Controls.Add(this.comboBox1, 0, 0);
            this.teststepsTable.Controls.Add(this.comboBox2, 0, 1);
            this.teststepsTable.Controls.Add(this.comboBox3, 0, 2);
            this.teststepsTable.Controls.Add(this.comboBox4, 0, 3);
            this.teststepsTable.Controls.Add(this.comboBox5, 0, 4);
            this.teststepsTable.Controls.Add(this.comboBox6, 0, 5);
            this.teststepsTable.Controls.Add(this.comboBox7, 0, 6);
            this.teststepsTable.Controls.Add(this.comboBox8, 0, 7);
            this.teststepsTable.Controls.Add(this.comboBox9, 0, 8);
            this.teststepsTable.Controls.Add(this.comboBox10, 0, 9);
            this.teststepsTable.Controls.Add(this.comboBox11, 0, 10);
            this.teststepsTable.Controls.Add(this.textBox1, 1, 0);
            this.teststepsTable.Controls.Add(this.textBox2, 1, 1);
            this.teststepsTable.Controls.Add(this.textBox3, 1, 2);
            this.teststepsTable.Controls.Add(this.textBox4, 1, 3);
            this.teststepsTable.Controls.Add(this.textBox5, 1, 4);
            this.teststepsTable.Controls.Add(this.textBox6, 1, 5);
            this.teststepsTable.Controls.Add(this.textBox7, 1, 6);
            this.teststepsTable.Controls.Add(this.textBox8, 1, 7);
            this.teststepsTable.Controls.Add(this.textBox9, 1, 8);
            this.teststepsTable.Controls.Add(this.textBox10, 1, 9);
            this.teststepsTable.Controls.Add(this.textBox11, 1, 10);
            this.teststepsTable.Location = new System.Drawing.Point(3, 3);
            this.teststepsTable.Name = "teststepsTable";
            this.teststepsTable.RowCount = 11;
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.teststepsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.teststepsTable.Size = new System.Drawing.Size(459, 297);
            this.teststepsTable.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 13;
            this.comboBox2.Location = new System.Drawing.Point(3, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 13;
            this.comboBox3.Location = new System.Drawing.Point(3, 57);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(173, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.ItemHeight = 13;
            this.comboBox4.Location = new System.Drawing.Point(3, 84);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(173, 21);
            this.comboBox4.TabIndex = 10;
            // 
            // comboBox5
            // 
            this.comboBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.ItemHeight = 13;
            this.comboBox5.Location = new System.Drawing.Point(3, 111);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(173, 21);
            this.comboBox5.TabIndex = 11;
            // 
            // comboBox6
            // 
            this.comboBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.ItemHeight = 13;
            this.comboBox6.Location = new System.Drawing.Point(3, 138);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(173, 21);
            this.comboBox6.TabIndex = 12;
            // 
            // comboBox7
            // 
            this.comboBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.ItemHeight = 13;
            this.comboBox7.Location = new System.Drawing.Point(3, 165);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(173, 21);
            this.comboBox7.TabIndex = 13;
            // 
            // comboBox8
            // 
            this.comboBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.ItemHeight = 13;
            this.comboBox8.Location = new System.Drawing.Point(3, 192);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(173, 21);
            this.comboBox8.TabIndex = 14;
            // 
            // comboBox9
            // 
            this.comboBox9.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.ItemHeight = 13;
            this.comboBox9.Location = new System.Drawing.Point(3, 219);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(173, 21);
            this.comboBox9.TabIndex = 15;
            // 
            // comboBox10
            // 
            this.comboBox10.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.ItemHeight = 13;
            this.comboBox10.Location = new System.Drawing.Point(3, 246);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(173, 21);
            this.comboBox10.TabIndex = 16;
            // 
            // comboBox11
            // 
            this.comboBox11.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.ItemHeight = 13;
            this.comboBox11.Location = new System.Drawing.Point(3, 273);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(173, 21);
            this.comboBox11.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(187, 84);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(266, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(187, 111);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(266, 20);
            this.textBox5.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(187, 138);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(266, 20);
            this.textBox6.TabIndex = 22;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(187, 165);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(266, 20);
            this.textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(187, 192);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(266, 20);
            this.textBox8.TabIndex = 24;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(187, 219);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(266, 20);
            this.textBox9.TabIndex = 25;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(187, 246);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(266, 20);
            this.textBox10.TabIndex = 26;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(187, 273);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(266, 20);
            this.textBox11.TabIndex = 27;
            // 
            // loggerPanel
            // 
            this.loggerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loggerPanel.Controls.Add(this.logger_lbl);
            this.loggerPanel.Location = new System.Drawing.Point(12, 445);
            this.loggerPanel.Name = "loggerPanel";
            this.loggerPanel.Size = new System.Drawing.Size(1246, 114);
            this.loggerPanel.TabIndex = 4;
            // 
            // logger_lbl
            // 
            this.logger_lbl.AutoSize = true;
            this.logger_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.logger_lbl.Location = new System.Drawing.Point(5, 4);
            this.logger_lbl.Name = "logger_lbl";
            this.logger_lbl.Size = new System.Drawing.Size(40, 13);
            this.logger_lbl.TabIndex = 0;
            this.logger_lbl.Text = "Logger";
            // 
            // addRow_btn
            // 
            this.addRow_btn.Enabled = false;
            this.addRow_btn.Location = new System.Drawing.Point(12, 416);
            this.addRow_btn.Name = "addRow_btn";
            this.addRow_btn.Size = new System.Drawing.Size(75, 23);
            this.addRow_btn.TabIndex = 5;
            this.addRow_btn.Text = "Add line";
            this.addRow_btn.UseVisualStyleBackColor = true;
            this.addRow_btn.Click += new System.EventHandler(this.addRow_btn_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 571);
            this.Controls.Add(this.addRow_btn);
            this.Controls.Add(this.loggerPanel);
            this.Controls.Add(this.testCasePanel);
            this.Controls.Add(this.screenshotBox);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.title_lbl);
            this.Name = "View";
            this.Text = "WebPageAutomator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screenshotBox)).EndInit();
            this.testCasePanel.ResumeLayout(false);
            this.testCasePanel.PerformLayout();
            this.testStepsPanel.ResumeLayout(false);
            this.testStepsPanel.PerformLayout();
            this.teststepsTable.ResumeLayout(false);
            this.teststepsTable.PerformLayout();
            this.loggerPanel.ResumeLayout(false);
            this.loggerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.PictureBox screenshotBox;
        private System.Windows.Forms.Panel testCasePanel;
        private System.Windows.Forms.Panel testStepsPanel;
        private System.Windows.Forms.Panel loggerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url_txt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label logger_lbl;
        private System.Windows.Forms.Button addRow_btn;
        private System.Windows.Forms.TableLayoutPanel teststepsTable;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
    }
}

