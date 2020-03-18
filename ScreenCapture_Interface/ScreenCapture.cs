using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenCapture_Interface
{
    public class ScreenCapture
    {
        public void ScreenCapture_Single(string strFilePath)
        {
            #region 多螢幕單張截圖
            DateTime dtNow = DateTime.Now;
            int iScreenW = 0, iScreenH = 0;
            foreach (var t in Screen.AllScreens)
            {
                iScreenW += t.Bounds.Width;
                iScreenH = (iScreenH < t.Bounds.Height) ? t.Bounds.Height : iScreenH;
            }

            Bitmap objBitmap = new Bitmap(iScreenW, iScreenH);
            Graphics objGraphics = Graphics.FromImage(objBitmap);
            int iTempW = 0, iTempH = 0;
            foreach (var t in Screen.AllScreens)
            {
                objGraphics.CopyFromScreen(new Point(t.Bounds.Left, t.Bounds.Top), new Point(iTempW, iTempH), new Size(t.Bounds.Width, t.Bounds.Height));
                iTempW += t.Bounds.Width;
            }
            objBitmap.Save(strFilePath + @"\" + dtNow.ToString("yyyy-MM-dd_HH-mm-ss") + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            objGraphics.Dispose();
            objBitmap.Dispose();
            #endregion
        }

        public void ScreenCapture_Multiple(string strFilePath)
        {
            #region 多螢幕多張截圖
            DateTime dtNow = DateTime.Now;
            int iCnt = 0;
            foreach (var t in Screen.AllScreens)
            {
                ++iCnt;
                Bitmap objBitmap = new Bitmap(t.Bounds.Width, t.Bounds.Height);
                Graphics objGraphics = Graphics.FromImage(objBitmap);
                objGraphics.CopyFromScreen(new Point(t.Bounds.Left, t.Bounds.Top), new Point(0, 0), new Size(t.Bounds.Width, t.Bounds.Height));
                objBitmap.Save(strFilePath + @"\" + dtNow.ToString("yyyy-MM-dd_HH-mm-ss_") + iCnt + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                objGraphics.Dispose();
                objBitmap.Dispose();
            }
            #endregion
        }
    }
}
