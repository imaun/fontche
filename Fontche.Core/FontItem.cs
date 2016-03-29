using System.Drawing;

namespace Fontche.Core
{
    public class FontItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string EnglishSample { get; set; }

        public string PersianSample { get; set; }

        public Font Font { get; set; }

        public string FontPath { get; set; }
    }
}
