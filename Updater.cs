using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebMCam
{
    class Updater
    {
        public static string repositoryUrl = "https://github.com/neishwang/WebMCam";
        private static string versionUrl = "https://raw.githubusercontent.com/neishwang/WebMCam/master/VERSION";
        private static string downloadPageUrl = "https://github.com/neishwang/WebMCam/releases";

        private static readonly HttpClient http = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(10)
        };

        public static async Task CheckAsync(string oldVersionStr)
        {
            try
            {
                var newVersionStr = (await http.GetStringAsync(versionUrl)).Trim();

                var newVersion = new Version(newVersionStr);
                var oldVersion = new Version(oldVersionStr);

                if (newVersion.CompareTo(oldVersion) <= 0)
                    return;

                // Awaiting resumes on the UI thread, so the dialog belongs here now.
                // The previous Task.Run wrapper showed it from a thread pool thread.
                var result = MessageBox.Show(
                    string.Format(
                        "Version {0} is available for download. You are running version {1}." +
                        Environment.NewLine + "Would you like to be sent to the download page?",
                        newVersion, oldVersion
                    ),

                    "New Version Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                    Shell.Open(downloadPageUrl);
            }
            catch
            {
                /* Suppress */
            }
        }
    }
}
