using System;
using System.Runtime.InteropServices;

namespace ToolKit.WinApi.Structers {
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT {

        public int X { get; private set; }
        public int Y { get; private set; }

        public POINT(int x, int y) {
            X = x;
            Y = y;
        }

        public static bool operator ==(POINT a, POINT b) => a.X == b.X && a.Y == b.Y;
        public static bool operator !=(POINT a, POINT b) => a.X != b.X || a.Y != b.Y;

        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();

        public string StringFormat(Func<int, int, string> format) => format(X, Y);

        public override string ToString() => string.Format("{0} {1}", X, Y);
    }
}
