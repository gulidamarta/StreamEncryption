namespace WindowsFormsApp4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnEncryption = new System.Windows.Forms.Button();
            this.textBoxInitialKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.openFileDialogFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogFile = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonLFSR1 = new System.Windows.Forms.RadioButton();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbPlainText = new System.Windows.Forms.RichTextBox();
            this.rbCypherText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGeneratedKey = new System.Windows.Forms.TextBox();
            this.radioButtonGeffeGenerator = new System.Windows.Forms.RadioButton();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.richTextBoxInitialKey = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLFSR2 = new System.Windows.Forms.RichTextBox();
            this.lblTitleLFSR1 = new System.Windows.Forms.Label();
            this.richTextBoxLFSR3 = new System.Windows.Forms.RichTextBox();
            this.textBoxLFSR3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTitleLFSR3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLFSR2 = new System.Windows.Forms.TextBox();
            this.textBoxResultKey = new System.Windows.Forms.TextBox();
            this.lblTitleResKey = new System.Windows.Forms.Label();
            this.radioButtonRC4 = new System.Windows.Forms.RadioButton();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncryption
            // 
            this.btnEncryption.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncryption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEncryption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncryption.Location = new System.Drawing.Point(381, 508);
            this.btnEncryption.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(157, 32);
            this.btnEncryption.TabIndex = 0;
            this.btnEncryption.Text = "Encryption";
            this.btnEncryption.UseVisualStyleBackColor = false;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncrDecr_Click);
            // 
            // textBoxInitialKey
            // 
            this.textBoxInitialKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInitialKey.Location = new System.Drawing.Point(379, 38);
            this.textBoxInitialKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInitialKey.MaxLength = 25;
            this.textBoxInitialKey.Name = "textBoxInitialKey";
            this.textBoxInitialKey.Size = new System.Drawing.Size(159, 21);
            this.textBoxInitialKey.TabIndex = 1;
            this.textBoxInitialKey.Visible = false;
            this.textBoxInitialKey.TextChanged += new System.EventHandler(this.textBoxInitialKey_TextChanged);
            this.textBoxInitialKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInitialKey_KeyDown);
            this.textBoxInitialKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInitialKey_KeyPress);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey.Location = new System.Drawing.Point(381, 129);
            this.labelKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(82, 15);
            this.labelKey.TabIndex = 2;
            this.labelKey.Text = "Key(LFSR1) : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(376, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose cypher : ";
            // 
            // radioButtonLFSR1
            // 
            this.radioButtonLFSR1.AutoSize = true;
            this.radioButtonLFSR1.Checked = true;
            this.radioButtonLFSR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonLFSR1.Location = new System.Drawing.Point(379, 56);
            this.radioButtonLFSR1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonLFSR1.Name = "radioButtonLFSR1";
            this.radioButtonLFSR1.Size = new System.Drawing.Size(134, 17);
            this.radioButtonLFSR1.TabIndex = 5;
            this.radioButtonLFSR1.TabStop = true;
            this.radioButtonLFSR1.Text = "LFSR1(x^25 + x^3 + 1)";
            this.radioButtonLFSR1.UseVisualStyleBackColor = true;
            this.radioButtonLFSR1.Enter += new System.EventHandler(this.radioButtonLFSR1_Enter);
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStripMain.Size = new System.Drawing.Size(929, 24);
            this.menuStripMain.TabIndex = 7;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // rbPlainText
            // 
            this.rbPlainText.Location = new System.Drawing.Point(8, 38);
            this.rbPlainText.Margin = new System.Windows.Forms.Padding(2);
            this.rbPlainText.MaxLength = 10000;
            this.rbPlainText.Name = "rbPlainText";
            this.rbPlainText.ReadOnly = true;
            this.rbPlainText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rbPlainText.Size = new System.Drawing.Size(350, 538);
            this.rbPlainText.TabIndex = 10;
            this.rbPlainText.Text = "";
            // 
            // rbCypherText
            // 
            this.rbCypherText.Location = new System.Drawing.Point(563, 38);
            this.rbCypherText.Margin = new System.Windows.Forms.Padding(2);
            this.rbCypherText.MaxLength = 100000;
            this.rbCypherText.Name = "rbCypherText";
            this.rbCypherText.ReadOnly = true;
            this.rbCypherText.Size = new System.Drawing.Size(350, 538);
            this.rbCypherText.TabIndex = 11;
            this.rbCypherText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(139, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Plain Text :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(645, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cipher Text :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(383, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Generated Key : ";
            // 
            // textBoxGeneratedKey
            // 
            this.textBoxGeneratedKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGeneratedKey.Location = new System.Drawing.Point(383, 211);
            this.textBoxGeneratedKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGeneratedKey.MaxLength = 100000;
            this.textBoxGeneratedKey.Name = "textBoxGeneratedKey";
            this.textBoxGeneratedKey.ReadOnly = true;
            this.textBoxGeneratedKey.Size = new System.Drawing.Size(159, 21);
            this.textBoxGeneratedKey.TabIndex = 15;
            // 
            // radioButtonGeffeGenerator
            // 
            this.radioButtonGeffeGenerator.AutoSize = true;
            this.radioButtonGeffeGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGeffeGenerator.Location = new System.Drawing.Point(379, 77);
            this.radioButtonGeffeGenerator.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonGeffeGenerator.Name = "radioButtonGeffeGenerator";
            this.radioButtonGeffeGenerator.Size = new System.Drawing.Size(101, 17);
            this.radioButtonGeffeGenerator.TabIndex = 16;
            this.radioButtonGeffeGenerator.Text = "Geffe Generator";
            this.radioButtonGeffeGenerator.UseVisualStyleBackColor = true;
            this.radioButtonGeffeGenerator.Enter += new System.EventHandler(this.radioButtonGeffeGenerator_Enter);
            // 
            // btnDecryption
            // 
            this.btnDecryption.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDecryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecryption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecryption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDecryption.Location = new System.Drawing.Point(381, 544);
            this.btnDecryption.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(157, 32);
            this.btnDecryption.TabIndex = 18;
            this.btnDecryption.Text = "Decryphtion";
            this.btnDecryption.UseVisualStyleBackColor = false;
            this.btnDecryption.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxInitialKey
            // 
            this.richTextBoxInitialKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInitialKey.Location = new System.Drawing.Point(381, 148);
            this.richTextBoxInitialKey.MaxLength = 25;
            this.richTextBoxInitialKey.Name = "richTextBoxInitialKey";
            this.richTextBoxInitialKey.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxInitialKey.Size = new System.Drawing.Size(157, 43);
            this.richTextBoxInitialKey.TabIndex = 19;
            this.richTextBoxInitialKey.Text = "";
            this.richTextBoxInitialKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxInitialKey_KeyDown);
            // 
            // richTextBoxLFSR2
            // 
            this.richTextBoxLFSR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxLFSR2.Location = new System.Drawing.Point(384, 258);
            this.richTextBoxLFSR2.MaxLength = 33;
            this.richTextBoxLFSR2.Name = "richTextBoxLFSR2";
            this.richTextBoxLFSR2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxLFSR2.Size = new System.Drawing.Size(157, 43);
            this.richTextBoxLFSR2.TabIndex = 24;
            this.richTextBoxLFSR2.Text = "";
            this.richTextBoxLFSR2.Visible = false;
            this.richTextBoxLFSR2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxLFSR2_KeyDown);
            // 
            // lblTitleLFSR1
            // 
            this.lblTitleLFSR1.AutoSize = true;
            this.lblTitleLFSR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleLFSR1.Location = new System.Drawing.Point(384, 239);
            this.lblTitleLFSR1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleLFSR1.Name = "lblTitleLFSR1";
            this.lblTitleLFSR1.Size = new System.Drawing.Size(82, 15);
            this.lblTitleLFSR1.TabIndex = 21;
            this.lblTitleLFSR1.Text = "Key(LFSR2) : ";
            this.lblTitleLFSR1.Visible = false;
            // 
            // richTextBoxLFSR3
            // 
            this.richTextBoxLFSR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxLFSR3.Location = new System.Drawing.Point(384, 368);
            this.richTextBoxLFSR3.MaxLength = 23;
            this.richTextBoxLFSR3.Name = "richTextBoxLFSR3";
            this.richTextBoxLFSR3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxLFSR3.Size = new System.Drawing.Size(157, 43);
            this.richTextBoxLFSR3.TabIndex = 28;
            this.richTextBoxLFSR3.Text = "";
            this.richTextBoxLFSR3.Visible = false;
            this.richTextBoxLFSR3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxLFSR3_KeyDown);
            // 
            // textBoxLFSR3
            // 
            this.textBoxLFSR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLFSR3.Location = new System.Drawing.Point(386, 431);
            this.textBoxLFSR3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLFSR3.MaxLength = 100000;
            this.textBoxLFSR3.Name = "textBoxLFSR3";
            this.textBoxLFSR3.ReadOnly = true;
            this.textBoxLFSR3.Size = new System.Drawing.Size(159, 21);
            this.textBoxLFSR3.TabIndex = 27;
            this.textBoxLFSR3.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(386, 414);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Generated Key : ";
            this.label7.Visible = false;
            // 
            // lblTitleLFSR3
            // 
            this.lblTitleLFSR3.AutoSize = true;
            this.lblTitleLFSR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleLFSR3.Location = new System.Drawing.Point(384, 349);
            this.lblTitleLFSR3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleLFSR3.Name = "lblTitleLFSR3";
            this.lblTitleLFSR3.Size = new System.Drawing.Size(82, 15);
            this.lblTitleLFSR3.TabIndex = 25;
            this.lblTitleLFSR3.Text = "Key(LFSR3) : ";
            this.lblTitleLFSR3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(386, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Generated Key : ";
            this.label5.Visible = false;
            this.label5.Enter += new System.EventHandler(this.label5_Enter);
            // 
            // textBoxLFSR2
            // 
            this.textBoxLFSR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLFSR2.Location = new System.Drawing.Point(386, 321);
            this.textBoxLFSR2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLFSR2.MaxLength = 100000;
            this.textBoxLFSR2.Name = "textBoxLFSR2";
            this.textBoxLFSR2.ReadOnly = true;
            this.textBoxLFSR2.Size = new System.Drawing.Size(159, 21);
            this.textBoxLFSR2.TabIndex = 23;
            this.textBoxLFSR2.Visible = false;
            // 
            // textBoxResultKey
            // 
            this.textBoxResultKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultKey.Location = new System.Drawing.Point(386, 480);
            this.textBoxResultKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResultKey.MaxLength = 128;
            this.textBoxResultKey.Name = "textBoxResultKey";
            this.textBoxResultKey.ReadOnly = true;
            this.textBoxResultKey.Size = new System.Drawing.Size(159, 21);
            this.textBoxResultKey.TabIndex = 30;
            this.textBoxResultKey.Visible = false;
            this.textBoxResultKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTitleResKey
            // 
            this.lblTitleResKey.AutoSize = true;
            this.lblTitleResKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleResKey.Location = new System.Drawing.Point(386, 463);
            this.lblTitleResKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleResKey.Name = "lblTitleResKey";
            this.lblTitleResKey.Size = new System.Drawing.Size(129, 15);
            this.lblTitleResKey.TabIndex = 29;
            this.lblTitleResKey.Text = "Geffe Generated Key : ";
            this.lblTitleResKey.Visible = false;
            this.lblTitleResKey.Click += new System.EventHandler(this.label6_Click);
            // 
            // radioButtonRC4
            // 
            this.radioButtonRC4.AutoSize = true;
            this.radioButtonRC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonRC4.Location = new System.Drawing.Point(379, 98);
            this.radioButtonRC4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRC4.Name = "radioButtonRC4";
            this.radioButtonRC4.Size = new System.Drawing.Size(46, 17);
            this.radioButtonRC4.TabIndex = 31;
            this.radioButtonRC4.Text = "RC4";
            this.radioButtonRC4.UseVisualStyleBackColor = true;
            this.radioButtonRC4.Enter += new System.EventHandler(this.radioButtonRC4_Enter_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 581);
            this.Controls.Add(this.radioButtonRC4);
            this.Controls.Add(this.textBoxResultKey);
            this.Controls.Add(this.lblTitleResKey);
            this.Controls.Add(this.richTextBoxLFSR3);
            this.Controls.Add(this.textBoxLFSR3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTitleLFSR3);
            this.Controls.Add(this.richTextBoxLFSR2);
            this.Controls.Add(this.textBoxLFSR2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitleLFSR1);
            this.Controls.Add(this.richTextBoxInitialKey);
            this.Controls.Add(this.btnDecryption);
            this.Controls.Add(this.radioButtonGeffeGenerator);
            this.Controls.Add(this.textBoxGeneratedKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbCypherText);
            this.Controls.Add(this.rbPlainText);
            this.Controls.Add(this.radioButtonLFSR1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxInitialKey);
            this.Controls.Add(this.btnEncryption);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потоковое шифрование, Гулида М.А., 751001";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.TextBox textBoxInitialKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.OpenFileDialog openFileDialogFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonLFSR1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rbPlainText;
        private System.Windows.Forms.RichTextBox rbCypherText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGeneratedKey;
        private System.Windows.Forms.RadioButton radioButtonGeffeGenerator;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.RichTextBox richTextBoxInitialKey;
        private System.Windows.Forms.RichTextBox richTextBoxLFSR2;
        private System.Windows.Forms.Label lblTitleLFSR1;
        private System.Windows.Forms.RichTextBox richTextBoxLFSR3;
        private System.Windows.Forms.TextBox textBoxLFSR3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTitleLFSR3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLFSR2;
        private System.Windows.Forms.TextBox textBoxResultKey;
        private System.Windows.Forms.Label lblTitleResKey;
        private System.Windows.Forms.RadioButton radioButtonRC4;
    }
}

