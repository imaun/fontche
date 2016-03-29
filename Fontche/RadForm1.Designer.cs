namespace Fontchi
{
    partial class RadForm1
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
            this.ddlFonts = new Telerik.WinControls.UI.RadDropDownList();
            this.txtFont = new Telerik.WinControls.UI.RadTextBox();
            this.customShape1 = new Telerik.WinControls.OldShapeEditor.CustomShape();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.ddlFonts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlFonts
            // 
            this.ddlFonts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlFonts.DropDownHeight = 200;
            this.ddlFonts.EnableAlternatingItemColor = true;
            this.ddlFonts.Location = new System.Drawing.Point(232, 47);
            this.ddlFonts.Name = "ddlFonts";
            this.ddlFonts.NullText = "فونت را انتخاب کنید...";
            this.ddlFonts.Size = new System.Drawing.Size(466, 20);
            this.ddlFonts.TabIndex = 0;
            this.ddlFonts.ThemeName = "Desert";
            this.ddlFonts.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlFonts_SelectedIndexChanged);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.ddlFonts.GetChildAt(0))).RightToLeft = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.ddlFonts.GetChildAt(0))).Shape = null;
            // 
            // txtFont
            // 
            this.txtFont.AutoSize = false;
            this.txtFont.Location = new System.Drawing.Point(232, 73);
            this.txtFont.Multiline = true;
            this.txtFont.Name = "txtFont";
            this.txtFont.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFont.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFont.Size = new System.Drawing.Size(466, 107);
            this.txtFont.TabIndex = 2;
            this.txtFont.Text = "Fuck This Shit\r\nفاک یو مهدی فاکینگ رضایی\r\n\r\n";
            this.txtFont.ThemeName = "Desert";
            // 
            // customShape1
            // 
            this.customShape1.Dimension = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 431);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.ddlFonts);
            this.Name = "RadForm1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.ThemeName = "Desert";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RadForm1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ddlFonts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList ddlFonts;
        private Telerik.WinControls.UI.RadTextBox txtFont;
        private Telerik.WinControls.OldShapeEditor.CustomShape customShape1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}