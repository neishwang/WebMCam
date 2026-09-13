using System;
using System.IO;

namespace WebMCam
{
    static class FFmpeg
    {
        /// <summary>
        /// Turn the configured FFmpeg path into one that actually resolves.
        ///
        /// The setting defaults to the bare name "ffmpeg.exe", which Windows would
        /// look up in the current working directory -- whatever launched us, which
        /// is not necessarily our own folder. Releases ship ffmpeg.exe next to
        /// WebMCam.exe, so resolve relative paths against the application directory.
        /// </summary>
        public static string ResolvePath(string configured)
        {
            if (string.IsNullOrWhiteSpace(configured))
                configured = "ffmpeg.exe";

            if (Path.IsPathRooted(configured))
                return configured;

            return Path.Combine(AppContext.BaseDirectory, configured);
        }
    }
}
