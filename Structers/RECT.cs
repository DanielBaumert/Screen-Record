using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ToolKitRAT.WinApi.Structers {
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT {
        public int Left { get; private set; }
        public int Top { get; private set; }
        public int Right { get; private set; }
        public int Bottom { get; private set; }

        public int X { get => Left; }
        public int Y { get => Top; }
        public int Width { get => Right - Left; }
        public int Height { get => Bottom - Top; }

        public POINT Location { get => new POINT(X, Y); }
        public SIZE Size { get => new SIZE(Width, Height); }

        public static bool operator ==(RECT a, RECT b) => a.Location == b.Location && a.Size == b.Size;
        public static bool operator !=(RECT a, RECT b) => a.Location != b.Location || a.Size != b.Size;

        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();
    }
}
