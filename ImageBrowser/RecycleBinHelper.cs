using System;
using System.Runtime.InteropServices;

namespace ImageBrowser
{
    public static class RecycleBinHelper
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct SHFILEOPSTRUCT
        {
            public IntPtr hwnd;
            public uint wFunc;
            public IntPtr pFrom;     // Double-null-terminated string
            public IntPtr pTo;       // Not used here
            public ushort fFlags;
            public bool fAnyOperationsAborted;
            public IntPtr hNameMappings;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpszProgressTitle;
        }

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        private static extern int SHFileOperation(ref SHFILEOPSTRUCT lpFileOp);

        private const uint FO_DELETE = 3;

        // Flags
        private const ushort FOF_ALLOWUNDO = 0x0040;      // Send to Recycle Bin
        private const ushort FOF_NOCONFIRMATION = 0x0010; // No confirm dialog
        private const ushort FOF_NOERRORUI = 0x0400;      // No error UI
        private const ushort FOF_SILENT = 0x0004;         // No progress dialog

        public static bool SendToRecycleBin(string path, bool showUI = false)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            var shf = new SHFILEOPSTRUCT
            {
                wFunc = FO_DELETE,
                // pFrom must be a double-null-terminated string
                pFrom = Marshal.StringToHGlobalUni(path + "\0\0"),
                fFlags = FOF_ALLOWUNDO
            };

            if (!showUI)
            {
                shf.fFlags |= (FOF_NOCONFIRMATION | FOF_NOERRORUI | FOF_SILENT);
            }

            int result = SHFileOperation(ref shf);

            // Free allocated memory
            Marshal.FreeHGlobal(shf.pFrom);

            // result == 0 means success, and no abort
            return result == 0 && !shf.fAnyOperationsAborted;
        }
    }
}
