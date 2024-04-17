using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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

        // TODO: Listen to mouse events

    }
}
