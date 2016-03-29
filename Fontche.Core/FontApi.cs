﻿using System;
using System.Reflection;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace Fontche.Core
{
    public class FontApi
    {
        // Adding a private font (Win2000 and later)
        [DllImport("gdi32.dll", ExactSpelling = true)]
        private static extern IntPtr AddFontMemResourceEx(byte[] pbFont, int cbFont, IntPtr pdv, out uint pcFonts);

        // Cleanup of a private font (Win2000 and later)
        [DllImport("gdi32.dll", ExactSpelling = true)]
        internal static extern bool RemoveFontMemResourceEx(IntPtr fh);


        // Some private holders of font information we are loading
        static private IntPtr m_fh = IntPtr.Zero;
        static private PrivateFontCollection m_pfc = null;


        public Font GetSpecialFont(string filePath, float size)
        {


            Font fnt = null;

            

            // First load the font as a memory stream
            using (var stmFont = new FileStream(filePath, FileMode.Open))
            {
                // 
                // GDI+ wants a pointer to memory, GDI wants the memory.
                // We will make them both happy.
                //

                // First read the font into a buffer
                byte[] rgbyt = new Byte[stmFont.Length];
                stmFont.Read(rgbyt, 0, rgbyt.Length);

                // Then do the unmanaged font (Windows 2000 and later)
                // The reason this works is that GDI+ will create a font object for
                // controls like the RichTextBox and this call will make sure that GDI
                // recognizes the font name, later.
                uint cFonts = 0;
                AddFontMemResourceEx(rgbyt, rgbyt.Length, IntPtr.Zero, out cFonts);


                // Now do the managed font
                IntPtr pbyt = Marshal.AllocCoTaskMem(rgbyt.Length);
                if (null != pbyt)
                {
                    Marshal.Copy(rgbyt, 0, pbyt, rgbyt.Length);

                    m_pfc = new PrivateFontCollection();
                    m_pfc.AddMemoryFont(pbyt, rgbyt.Length);
                    Marshal.FreeCoTaskMem(pbyt);
                }
            }

            if (m_pfc.Families.Length > 0)
            {
                // Handy how one of the Font constructors takes a
                // FontFamily object, huh? :-)
                var fontServer = new FontServer();
                fnt = fontServer.GetFont(m_pfc.Families[0], size);
            }
            

            return fnt;
        }

    }
}
