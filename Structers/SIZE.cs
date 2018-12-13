using System.Runtime.InteropServices;

namespace ToolKit.WinApi.Structers {
    [StructLayout(LayoutKind.Sequential)]
    public struct SIZE {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public SIZE(int width, int height) {
            Width = width;
            Height = height;
        }

        public static bool operator ==(SIZE a, SIZE b) => a.Width == b.Width && a.Height == b.Height;
        public static bool operator !=(SIZE a, SIZE b) => a.Width != b.Width || a.Height != b.Height;

        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();
    }
}
