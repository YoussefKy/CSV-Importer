namespace YK.XrmToolBox.CSVImporter.Forms
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpAboutContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlbGeneralInformation = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.llblDeveloper = new System.Windows.Forms.LinkLabel();
            this.llblTwitter = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.llblGithubRepo = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tlpAboutContainer.SuspendLayout();
            this.tlbGeneralInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAboutContainer
            // 
            this.tlpAboutContainer.ColumnCount = 1;
            this.tlpAboutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAboutContainer.Controls.Add(this.tlbGeneralInformation, 0, 0);
            this.tlpAboutContainer.Controls.Add(this.llblGithubRepo, 0, 1);
            this.tlpAboutContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAboutContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpAboutContainer.Name = "tlpAboutContainer";
            this.tlpAboutContainer.RowCount = 2;
            this.tlpAboutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAboutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAboutContainer.Size = new System.Drawing.Size(241, 164);
            this.tlpAboutContainer.TabIndex = 0;
            // 
            // tlbGeneralInformation
            // 
            this.tlbGeneralInformation.ColumnCount = 2;
            this.tlbGeneralInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbGeneralInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbGeneralInformation.Controls.Add(this.label1, 0, 0);
            this.tlbGeneralInformation.Controls.Add(this.label2, 0, 1);
            this.tlbGeneralInformation.Controls.Add(this.label3, 0, 2);
            this.tlbGeneralInformation.Controls.Add(this.label5, 1, 0);
            this.tlbGeneralInformation.Controls.Add(this.llblDeveloper, 1, 1);
            this.tlbGeneralInformation.Controls.Add(this.llblTwitter, 1, 2);
            this.tlbGeneralInformation.Controls.Add(this.label4, 0, 3);
            this.tlbGeneralInformation.Controls.Add(this.textBox1, 1, 3);
            this.tlbGeneralInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbGeneralInformation.Location = new System.Drawing.Point(3, 3);
            this.tlbGeneralInformation.Name = "tlbGeneralInformation";
            this.tlbGeneralInformation.RowCount = 4;
            this.tlbGeneralInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlbGeneralInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlbGeneralInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlbGeneralInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbGeneralInformation.Size = new System.Drawing.Size(235, 76);
            this.tlbGeneralInformation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Developer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Twitter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "0.1.0";
            // 
            // llblDeveloper
            // 
            this.llblDeveloper.AutoSize = true;
            this.llblDeveloper.Location = new System.Drawing.Point(120, 18);
            this.llblDeveloper.Name = "llblDeveloper";
            this.llblDeveloper.Size = new System.Drawing.Size(58, 13);
            this.llblDeveloper.TabIndex = 5;
            this.llblDeveloper.TabStop = true;
            this.llblDeveloper.Text = "Youssef K.";
            this.llblDeveloper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDeveloper_LinkClicked);
            // 
            // llblTwitter
            // 
            this.llblTwitter.AutoSize = true;
            this.llblTwitter.Location = new System.Drawing.Point(120, 36);
            this.llblTwitter.Name = "llblTwitter";
            this.llblTwitter.Size = new System.Drawing.Size(50, 13);
            this.llblTwitter.TabIndex = 6;
            this.llblTwitter.TabStop = true;
            this.llblTwitter.Text = "@kl_yssf";
            this.llblTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblTwitter_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail";
            // 
            // llblGithubRepo
            // 
            this.llblGithubRepo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblGithubRepo.AutoSize = true;
            this.llblGithubRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblGithubRepo.Location = new System.Drawing.Point(7, 107);
            this.llblGithubRepo.Name = "llblGithubRepo";
            this.llblGithubRepo.Size = new System.Drawing.Size(226, 31);
            this.llblGithubRepo.TabIndex = 1;
            this.llblGithubRepo.TabStop = true;
            this.llblGithubRepo.Text = "GitHub repository";
            this.llblGithubRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGithubRepo_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(120, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(112, 13);
            this.textBox1.TabIndex = 8;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "kl.yssf@gmail.com";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 164);
            this.Controls.Add(this.tlpAboutContainer);
            this.Name = "About";
            this.Text = "About";
            this.tlpAboutContainer.ResumeLayout(false);
            this.tlpAboutContainer.PerformLayout();
            this.tlbGeneralInformation.ResumeLayout(false);
            this.tlbGeneralInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAboutContainer;
        private System.Windows.Forms.TableLayoutPanel tlbGeneralInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel llblDeveloper;
        private System.Windows.Forms.LinkLabel llblTwitter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llblGithubRepo;
        private System.Windows.Forms.TextBox textBox1;
    }
}