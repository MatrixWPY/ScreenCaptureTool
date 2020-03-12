using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenCapture_Interface
{
    public class ScreenCapture
    {
        public void ScreenCapture_Single(string FilePath)
        {
            #region 多螢幕單張截圖
            int Screen_W = 0, Screen_H = 0;
            foreach (var t in Screen.AllScreens)
            {
                Screen_W += t.Bounds.Width;
                Screen_H = (Screen_H < t.Bounds.Height) ? t.Bounds.Height : Screen_H;
            }

            Bitmap myImage = new Bitmap(Screen_W, Screen_H);
            Graphics g = Graphics.FromImage(myImage);
            int temp_w = 0, temp_h = 0;
            foreach (var t in Screen.AllScreens)
            {
                g.CopyFromScreen(new Point(t.Bounds.Left, t.Bounds.Top), new Point(temp_w, temp_h), new Size(t.Bounds.Width, t.Bounds.Height));
                temp_w += t.Bounds.Width;
            }
            myImage.Save(FilePath + @"\" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            g.Dispose();
            myImage.Dispose();
            #endregion
        }

        public void ScreenCapture_Multiple(string FilePath)
        {
            #region 多螢幕多張截圖
            int cnt = 0;
            foreach (var t in Screen.AllScreens)
            {
                ++cnt;
                Bitmap myImage = new Bitmap(t.Bounds.Width, t.Bounds.Height);
                Graphics g = Graphics.FromImage(myImage);
                g.CopyFromScreen(new Point(t.Bounds.Left, t.Bounds.Top), new Point(0, 0), new Size(t.Bounds.Width, t.Bounds.Height));
                myImage.Save(FilePath + @"\" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss_") + cnt + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                g.Dispose();
                myImage.Dispose();
            }
            #endregion
        }
    }
}
