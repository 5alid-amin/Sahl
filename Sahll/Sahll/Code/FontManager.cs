using System.Drawing.Text;
using System.Runtime.InteropServices;
using Sahll.Properties;
public static class FontManager
{
    public static PrivateFontCollection privateFonts = new PrivateFontCollection();
    public static Font primaryFont;
    public static Font secondaryFont;

    public static void LoadFonts()
    {
        // تحميل الفونت الأول
        //byte[] primaryFontData = ; // اسم الفونت الأول
        //IntPtr primaryFontPtr = Marshal.AllocCoTaskMem(primaryFontData.Length);
        //Marshal.Copy(primaryFontData, 0, primaryFontPtr, primaryFontData.Length);
        //privateFonts.AddMemoryFont(primaryFontPtr, primaryFontData.Length);
        //Marshal.FreeCoTaskMem(primaryFontPtr);

        //// تحميل الفونت الثاني
        //byte[] secondaryFontData = Properties.Resources.SecondaryFont; // اسم الفونت الثاني
        //IntPtr secondaryFontPtr = Marshal.AllocCoTaskMem(secondaryFontData.Length);
        //Marshal.Copy(secondaryFontData, 0, secondaryFontPtr, secondaryFontData.Length);
        //privateFonts.AddMemoryFont(secondaryFontPtr, secondaryFontData.Length);
        //Marshal.FreeCoTaskMem(secondaryFontPtr);

        //// تعيين الفونتات
        //primaryFont = new Font(privateFonts.Families[0], 12);
        //secondaryFont = new Font(privateFonts.Families[1], 12);
    }
}
