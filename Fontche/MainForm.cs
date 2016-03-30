using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Fontche.Core;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Fontchi
{
    public partial class MainForm : RadForm
    {
        private FontServer fontServer;

        private int _fontItemCounter = 0;

        private int lastTopPos = 0;

        #region Properties

        public string AppTheme
        {
            get { return ThemeResolutionService.ApplicationThemeName; }
            set { ThemeResolutionService.ApplicationThemeName = value; }
        }

        public List<FontItem> InstallFonts { get; set; }


        public float UserFontSize { get; set; }

        public string SearchKeyword
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public int SelectedFontIndex => gridView.SelectedRows.Count == 0 
            ? -1 
            : gridView.SelectedRows[0].Index;

        public Font SelectedFont => SelectedFontIndex == -1
            ? null
            : fontServer.FontItems[SelectedFontIndex].Font;

        public int SelectedTestFontIndex => ddlTestFonts.SelectedIndex;

        public Font SelectedTestFont => SelectedTestFontIndex == -1
            ? null
            : fontServer.FontItems[SelectedTestFontIndex].Font;

        public float TestFontSize
        {
            get { return (float) numTestFontSize.Value; }
            set { numTestFontSize.Value = (decimal) value; }
        }

        #endregion


        public MainForm()
        {
            InitializeComponent();
            AppTheme = "Office2013Light";
            UserFontSize = 12;
            fontServer = new FontServer(false, UserFontSize);
            fontServer.Load();
            gridView.AutoGenerateColumns = false;
            gridView.EnableFiltering = true;
            SetSampleText("Mehdi Fucking Rezaie.", "مهدی سان آو ا هور رضایی.");
            gridView.DataSource = fontServer.FontItems;
            SetGridFonts();
            LoasFontTestDropDown();
            lblFontsCount.Text = fontServer.FontsCount.ToString();
            gridView.Columns[0].AutoSizeMode = BestFitColumnMode.DisplayedCells;
            gridView.EnableAlternatingRowColor = true;
            InstallFonts = new List<FontItem>();
            listInstall.ViewType = ListViewType.IconsView;
        }


        #region Methods

        public void SetSampleText(string englishSample, string persianSample)
        {
            foreach (var item in fontServer.FontItems)
            {
                item.EnglishSample = englishSample;
                item.PersianSample = persianSample;
            }
        }

        public void SetGridFonts()
        {
            foreach (var row in gridView.Rows)
            {
                var font = fontServer.FontItems
                    .FirstOrDefault(x => x.Name == (string)row.Cells[0].Value)?.Font;
                //row.Cells[0].Style.Font =
                row.Cells[1].Style.Font =
                    row.Cells[2].Style.Font = font;
            }
        }

        public void LoasFontTestDropDown()
        {
            ddlTestFonts.Items.Clear();
            foreach (var font in fontServer.FontItems)
            {
                var item = new RadListDataItem
                {
                    Text = font.Name,
                    Font = font.Font
                };

                ddlTestFonts.Items.Add(item);
            }
        }

        public void ChangeGridFontSize(float size)
        {
            if(size > 0 && UserFontSize > 76)
                return;
            if(size < 0 && UserFontSize < 7)
                return;
            
            UserFontSize += size;
            foreach (var row in gridView.Rows)
            {
                var font = fontServer.FontItems
                    .FirstOrDefault(x => x.Name == (string)row.Cells[0].Value)?.Font;

                var newFont = new Font(font.Name, UserFontSize, font.Style);
                //row.Cells[0].Style.Font =
                row.Cells[1].Style.Font =
                    row.Cells[2].Style.Font = newFont;
            }
        }


        private void BindInstallFontsToList()
        {
            listInstall.Items.Clear();
            _fontItemCounter = 0;
            foreach (var item in InstallFonts)
            {
                listInstall.Items.Add(new ListViewDataItem
                {
                    //Font = fontInfo.Font,
                    Tag = item,
                    Value = item.Id,
                    Text = item.Name,
                    ImageIndex = 0
                });
            }
            listInstall.Refresh();
        }

        #endregion


        public void SearchFonts(string keyword)
        {
            //if (string.IsNullOrEmpty(keyword))
            //    fontServer.Load();
            //else fontServer.Load(keyword);
            //lastTopPos = 0;
            //panelMain.PanelContainer.Controls.Clear();
            //foreach (var font in fontServer.Search(keyword))
            //{
            //    AddWidget(font);
            //}
        }

        //public void AddWidget(Font font)
        //{
        //    var fontPreview = new FontPreview();
        //    fontPreview.EnglishLabel = "To be or not to be; that's the problem.";
        //    fontPreview.PersianLabel = "بودن یا نبودن؛ مسئله این است.";
        //    fontPreview.PreviewFont = font;
        //    panelMain.PanelContainer.Controls.Add(fontPreview);
        //    fontPreview.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        //    fontPreview.Top = lastTopPos;
        //    lastTopPos += fontPreview.Height;
        //    fontPreview.Width = panelMain.PanelContainer.Width - 2;
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchFonts(SearchKeyword);
        }

        private void ZoomInFont()
        {
            ChangeGridFontSize(2);
        }

        private void ZoomOutFont()
        {
            ChangeGridFontSize(-2);
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            ZoomInFont();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            ZoomOutFont();
        }

        private void radLabelElement1_Click(object sender, EventArgs e)
        {

        }

        private void ddlTestFonts_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (SelectedTestFont != null)
                txtTestFont.Font = fontServer.GetFont(SelectedTestFont.FontFamily, TestFontSize);
        }

        private void numTestFontSize_ValueChanged(object sender, EventArgs e)
        {
            if (SelectedTestFont != null)
                txtTestFont.Font = fontServer.GetFont(SelectedTestFont.FontFamily, TestFontSize);
        }

        private void gridView_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnAddFont_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Multiselect = true;
                dlg.Filter = @"All supported fonts (*.fon,*.ttf,*.ttc,*.otf)|*.fon;*.ttf;*.ttc;*.otf|
TrueType Fonts (*.ttf)|*.ttf|All files (*.*)|*.*";
                dlg.Title = "Select fonts to Install";
                dlg.CheckFileExists = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (var filename in dlg.FileNames)
                    {
                        var fontInfo = fontServer.GetInfoFromFile(filename);
                        fontInfo.Id = _fontItemCounter;
                        _fontItemCounter++;
                        InstallFonts.Add(fontInfo);
                        listInstall.Items.Add(new ListViewDataItem
                        {
                            Font = fontInfo.Font,
                            Tag = fontInfo,
                            Value = fontInfo.Id,
                            Text = fontInfo.Name,
                            ImageIndex = 0
                        });
                    }
                }
            }
        }

        private void btnRemoveFont_Click(object sender, EventArgs e)
        {
            if(!listInstall.SelectedItems.Any())
                    return;
            if (MessageBox.Show("برای حذف فونت های انتخاب شده از لیست اطمینان دارید؟",
                "حذف از لیست نصب",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var item in listInstall.SelectedItems)
                {
//var id = Convert.ToInt32(item.Value);
                    //var fontItem = (from x in InstallFonts
                    //    where x.Id == id
                    //    select x).FirstOrDefault();
                    var fontItem = (FontItem) item.Tag;
                    if (fontItem != null) InstallFonts.Remove(fontItem);
                    
                }
                //Rebind the List to modified data
                BindInstallFontsToList();
            }

            if (!listInstall.Items.Any())
            {
                //Reset the Counter
                _fontItemCounter = 0;
            }
        }

        private void listInstall_SelectedItemChanged(object sender, EventArgs e)
        {
            if (!listInstall.SelectedItems.Any())
                return;
            
            var fontItem = (FontItem) listInstall.SelectedItems[0].Tag;
            txtTestFont.Font = fontItem.Font;
        }

        private void btnInstallFonts_Click(object sender, EventArgs e)
        {
            foreach (var font in InstallFonts)
            {
                
            }
        }
    }
}
