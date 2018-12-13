using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ToolKit.WinApi.Constants;
using ToolKit.WinApi.Delegates;
using ToolKit.WinApi.Structers;

namespace ToolKit.WinApi {
    public class User32 {

        /// <summary>
        /// Retrieves a handle to the desktop window. The desktop window covers the entire screen. The desktop window is the area on top of which other windows are painted.
        /// </summary>
        /// <returns>The return value is a handle to the desktop window.</returns>
        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern IntPtr GetDesktopWindow();

        /// <summary>
        /// The GetWindowDC function retrieves the device context (DC) for the entire window, including title bar, menus, and scroll bars. A window device context permits painting anywhere in a window, because the origin of the device context is the upper-left corner of the window instead of the client area.
        /// </summary>
        /// <param name="hWnd">A handle to the window with a device context that is to be retrieved. If this value is NULL, GetWindowDC retrieves the device context for the entire screen.</param>
        /// <returns>
        /// If the function succeeds, the return value is a handle to a device context for the specified window.
        /// If the function fails, the return value is NULL, indicating an error or an invalid hWnd parameter.
        /// </returns>
        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        /// <summary>
        /// The ReleaseDC function releases a device context (DC), freeing it for use by other applications. The effect of the ReleaseDC function depends on the type of DC. It frees only common and window DCs. It has no effect on class or private DCs.
        /// </summary>
        /// <param name="hWnd">A handle to the window whose DC is to be released.</param>
        /// <param name="hDC">A handle to the DC to be released.</param>
        /// <remarks>
        /// The application must call the ReleaseDC function for each call to the GetWindowDC function and for each call to the GetDC function that retrieves a common DC.
        /// An application cannot use the ReleaseDC function to release a DC that was created by calling the CreateDC function; instead, it must use the DeleteDC function. ReleaseDC must be called from the same thread that called GetDC.
        /// </remarks>
        /// <returns>
        /// The return value indicates whether the DC was released. If the DC was released, the return value is 1.
        /// If the DC was not released, the return value is zero.
        /// </returns>
        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

        /// <summary>
        /// Retrieves the dimensions of the bounding rectangle of the specified window. The dimensions are given in screen coordinates that are relative to the upper-left corner of the screen.
        /// </summary>
        /// <param name="hWnd">A handle to the window.</param>
        /// <param name="rect">A RECT structure that receives the screen coordinates of the upper-left and lower-right corners of the window.</param>
        /// <remarks>In conformance with conventions for the RECT structure, the bottom-right coordinates of the returned rectangle are exclusive. In other words, the pixel at (right, bottom) lies immediately outside the rectangle.</remarks>
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero. To get extended error information, call GetLastError.
        /// </returns>
        [DllImport(Imports.USER32, SetLastError = false)]
        public unsafe static extern IntPtr GetWindowRect(IntPtr hWnd, out RECT rect);

        /// <summary>
        /// Retrieves the position of the mouse cursor, in screen coordinates.
        /// </summary>
        /// <param name="lpPoint">A POINT structure that receives the screen coordinates of the cursor.</param>
        /// <returns>Returns nonzero if successful or zero otherwise. To get extended error information, call <see cref="Get"/></returns>
        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern bool GetCursorPos(out POINT lpPoint);

        /// <summary>
        /// Moves the cursor to the specified screen coordinates. If the new coordinates are not within the screen rectangle set by the most recent ClipCursor function call, the system automatically adjusts the coordinates so that the cursor stays within the rectangle.
        /// </summary>
        /// <param name="x">The new x-coordinate of the cursor, in screen coordinates.</param>
        /// <param name="y">The new y-coordinate of the cursor, in screen coordinates.</param>
        /// <returns>Returns nonzero if successful or zero otherwise. To get extended error information, call GetLastError.</returns>
        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern bool SetCursorPos(int x, int y);

        /// <summary>
        /// The mouse_event function synthesizes mouse motion and button clicks.
        /// </summary>
        /// <param name="dwFlags">Controls various aspects of mouse motion and button clicking. This parameter can be certain combinations of the following values.</param>
        /// <param name="dx">The mouse's absolute position along the x-axis or its amount of motion since the last mouse event was generated, depending on the setting of MOUSEEVENTF_ABSOLUTE. Absolute data is specified as the mouse's actual x-coordinate; relative data is specified as the number of mickeys moved. A mickey is the amount that a mouse has to move for it to report that it has moved.</param>
        /// <param name="dy">The mouse's absolute position along the y-axis or its amount of motion since the last mouse event was generated, depending on the setting of MOUSEEVENTF_ABSOLUTE. Absolute data is specified as the mouse's actual y-coordinate; relative data is specified as the number of mickeys moved.</param>
        /// <param name="cButtons"></param>
        /// <param name="dwExtraInfo">An additional value associated with the mouse event. An application calls GetMessageExtraInfo to obtain this extra information.</param>
        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        /// <summary>
        ///     Installs an application-defined hook procedure into a hook chain. You would install a hook procedure to monitor the
        ///     system for certain types of events. These events are associated either with a specific thread or with all threads
        ///     in the same desktop as the calling thread.
        ///     <para>See https://msdn.microsoft.com/en-us/library/windows/desktop/ms644990%28v=vs.85%29.aspx for more information</para>
        /// </summary>
        /// <param name="hookType">
        ///     C++ ( idHook [in]. Type: int )<br />The type of hook procedure to be installed. This parameter can be one of the
        ///     following values.
        ///     <list type="table">
        ///         <listheader>
        ///             <term>Possible Hook Types</term>
        ///         </listheader>
        ///         <item>
        ///             <term>WH_CALLWNDPROC (4)</term>
        ///             <description>
        ///                 Installs a hook procedure that monitors messages before the system sends them to the
        ///                 destination window procedure. For more information, see the CallWndProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_CALLWNDPROCRET (12)</term>
        ///             <description>
        ///                 Installs a hook procedure that monitors messages after they have been processed by the
        ///                 destination window procedure. For more information, see the CallWndRetProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_CBT (5)</term>
        ///             <description>
        ///                 Installs a hook procedure that receives notifications useful to a CBT application. For more
        ///                 information, see the CBTProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_DEBUG (9)</term>
        ///             <description>
        ///                 Installs a hook procedure useful for debugging other hook procedures. For more information,
        ///                 see the DebugProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_FOREGROUNDIDLE (11)</term>
        ///             <description>
        ///                 Installs a hook procedure that will be called when the application's foreground thread is
        ///                 about to become idle. This hook is useful for performing low priority tasks during idle time. For more
        ///                 information, see the ForegroundIdleProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_GETMESSAGE (3)</term>
        ///             <description>
        ///                 Installs a hook procedure that monitors messages posted to a message queue. For more
        ///                 information, see the GetMsgProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_JOURNALPLAYBACK (1)</term>
        ///             <description>
        ///                 Installs a hook procedure that posts messages previously recorded by a WH_JOURNALRECORD hook
        ///                 procedure. For more information, see the JournalPlaybackProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_JOURNALRECORD (0)</term>
        ///             <description>
        ///                 Installs a hook procedure that records input messages posted to the system message queue. This
        ///                 hook is useful for recording macros. For more information, see the JournalRecordProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_KEYBOARD (2)</term>
        ///             <description>
        ///                 Installs a hook procedure that monitors keystroke messages. For more information, see the
        ///                 KeyboardProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_KEYBOARD_LL (13)</term>
        ///             <description>
        ///                 Installs a hook procedure that monitors low-level keyboard input events. For more information,
        ///                 see the LowLevelKeyboardProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_MOUSE (7)</term>
        ///             <description>
        ///                 Installs a hook procedure that monitors mouse messages. For more information, see the
        ///                 MouseProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_MOUSE_LL (14)</term>
        ///             <description>
        ///                 Installs a hook procedure that monitors low-level mouse input events. For more information,
        ///                 see the LowLevelMouseProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_MSGFILTER (-1)</term>
        ///             <description>
        ///                 Installs a hook procedure that monitors messages generated as a result of an input event in a
        ///                 dialog box, message box, menu, or scroll bar. For more information, see the MessageProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_SHELL (10)</term>
        ///             <description>
        ///                 Installs a hook procedure that receives notifications useful to shell applications. For more
        ///                 information, see the ShellProc hook procedure.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <term>WH_SYSMSGFILTER (6)</term><description></description>
        ///         </item>
        ///     </list>
        /// </param>
        /// <param name="lpfn">
        ///     C++ ( lpfn [in]. Type: HOOKPROC )<br />A pointer to the hook procedure. If the dwThreadId parameter
        ///     is zero or specifies the identifier of a thread created by a different process, the lpfn parameter must point to a
        ///     hook procedure in a DLL. Otherwise, lpfn can point to a hook procedure in the code associated with the current
        ///     process.
        /// </param>
        /// <param name="hMod">
        ///     C++ ( hMod [in]. Type: HINSTANCE )<br />A handle to the DLL containing the hook procedure pointed to
        ///     by the lpfn parameter. The hMod parameter must be set to NULL if the dwThreadId parameter specifies a thread
        ///     created by the current process and if the hook procedure is within the code associated with the current process.
        /// </param>
        /// <param name="dwThreadId">
        ///     C++ ( dwThreadId [in]. Type: DWORD )<br />The identifier of the thread with which the hook
        ///     procedure is to be associated. For desktop apps, if this parameter is zero, the hook procedure is associated with
        ///     all existing threads running in the same desktop as the calling thread. For Windows Store apps, see the Remarks
        ///     section.
        /// </param>
        /// <returns>
        ///     C++ ( Type: HHOOK )<br />If the function succeeds, the return value is the handle to the hook procedure. If
        ///     the function fails, the return value is NULL.
        ///     <para>To get extended error information, call GetLastError.</para>
        /// </returns>
        /// <remarks>
        ///     <para>
        ///         SetWindowsHookEx can be used to inject a DLL into another process. A 32-bit DLL cannot be injected into a
        ///         64-bit process, and a 64-bit DLL cannot be injected into a 32-bit process. If an application requires the use
        ///         of hooks in other processes, it is required that a 32-bit application call SetWindowsHookEx to inject a 32-bit
        ///         DLL into 32-bit processes, and a 64-bit application call SetWindowsHookEx to inject a 64-bit DLL into 64-bit
        ///         processes. The 32-bit and 64-bit DLLs must have different names.
        ///     </para>
        ///     <para>
        ///         Because hooks run in the context of an application, they must match the "bitness" of the application. If a
        ///         32-bit application installs a global hook on 64-bit Windows, the 32-bit hook is injected into each 32-bit
        ///         process (the usual security boundaries apply). In a 64-bit process, the threads are still marked as "hooked."
        ///         However, because a 32-bit application must run the hook code, the system executes the hook in the hooking app's
        ///         context; specifically, on the thread that called SetWindowsHookEx. This means that the hooking application must
        ///         continue to pump messages or it might block the normal functioning of the 64-bit processes.
        ///     </para>
        ///     <para>
        ///         If a 64-bit application installs a global hook on 64-bit Windows, the 64-bit hook is injected into each
        ///         64-bit process, while all 32-bit processes use a callback to the hooking application.
        ///     </para>
        ///     <para>
        ///         To hook all applications on the desktop of a 64-bit Windows installation, install a 32-bit global hook and a
        ///         64-bit global hook, each from appropriate processes, and be sure to keep pumping messages in the hooking
        ///         application to avoid blocking normal functioning. If you already have a 32-bit global hooking application and
        ///         it doesn't need to run in each application's context, you may not need to create a 64-bit version.
        ///     </para>
        ///     <para>
        ///         An error may occur if the hMod parameter is NULL and the dwThreadId parameter is zero or specifies the
        ///         identifier of a thread created by another process.
        ///     </para>
        ///     <para>
        ///         Calling the CallNextHookEx function to chain to the next hook procedure is optional, but it is highly
        ///         recommended; otherwise, other applications that have installed hooks will not receive hook notifications and
        ///         may behave incorrectly as a result. You should call CallNextHookEx unless you absolutely need to prevent the
        ///         notification from being seen by other applications.
        ///     </para>
        ///     <para>
        ///         Before terminating, an application must call the UnhookWindowsHookEx function to free system resources
        ///         associated with the hook.
        ///     </para>
        ///     <para>
        ///         The scope of a hook depends on the hook type. Some hooks can be set only with global scope; others can also
        ///         be set for only a specific thread, as shown in the following table.
        ///     </para>
        ///     <list type="table">
        ///         <listheader>
        ///             <term>Possible Hook Types</term>
        ///         </listheader>
        ///         <item>
        ///             <term>WH_CALLWNDPROC (4)</term>
        ///             <description>Thread or global</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_CALLWNDPROCRET (12)</term>
        ///             <description>Thread or global</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_CBT (5)</term>
        ///             <description>Thread or global</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_DEBUG (9)</term>
        ///             <description>Thread or global</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_FOREGROUNDIDLE (11)</term>
        ///             <description>Thread or global</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_GETMESSAGE (3)</term>
        ///             <description>Thread or global</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_JOURNALPLAYBACK (1)</term>
        ///             <description>Global only</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_JOURNALRECORD (0)</term>
        ///             <description>Global only</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_KEYBOARD (2)</term>
        ///             <description>Thread or global</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_KEYBOARD_LL (13)</term>
        ///             <description>Global only</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_MOUSE (7)</term>
        ///             <description>Thread or global</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_MOUSE_LL (14)</term>
        ///             <description>Global only</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_MSGFILTER (-1)</term>
        ///             <description>Thread or global</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_SHELL (10)</term>
        ///             <description>Thread or global</description>
        ///         </item>
        ///         <item>
        ///             <term>WH_SYSMSGFILTER (6)</term>
        ///             <description>Global only</description>
        ///         </item>
        ///     </list>
        ///     <para>
        ///         For a specified hook type, thread hooks are called first, then global hooks. Be aware that the WH_MOUSE,
        ///         WH_KEYBOARD, WH_JOURNAL*, WH_SHELL, and low-level hooks can be called on the thread that installed the hook
        ///         rather than the thread processing the hook. For these hooks, it is possible that both the 32-bit and 64-bit
        ///         hooks will be called if a 32-bit hook is ahead of a 64-bit hook in the hook chain.
        ///     </para>
        ///     <para>
        ///         The global hooks are a shared resource, and installing one affects all applications in the same desktop as
        ///         the calling thread. All global hook functions must be in libraries. Global hooks should be restricted to
        ///         special-purpose applications or to use as a development aid during application debugging. Libraries that no
        ///         longer need a hook should remove its hook procedure.
        ///     </para>
        ///     <para>
        ///         Windows Store app development If dwThreadId is zero, then window hook DLLs are not loaded in-process for the
        ///         Windows Store app processes and the Windows Runtime broker process unless they are installed by either UIAccess
        ///         processes (accessibility tools). The notification is delivered on the installer's thread for these hooks:
        ///     </para>
        ///     <list type="bullet">
        ///         <item>
        ///             <term>WH_JOURNALPLAYBACK</term>
        ///         </item>
        ///         <item>
        ///             <term>WH_JOURNALRECORD </term>
        ///         </item>
        ///         <item>
        ///             <term>WH_KEYBOARD </term>
        ///         </item>
        ///         <item>
        ///             <term>WH_KEYBOARD_LL </term>
        ///         </item>
        ///         <item>
        ///             <term>WH_MOUSE </term>
        ///         </item>
        ///         <item>
        ///             <term>WH_MOUSE_LL </term>
        ///         </item>
        ///     </list>
        ///     <para>
        ///         This behavior is similar to what happens when there is an architecture mismatch between the hook DLL and the
        ///         target application process, for example, when the hook DLL is 32-bit and the application process 64-bit.
        ///     </para>
        ///     <para>
        ///         For an example, see Installing and
        ///         <see
        ///             cref="!:https://msdn.microsoft.com/en-us/library/windows/desktop/ms644960%28v=vs.85%29.aspx#installing_releasing">
        ///             Releasing
        ///             Hook Procedures.
        ///         </see>
        ///         [
        ///         https://msdn.microsoft.com/en-us/library/windows/desktop/ms644960%28v=vs.85%29.aspx#installing_releasing ]
        ///     </para>
        /// </remarks>
        [DllImport(Imports.USER32, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(HookType hookType, LowLevelHookCallback lpfn, IntPtr hMod, uint dwThreadId);

        /// <summary>
        ///     Removes a hook procedure installed in a hook chain by the SetWindowsHookEx function.
        ///     <para>
        ///     See [ https://msdn.microsoft.com/en-us/library/windows/desktop/ms644993%28v=vs.85%29.aspx ] for more
        ///     information
        ///     </para>
        /// </summary>
        /// <param name="hhk">
        ///     C++ ( hhk [in]. Type: HHOOK )<br />A handle to the hook to be removed. This parameter is a hook
        ///     handle obtained by a previous call to <see cref="SetWindowsHookEx" />.
        /// </param>
        /// <returns>
        ///     C++ ( Type: BOOL )
        ///     <c>true</c> or nonzero if the function succeeds, <c>false</c> or zero if the function fails.
        ///     <para>
        ///     To get extended error information, call
        ///     <see cref="!:https://msdn.microsoft.com/en-us/library/windows/desktop/ms679360%28v=vs.85%29.aspx">GetLastError</see>
        ///     .
        ///     </para>
        ///     <para>The return value is the calling thread's last-error code.</para>
        ///     The Return Value section of the documentation for each function that sets the last-error code notes the conditions
        ///     under which the function sets the last-error code. Most functions that set the thread's last-error code set it when
        ///     they fail. However, some functions also set the last-error code when they succeed. If the function is not
        ///     documented to set the last-error code, the value returned by this function is simply the most recent last-error
        ///     code to have been set; some functions set the last-error code to 0 on success and others do not.
        ///     <para></para>
        /// </returns>
        /// <remarks>
        ///     <para>
        ///     The hook procedure can be in the state of being called by another thread even after UnhookWindowsHookEx
        ///     returns. If the hook procedure is not being called concurrently, the hook procedure is removed immediately
        ///     before <see cref="UnhookWindowsHookEx" /> returns.
        ///     </para>
        ///     <para>
        ///     For an example, see
        ///     <see cref="!:https://msdn.microsoft.com/en-us/library/windows/desktop/ms644960%28v=vs.85%29.aspx#system_events">
        ///         Monitoring
        ///         System Events
        ///     </see>
        ///     .
        ///     </para>
        /// </remarks>
        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        /// <summary>
        ///     Passes the hook information to the next hook procedure in the current hook chain. A hook procedure can call this
        ///     function either before or after processing the hook information.
        ///     <para>
        ///     See [ https://msdn.microsoft.com/en-us/library/windows/desktop/ms644974%28v=vs.85%29.aspx ] for more
        ///     information.
        ///     </para>
        /// </summary>
        /// <param name="hhk">C++ ( hhk [in, optional]. Type: HHOOK )<br />This parameter is ignored. </param>
        /// <param name="nCode">
        ///     C++ ( nCode [in]. Type: int )<br />The hook code passed to the current hook procedure. The next
        ///     hook procedure uses this code to determine how to process the hook information.
        /// </param>
        /// <param name="wParam">
        ///     C++ ( wParam [in]. Type: WPARAM )<br />The wParam value passed to the current hook procedure. The
        ///     meaning of this parameter depends on the type of hook associated with the current hook chain.
        /// </param>
        /// <param name="lParam">
        ///     C++ ( lParam [in]. Type: LPARAM )<br />The lParam value passed to the current hook procedure. The
        ///     meaning of this parameter depends on the type of hook associated with the current hook chain.
        /// </param>
        /// <returns>
        ///     C++ ( Type: LRESULT )<br />This value is returned by the next hook procedure in the chain. The current hook
        ///     procedure must also return this value. The meaning of the return value depends on the hook type. For more
        ///     information, see the descriptions of the individual hook procedures.
        /// </returns>
        /// <remarks>
        ///     <para>
        ///     Hook procedures are installed in chains for particular hook types. <see cref="CallNextHookEx" /> calls the
        ///     next hook in the chain.
        ///     </para>
        ///     <para>
        ///     Calling CallNextHookEx is optional, but it is highly recommended; otherwise, other applications that have
        ///     installed hooks will not receive hook notifications and may behave incorrectly as a result. You should call
        ///     <see cref="CallNextHookEx" /> unless you absolutely need to prevent the notification from being seen by other
        ///     applications.
        ///     </para>
        /// </remarks>
        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern int ToUnicodeEx(uint key, uint scancode, byte[] keyState, StringBuilder buffer, int bufferSuise, uint flags, IntPtr kblout);

        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern bool GetKeyboardState(byte[] buffer);

        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern int GetAsyncKeyState(Keys vkCode);

        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern IntPtr GetKeyboardLayout(uint idThread);

        /// <summary>
        /// Retrieves the extra message information for the current thread. Extra message information is an application- or driver-defined value associated with the current thread's message queue.
        /// </summary>
        /// <returns>The return value specifies the extra information. The meaning of the extra information is device specific.</returns>
        [DllImport(Imports.USER32, SetLastError = false)]
        public static extern IntPtr GetMessageExtraInfo();
       
    }
}
