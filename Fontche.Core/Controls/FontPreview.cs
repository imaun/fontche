using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fontche.Core.Controls
{
    public partial class FontPreview : UserControl
    {
        

        public FontPreview()
        {
            InitializeComponent();
        }

        #region Properties

        public string EnglishLabel
        {
            get { return lblEnglish.Text; }
            set { lblEnglish.Text = value; }
        }

        public string PersianLabel
        {
            get { return lblPersian.Text; }
            set { lblPersian.Text = value; }
        }

        private Font _previewFont;
        public Font PreviewFont
        {
            get { return _previewFont; }
            set
            {
                _previewFont = value;
                lblPersian.Font = value;
                lblEnglish.Font = value;
                lblFontName.Text = _previewFont.Name;
            }
        }

        private bool _selected;

        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                radCheckBox1.Checked = _selected;
                mainPanel.BackColor = _selected ? SystemColors.Control : Color.White;
            }
        }
     


        #endregion

        private void mainPanel_Click(object sender, EventArgs e)
        {
            Selected = !Selected;
        }

        private void radCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            Selected = radCheckBox1.Checked;
        }
    }
}
