using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Windows.Forms;

namespace Fontche.Core
{
    public class FontServer
    {

        public FontServer()
        {
            FontSize = 8;
            Fonts = new List<Font>();
            FontItems = new List<FontItem>();
        }

        public FontServer(bool autoLoad, float fontSize = 8)
        {
            FontSize = fontSize;
            Fonts = autoLoad ? Load() : new List<Font>();
        }

        #region Properties
        public List<Font> Fonts { get; set; }

        public List<FontItem> FontItems { get; set; }

        public int FontsCount => Fonts.Count;

        public float FontSize { get; set; }

        #endregion

        public List<Font> Load()
        {
            Fonts = FontFamily.Families
                .Select(f=> GetFont(f))
                .ToList();
            FillItems();
            return Fonts;
        }

        public List<Font> Load(string keyword)
        {
            Fonts = FontFamily.Families
                .Where(f => f.Name.Contains(keyword))
                .Select(f=> GetFont(f))
                .ToList();
            FillItems();
            return Fonts;
        }

        private void FillItems()
        {
            FontItems = new List<FontItem>();
            foreach (var font in Fonts)
            {
                FontItems.Add(new FontItem { Name = font.Name, Font = font});
            }
        }

        public Font GetFont(FontFamily font)
        {
            if (font.IsStyleAvailable(FontStyle.Regular))
            {
                return new Font(font.Name, FontSize, FontStyle.Regular);
            }
            else if (font.IsStyleAvailable(FontStyle.Bold))
            {
                return new Font(font.Name, FontSize, FontStyle.Bold);
            }
            else if (font.IsStyleAvailable(FontStyle.Italic))
            {
                return new Font(font.Name, FontSize, FontStyle.Italic);
            }
            return null;
        }

        public Font GetFont(FontFamily font, float size)
        {
            if (font.IsStyleAvailable(FontStyle.Regular))
            {
                return new Font(font.Name, size, FontStyle.Regular);
            }
            else if (font.IsStyleAvailable(FontStyle.Bold))
            {
                return new Font(font.Name, size, FontStyle.Bold);
            }
            else if (font.IsStyleAvailable(FontStyle.Italic))
            {
                return new Font(font.Name, size, FontStyle.Italic);
            }
            return null;
        }

        public List<Font> Search(string keyword)
        {
            return Fonts
                .Where(f => f.Name.Contains(keyword))
                .ToList();
        }

        public FontItem GetInfoFromFile(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
                return null;

            var fontInfo = new PrivateFontCollection();
            fontInfo.AddFontFile(filePath);

            var result = new FontItem
            {
                Name = fontInfo.Families[0].Name,
                Font = GetFont(fontInfo.Families[0]),
                FontPath = filePath
            };

            var api = new FontApi();

            result.Font = api.GetSpecialFont(filePath, 9);

            return result;
        }

        public bool Install(List<FontItem> items)
        {
            var result = false; //Determine if Install process is a success or not
            var appPath = Application.StartupPath + "\\FontReg.exe";
            var sourceDir = Application.StartupPath + "\\Install_Temp";
            var fontRgePath = sourceDir + "\\FontReg.exe";
            if (!Directory.Exists(sourceDir))
            {
                Directory.CreateDirectory(sourceDir);
            }
            if (!File.Exists(fontRgePath))
            {
                
            }
            var _params = @"/Copy ";


            return result;
        }

    }
}
