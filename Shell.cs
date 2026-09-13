using System.Diagnostics;

namespace WebMCam
{
    /// <summary>
    /// Opening a URL or a document with the system default handler.
    ///
    /// Process.Start(string) used to do this on its own, but UseShellExecute only
    /// defaults to true on .NET Framework. Since the move to .NET 10 it defaults to
    /// false, and handing a URL or a .webm path to CreateProcess throws
    /// Win32Exception instead of opening anything.
    /// </summary>
    static class Shell
    {
        public static void Open(string target)
        {
            Process.Start(new ProcessStartInfo(target) { UseShellExecute = true });
        }
    }
}
