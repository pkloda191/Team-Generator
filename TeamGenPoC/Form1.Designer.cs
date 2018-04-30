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
            this.SuspendLayout();
            // 
            // toAddName
            // 
            this.toAddName.Location = new System.Drawing.Point(12, 50);
            this.toAddName.Name = "toAddName";
            this.toAddName.Size = new System.Drawing.Size(100, 20);
            this.toAddName.TabIndex = 0;
            // 
            // nameBtn
            // 
            this.nameBtn.Location = new System.Drawing.Point(12, 76);
            this.nameBtn.Name = "nameBtn";
            this.nameBtn.Size = new System.Drawing.Size(100, 23);
            this.nameBtn.TabIndex = 1;
            this.nameBtn.Text = "Add Name to List";
            this.nameBtn.UseVisualStyleBackColor = true;
            this.nameBtn.Click += new System.EventHandler(this.nameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team Size";
            // 
            // teamSize
            // 
            this.teamSize.Location = new System.Drawing.Point(12, 123);
            this.teamSize.Name = "teamSize";
            this.teamSize.Size = new System.Drawing.Size(100, 20);
            this.teamSize.TabIndex = 5;
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(12, 187);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(75, 23);
            this.genBtn.TabIndex = 6;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // memberList
            // 
            this.memberList.AutoSize = true;
            this.memberList.Location = new System.Drawing.Point(168, 8);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(43, 13);
            this.memberList.TabIndex = 7;
            this.memberList.Text = "Names:";
            this.memberList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            this.TabThing.Location = new System.Drawing.Point(18, 216);
            this.TabThing.Name = "TabThing";
            this.TabThing.SelectedIndex = 0;
            this.TabThing.Size = new System.Drawing.Size(245, 133);
            this.TabThing.TabIndex = 9;
            // 
            // setCount
            // 
            this.setCount.Location = new System.Drawing.Point(12, 161);
            this.setCount.Name = "setCount";
            this.setCount.Size = new System.Drawing.Size(100, 20);
            this.setCount.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of Sets";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 361);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

