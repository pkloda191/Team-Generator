namespace TeamGenPoC
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
            this.toAddName = new System.Windows.Forms.TextBox();
            this.nameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamSize = new System.Windows.Forms.TextBox();
            this.genBtn = new System.Windows.Forms.Button();
            this.memberList = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TabThing = new System.Windows.Forms.TabControl();
            this.setCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearLastNameEntryButton = new System.Windows.Forms.Button();
            this.namesScrollable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toAddName
            // 
            this.toAddName.Location = new System.Drawing.Point(13, 84);
            this.toAddName.Margin = new System.Windows.Forms.Padding(4);
            this.toAddName.Name = "toAddName";
            this.toAddName.Size = new System.Drawing.Size(132, 22);
            this.toAddName.TabIndex = 0;
            // 
            // nameBtn
            // 
            this.nameBtn.Location = new System.Drawing.Point(13, 116);
            this.nameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nameBtn.Name = "nameBtn";
            this.nameBtn.Size = new System.Drawing.Size(133, 28);
            this.nameBtn.TabIndex = 1;
            this.nameBtn.Text = "Add Name to List";
            this.nameBtn.UseVisualStyleBackColor = true;
            this.nameBtn.Click += new System.EventHandler(this.nameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team Size";
            // 
            // teamSize
            // 
            this.teamSize.Location = new System.Drawing.Point(13, 204);
            this.teamSize.Margin = new System.Windows.Forms.Padding(4);
            this.teamSize.Name = "teamSize";
            this.teamSize.Size = new System.Drawing.Size(132, 22);
            this.teamSize.TabIndex = 5;
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(13, 283);
            this.genBtn.Margin = new System.Windows.Forms.Padding(4);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(100, 28);
            this.genBtn.TabIndex = 6;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // memberList
            // 
            this.memberList.AutoSize = true;
            this.memberList.Location = new System.Drawing.Point(193, 32);
            this.memberList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(56, 17);
            this.memberList.TabIndex = 7;
            this.memberList.Text = "Names:";
            this.memberList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // TabThing
            // 
            this.TabThing.Location = new System.Drawing.Point(20, 324);
            this.TabThing.Margin = new System.Windows.Forms.Padding(4);
            this.TabThing.Name = "TabThing";
            this.TabThing.SelectedIndex = 0;
            this.TabThing.Size = new System.Drawing.Size(452, 164);
            this.TabThing.TabIndex = 9;
            // 
            // setCount
            // 
            this.setCount.Location = new System.Drawing.Point(13, 251);
            this.setCount.Margin = new System.Windows.Forms.Padding(4);
            this.setCount.Name = "setCount";
            this.setCount.Size = new System.Drawing.Size(132, 22);
            this.setCount.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of Sets";
            // 
            // clearLastNameEntryButton
            // 
            this.clearLastNameEntryButton.Location = new System.Drawing.Point(13, 151);
            this.clearLastNameEntryButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearLastNameEntryButton.Name = "clearLastNameEntryButton";
            this.clearLastNameEntryButton.Size = new System.Drawing.Size(132, 28);
            this.clearLastNameEntryButton.TabIndex = 12;
            this.clearLastNameEntryButton.Text = "Clear Last Entry";
            this.clearLastNameEntryButton.UseVisualStyleBackColor = true;
            // 
            // namesScrollable
            // 
            this.namesScrollable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.namesScrollable.GridLines = true;
            this.namesScrollable.Location = new System.Drawing.Point(196, 52);
            this.namesScrollable.Name = "namesScrollable";
            this.namesScrollable.Size = new System.Drawing.Size(276, 247);
            this.namesScrollable.TabIndex = 14;
            this.namesScrollable.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.nameBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 514);
            this.Controls.Add(this.namesScrollable);
            this.Controls.Add(this.clearLastNameEntryButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setCount);
            this.Controls.Add(this.TabThing);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.teamSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBtn);
            this.Controls.Add(this.toAddName);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Team Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toAddName;
        private System.Windows.Forms.Button nameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teamSize;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Label memberList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl TabThing;
        private System.Windows.Forms.TextBox setCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearLastNameEntryButton;
        private System.Windows.Forms.ListView namesScrollable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

