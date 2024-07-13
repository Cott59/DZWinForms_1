namespace DZWinForms_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Click_Mi = new Button();
            InfoText = new TextBox();
            SaveText = new Button();
            menuStrip1 = new MenuStrip();
            MyfileToolStripMenuItem = new ToolStripMenuItem();
            MyopenMenuItem = new ToolStripMenuItem();
            MysaveMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Click_Mi
            // 
            Click_Mi.BackColor = SystemColors.ButtonFace;
            Click_Mi.Cursor = Cursors.Hand;
            Click_Mi.ForeColor = Color.Teal;
            Click_Mi.Location = new Point(533, 93);
            Click_Mi.Name = "Click_Mi";
            Click_Mi.Size = new Size(85, 23);
            Click_Mi.TabIndex = 0;
            Click_Mi.Text = "Нажми";
            Click_Mi.UseVisualStyleBackColor = false;
            Click_Mi.MouseClick += Click_Mi_MouseClick;
            // 
            // InfoText
            // 
            InfoText.Location = new Point(12, 93);
            InfoText.Multiline = true;
            InfoText.Name = "InfoText";
            InfoText.RightToLeft = RightToLeft.No;
            InfoText.ScrollBars = ScrollBars.Vertical;
            InfoText.Size = new Size(347, 115);
            InfoText.TabIndex = 1;
            // 
            // SaveText
            // 
            SaveText.ImageAlign = ContentAlignment.MiddleLeft;
            SaveText.Location = new Point(12, 228);
            SaveText.Name = "SaveText";
            SaveText.Size = new Size(140, 36);
            SaveText.TabIndex = 2;
            SaveText.Text = "Сохранить текст";
            SaveText.UseVisualStyleBackColor = true;
            SaveText.Click += SaveText_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MyfileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // MyfileToolStripMenuItem
            // 
            MyfileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MyopenMenuItem, MysaveMenuItem });
            MyfileToolStripMenuItem.Name = "MyfileToolStripMenuItem";
            MyfileToolStripMenuItem.Size = new Size(38, 20);
            MyfileToolStripMenuItem.Text = "File";
            // 
            // MyopenMenuItem
            // 
            MyopenMenuItem.Name = "MyopenMenuItem";
            MyopenMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            MyopenMenuItem.Size = new Size(180, 22);
            MyopenMenuItem.Text = "Open";
            MyopenMenuItem.Click += MyopenMenuItem_Click;
            // 
            // MysaveMenuItem
            // 
            MysaveMenuItem.Name = "MysaveMenuItem";
            MysaveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            MysaveMenuItem.Size = new Size(180, 22);
            MysaveMenuItem.Text = "Save";
            MysaveMenuItem.Click += SaveText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveText);
            Controls.Add(InfoText);
            Controls.Add(Click_Mi);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Click_Mi;
        private TextBox InfoText;
        private Button SaveText;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MyfileToolStripMenuItem;
        private ToolStripMenuItem MyopenMenuItem;
        private ToolStripMenuItem MysaveMenuItem;
    }
}
