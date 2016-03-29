namespace Fontchi.Core.Controls
{
    partial class FontPreview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new Telerik.WinControls.UI.RadPanel();
            this.lblPersian = new Telerik.WinControls.UI.RadLabel();
            this.lblEnglish = new Telerik.WinControls.UI.RadLabel();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.lblFontName = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblPersian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFontName)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.radCheckBox1);
            this.mainPanel.Controls.Add(this.lblPersian);
            this.mainPanel.Controls.Add(this.lblFontName);
            this.mainPanel.Controls.Add(this.lblEnglish);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(412, 76);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Click += new System.EventHandler(this.mainPanel_Click);
            // 
            // lblPersian
            // 
            this.lblPersian.Location = new System.Drawing.Point(17, 37);
            this.lblPersian.Name = "lblPersian";
            this.lblPersian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPersian.Size = new System.Drawing.Size(124, 18);
            this.lblPersian.TabIndex = 0;
            this.lblPersian.Text = "مهدی فاکینگ اس رضایی سیبیب";
            // 
            // lblEnglish
            // 
            this.lblEnglish.Location = new System.Drawing.Point(17, 13);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(55, 18);
            this.lblEnglish.TabIndex = 0;
            this.lblEnglish.Text = "radLabel1";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radCheckBox1.Location = new System.Drawing.Point(394, 28);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(15, 15);
            this.radCheckBox1.TabIndex = 1;
            this.radCheckBox1.CheckStateChanged += new System.EventHandler(this.radCheckBox1_CheckStateChanged);
            // 
            // lblFontName
            // 
            this.lblFontName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFontName.AutoSize = false;
            this.lblFontName.BackColor = System.Drawing.Color.Transparent;
            this.lblFontName.Location = new System.Drawing.Point(212, 4);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(197, 18);
            this.lblFontName.TabIndex = 0;
            this.lblFontName.Text = "radLabel1";
            this.lblFontName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // FontPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "FontPreview";
            this.Size = new System.Drawing.Size(412, 76);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblPersian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFontName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel mainPanel;
        private Telerik.WinControls.UI.RadLabel lblPersian;
        private Telerik.WinControls.UI.RadLabel lblEnglish;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadLabel lblFontName;
    }
}
