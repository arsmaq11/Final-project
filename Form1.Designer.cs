namespace blue
{
    partial class text2image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(text2image));
            this.WRITE = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.stylefon1 = new System.Windows.Forms.Label();
            this.sifont2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.styfont1 = new System.Windows.Forms.ListBox();
            this.fontsiz2 = new System.Windows.Forms.ListBox();
            this.Height1 = new System.Windows.Forms.ListBox();
            this.pictureup = new System.Windows.Forms.PictureBox();
            this.width2 = new System.Windows.Forms.ListBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureup)).BeginInit();
            this.SuspendLayout();
            // 
            // WRITE
            // 
            this.WRITE.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.WRITE.BackColor = System.Drawing.SystemColors.Info;
            this.WRITE.Location = new System.Drawing.Point(3, 12);
            this.WRITE.MaxLength = 500;
            this.WRITE.Name = "WRITE";
            this.WRITE.Size = new System.Drawing.Size(263, 194);
            this.WRITE.TabIndex = 1;
            this.WRITE.Text = "";
            this.WRITE.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.height.Location = new System.Drawing.Point(407, 309);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(44, 13);
            this.height.TabIndex = 10;
            this.height.Text = "Height";
            // 
            // stylefon1
            // 
            this.stylefon1.AutoSize = true;
            this.stylefon1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stylefon1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.stylefon1.Location = new System.Drawing.Point(209, 305);
            this.stylefon1.Name = "stylefon1";
            this.stylefon1.Size = new System.Drawing.Size(36, 13);
            this.stylefon1.TabIndex = 14;
            this.stylefon1.Text = " Font";
            this.stylefon1.Click += new System.EventHandler(this.label6_Click);
            // 
            // sifont2
            // 
            this.sifont2.AutoSize = true;
            this.sifont2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sifont2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sifont2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sifont2.ImageKey = "(none)";
            this.sifont2.Location = new System.Drawing.Point(613, 309);
            this.sifont2.Name = "sifont2";
            this.sifont2.Size = new System.Drawing.Size(35, 13);
            this.sifont2.TabIndex = 15;
            this.sifont2.Text = "Size ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(503, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 64);
            this.button1.TabIndex = 17;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // styfont1
            // 
            this.styfont1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.styfont1.FormattingEnabled = true;
            this.styfont1.Items.AddRange(new object[] {
            "Arial",
            "Times new roman",
            "Sn franscisco"});
            this.styfont1.Location = new System.Drawing.Point(268, 305);
            this.styfont1.Name = "styfont1";
            this.styfont1.Size = new System.Drawing.Size(120, 17);
            this.styfont1.TabIndex = 19;
            this.styfont1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // fontsiz2
            // 
            this.fontsiz2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.fontsiz2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.fontsiz2.FormattingEnabled = true;
            this.fontsiz2.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.fontsiz2.Location = new System.Drawing.Point(654, 305);
            this.fontsiz2.Name = "fontsiz2";
            this.fontsiz2.Size = new System.Drawing.Size(120, 17);
            this.fontsiz2.TabIndex = 20;
            this.fontsiz2.SelectedIndexChanged += new System.EventHandler(this.fontsiz2_SelectedIndexChanged);
            // 
            // Height1
            // 
            this.Height1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Height1.FormattingEnabled = true;
            this.Height1.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.Height1.Location = new System.Drawing.Point(467, 305);
            this.Height1.Name = "Height1";
            this.Height1.Size = new System.Drawing.Size(120, 17);
            this.Height1.TabIndex = 21;
            this.Height1.SelectedIndexChanged += new System.EventHandler(this.Height1_SelectedIndexChanged);
            // 
            // pictureup
            // 
            this.pictureup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureup.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureup.BackgroundImage")));
            this.pictureup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureup.Location = new System.Drawing.Point(803, 4);
            this.pictureup.Name = "pictureup";
            this.pictureup.Size = new System.Drawing.Size(250, 192);
            this.pictureup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureup.TabIndex = 23;
            this.pictureup.TabStop = false;
            this.pictureup.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // width2
            // 
            this.width2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.width2.FormattingEnabled = true;
            this.width2.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.width2.Location = new System.Drawing.Point(83, 305);
            this.width2.Name = "width2";
            this.width2.Size = new System.Drawing.Size(120, 17);
            this.width2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Location = new System.Drawing.Point(19, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(899, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "upload";
            // 
            // text2image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1148, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.width2);
            this.Controls.Add(this.pictureup);
            this.Controls.Add(this.Height1);
            this.Controls.Add(this.fontsiz2);
            this.Controls.Add(this.styfont1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifont2);
            this.Controls.Add(this.stylefon1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WRITE);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(1164, 1000);
            this.Name = "text2image";
            this.Text = "text2image";
            this.Load += new System.EventHandler(this.text2image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox WRITE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label stylefon1;
        private System.Windows.Forms.Label sifont2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox styfont1;
        private System.Windows.Forms.ListBox fontsiz2;
        private System.Windows.Forms.ListBox Height1;
        private System.Windows.Forms.PictureBox pictureup;
        private System.Windows.Forms.ListBox width2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}

