
using System.Runtime.InteropServices;

namespace ToolKit.WinApi.Structers {
    [StructLayout(LayoutKind.Sequential)]
    public struct FILETIME {
        public uint dwLowDateTime { get; private set; }
        public uint dwHighDateTime { get; private set; }

        public ulong value { get => (((ulong)dwHighDateTime) << 32) + dwLowDateTime; }
    }
}
