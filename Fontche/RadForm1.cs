using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Fontche
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = "Desert";
            UserFontSize = 12;
            LoadAllFonts();
        }

        public float UserFontSize { get; set; }

        public void LoadAllFonts()
        {
            foreach (var font in FontFamily.Families)
            {
                var item = new RadListDataItem
                {
                    Text = font.Name,
                    Font = GetFont(font)
                };
                
                ddlFonts.Items.Add(item);
            }
        }

        public Font GetFont(FontFamily font)
        {
            if (font.IsStyleAvailable(FontStyle.Regular))
            {
                return new Font(font.Name, UserFontSize, FontStyle.Regular);
            }
            else if (font.IsStyleAvailable(FontStyle.Bold))
            {
                return new Font(font.Name, UserFontSize, FontStyle.Bold);
            }
            else if (font.IsStyleAvailable(FontStyle.Italic))
            {
                return new Font(font.Name, UserFontSize, FontStyle.Italic);
            }
            return null;
        }

        private void ddlFonts_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(ddlFonts.SelectedIndex > -1)
                txtFont.Font = GetFont(ddlFonts.Items[ddlFonts.SelectedIndex].Font.FontFamily);
        }

        private void RadForm1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 255));
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            
        }
    }
}
