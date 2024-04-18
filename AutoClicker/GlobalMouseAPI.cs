using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoClicker
{
    public class GlobalMouseAPI
    {
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;

        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x40;

        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        private const int WH_MOUSE_LL = 14;
        private HookProc mouseHookProc;
        private IntPtr mouseHookID = IntPtr.Zero;

        public event MouseEventHandler MouseAction;

        public GlobalMouseAPI()
        {
            mouseHookProc = new HookProc(MouseHookCallback);
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                mouseHookID = (IntPtr)SetWindowsHookEx(WH_MOUSE_LL, mouseHookProc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private int MouseHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && (MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam || MouseMessages.WM_MBUTTONDOWN == (MouseMessages)wParam || MouseMessages.WM_RBUTTONDOWN == (MouseMessages)wParam))
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                MouseAction?.Invoke(this, new MouseEventArgs(GetButton((MouseMessages)wParam), 0, hookStruct.pt.X, hookStruct.pt.Y, 0));
            }
            return CallNextHookEx((int)mouseHookID, nCode, wParam, lParam);
        }

        private MouseButtons GetButton(MouseMessages message)
        {
            switch (message)
            {
                case MouseMessages.WM_LBUTTONDOWN:
                    return MouseButtons.Left;
                case MouseMessages.WM_MBUTTONDOWN:
                    return MouseButtons.Middle;
                case MouseMessages.WM_RBUTTONDOWN:
                    return MouseButtons.Right;
                default:
                    return MouseButtons.None;
            }
        }

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_MBUTTONDOWN = 0x0207,
            WM_RBUTTONDOWN = 0x0204
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public Point pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        public void Dispose()
        {
            UnhookWindowsHookEx((int)mouseHookID);
        }

        public static void MoveCursor(int x, int y)
        {
            SetCursorPos(x, y);
        }

        public static int GetCursorPositionX() => System.Windows.Forms.Cursor.Position.X;

        public static int GetCursorPositionY() => System.Windows.Forms.Cursor.Position.Y;

        public static void LeftClick(int x, int y)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

        public static void LeftClick()
        {
            LeftClick(GetCursorPositionX(), GetCursorPositionY());
        }

        public static void RightClick(int x, int y)
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
        }

        public static void RightClick()
        {
            RightClick(GetCursorPositionX(), GetCursorPositionY());
        }

        public static void MiddleClick(int x, int y)
        {
            mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, x, y, 0, 0);
        }

        public static void MiddleClick()
        {
            MiddleClick(GetCursorPositionX(), GetCursorPositionY());
        }
    }
}
