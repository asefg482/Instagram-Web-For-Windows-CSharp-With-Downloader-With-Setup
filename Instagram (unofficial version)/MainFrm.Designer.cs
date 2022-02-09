namespace Instagram__unofficial_version_
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.Ins_W_b = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Speed_Show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ins_W_b
            // 
            this.Ins_W_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ins_W_b.Location = new System.Drawing.Point(0, 0);
            this.Ins_W_b.MinimumSize = new System.Drawing.Size(20, 20);
            this.Ins_W_b.Name = "Ins_W_b";
            this.Ins_W_b.Size = new System.Drawing.Size(927, 534);
            this.Ins_W_b.TabIndex = 0;
            this.Ins_W_b.Url = new System.Uri("http://www.instagram.com", System.UriKind.Absolute);
            this.Ins_W_b.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Ins_W_b_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(878, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Setting";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instagram Downloader";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Lbl_Speed_Show
            // 
            this.Lbl_Speed_Show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Speed_Show.AutoSize = true;
            this.Lbl_Speed_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Speed_Show.Location = new System.Drawing.Point(12, 512);
            this.Lbl_Speed_Show.Name = "Lbl_Speed_Show";
            this.Lbl_Speed_Show.Size = new System.Drawing.Size(182, 13);
            this.Lbl_Speed_Show.TabIndex = 3;
            this.Lbl_Speed_Show.Text = "Click Me To Get Your Internet Speed";
            this.Lbl_Speed_Show.Click += new System.EventHandler(this.Lbl_Speed_Show_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 534);
            this.Controls.Add(this.Lbl_Speed_Show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ins_W_b);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram (unofficial version)";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser Ins_W_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Speed_Show;
    }
}

