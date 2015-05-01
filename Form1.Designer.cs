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
            this.sifont2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fontsiz2 = new System.Windows.Forms.ListBox();
            this.Height1 = new System.Windows.Forms.ListBox();
            this.pictureup = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureup)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WRITE
            // 
            this.WRITE.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.WRITE.BackColor = System.Drawing.SystemColors.Info;
            this.WRITE.Location = new System.Drawing.Point(12, 52);
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
            this.button1.Location = new System.Drawing.Point(495, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 64);
            this.button1.TabIndex = 17;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.pictureup.Location = new System.Drawing.Point(793, 52);
            this.pictureup.Name = "pictureup";
            this.pictureup.Size = new System.Drawing.Size(250, 192);
            this.pictureup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureup.TabIndex = 23;
            this.pictureup.TabStop = false;
            this.pictureup.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.feedbackToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewHelpToolStripMenuItem.Text = "View help";
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.feedbackToolStripMenuItem.Text = "feedback";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewToolStripMenuItem.Text = "view";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // text2image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1148, 750);
            this.Controls.Add(this.pictureup);
            this.Controls.Add(this.Height1);
            this.Controls.Add(this.fontsiz2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifont2);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WRITE);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1164, 1000);
            this.Name = "text2image";
            this.Text = "text2image";
            this.Load += new System.EventHandler(this.text2image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureup)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox WRITE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label sifont2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox fontsiz2;
        private System.Windows.Forms.ListBox Height1;
        private System.Windows.Forms.PictureBox pictureup;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
    }
}

