using System;
using System.Runtime.InteropServices;

namespace ToolKit.WinApi {
    public class Msvcrt {
        [DllImport(Imports.MSVCRT, EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        public static extern IntPtr memcpy(IntPtr dest, IntPtr src, UIntPtr count);
    }
}
