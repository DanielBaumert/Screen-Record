using System;

namespace ToolKitRAT.WinApi.Delegates {
    public delegate IntPtr LowLevelHookCallback(int nCode, IntPtr wParam, IntPtr lParam);
}
