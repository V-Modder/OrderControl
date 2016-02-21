using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace OrderControl.Common
{
    class WinApi
    {
        /// <summary>
        /// For TrackPopupMenuEx API
        /// </summary>
        public const uint TPM_LEFTBUTTON = 0x0000;
        public const uint TPM_RETURNCMD = 0x0100;

        public const int WM_SYSCOMMAND = 0x0112;

        /// <summary>
        /// Gets the system (windows) menu for a window (the menu that appears when clicking the application icon on the top left of the window).
        /// </summary>
        /// <param name="hWnd">Handle of the Window to get the menu from.</param>
        /// <param name="bRevert">True=Clear any custom menu items and revert to Windows default.</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        /// <summary>
        /// Sends the specified message to a window or windows
        /// </summary>
        /// <param name="hWnd">handle to destination window</param>
        /// <param name="Msg">message</param>
        /// <param name="wParam">first message parameter</param>
        /// <param name="lParam">second message parameter</param>
        /// <returns>none</returns>
        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, UInt32 msg, UIntPtr wParam, IntPtr lParam);

        /// <summary>
        /// Displays a shortcut menu at the specified location and tracks the selection of items on the shortcut menu.
        /// The shortcut menu can appear anywhere on the screen.
        /// </summary>
        /// <param name="hmenu">A handle to the shortcut menu to be displayed.</param>
        /// <param name="fuFlags">Specifies function options.</param>
        /// <param name="x">The horizontal location of the shortcut menu, in screen coordinates. </param>
        /// <param name="y">The vertical location of the shortcut menu, in screen coordinates. </param>
        /// <param name="hwnd">A handle to the window that owns the shortcut menu. This window receives all messages from the menu. </param>
        /// <param name="lptpm">A pointer to a TPMPARAMS structure that specifies an area of the screen the menu should not overlap. This parameter can be NULL. </param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern uint TrackPopupMenuEx(IntPtr hmenu, uint fuFlags, int x, int y, IntPtr hwnd, IntPtr lptpm);
    }
}
