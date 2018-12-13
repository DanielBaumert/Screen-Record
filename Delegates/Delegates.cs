using System;

namespace ToolKit.WinApi.Delegates {
    public delegate IntPtr LowLevelHookCallback(int nCode, IntPtr wParam, IntPtr lParam);
}
