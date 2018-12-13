using System;
using System.Runtime.InteropServices;
using Win = ToolKit.WinApi.Structers;

namespace ToolKit.WinApi {
    public class Kernel32 {
        /// <summary>
        /// Retrieves system timing information. On a multiprocessor system, the values returned are the sum of the designated times across all processors.
        /// </summary>
        /// <param name="lpIdleTime">A pointer to a FILETIME structure that receives the amount of time that the system has been idle.</param>
        /// <param name="lpKernelTime">A pointer to a FILETIME structure that receives the amount of time that the system has spent executing in Kernel mode (including all threads in all processes, on all processors). This time value also includes the amount of time the system has been idle.</param>
        /// <param name="lpUserTime">A pointer to a FILETIME structure that receives the amount of time that the system has spent executing in User mode (including all threads in all processes, on all processors).</param>
        /// <remarks>To compile an application that uses this function, define _WIN32_WINNT as 0x0501 or later. For more information, see Using the Windows Headers.</remarks>
        /// <returns>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero.To get extended error information, call GetLastError.</returns>
        [DllImport(Imports.KERNEL32, SetLastError = false)]
        public static extern bool GetSystemTimes(out Win.FILETIME lpIdleTime, out Win.FILETIME lpKernelTime, out Win.FILETIME lpUserTime);
        /// <summary>
        /// Retrieves the calling thread's last-error code value. The last-error code is maintained on a per-thread basis. Multiple threads do not overwrite each other's last-error code.
        /// </summary>
        /// <returns></returns>
        [DllImport(Imports.KERNEL32, SetLastError = false)]
        public static extern bool GetLastError();

        [DllImport(Imports.KERNEL32, SetLastError = false, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process(IntPtr processHandle, out bool wow64Process);
        
        [DllImport(Imports.KERNEL32, CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr GetCurrentProcess();
    }
}
