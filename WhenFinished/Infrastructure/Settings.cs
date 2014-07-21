using System;
using Simpler.Net.FileSystem;

namespace WhenFinished.Infrastructure
{
    /// <summary>
    /// Mostly constant application settings.
    /// For user settings, see <see cref="Config"/>
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Folder within system profile's application data where user
        /// config is stored.
        /// </summary>
        public const String ConfigFolder = @"MoDo_lv\WhenFinished";

        /// <summary>
        /// Full path to the configuration folder.
        /// </summary>
        public static String ConfigFolderPath
        {
            get
            {
#if DEBUG
                return ".";
#endif
                return SimplerPath.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    ConfigFolder);
            }
        }

        /// <summary>
        /// Full path to the configuration file.
        /// </summary>
        public static String ConfigFilePath
        {
            get { return SimplerPath.Combine(ConfigFolderPath, "config.xml"); }
        }
    }
}
