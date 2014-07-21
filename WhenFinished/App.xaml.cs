using System.IO;
using Simpler.Net.Events.Logging;
using WhenFinished.Infrastructure;
using WhenFinished.Infrastructure.Logging;

namespace WhenFinished
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        /// <summary>
        /// Current user's application settings.
        /// </summary>
        public static Config Config { get; set; }

        /// <summary>
        /// Event logger.
        /// </summary>
        public static ILogger Logger { get; private set; }

        /// <summary>
        /// Load user configuration.
        /// </summary>
        /// <returns></returns>
        public static Config LoadConfig()
        {
            if (File.Exists(Settings.ConfigFilePath))
            {
                Logger.AddNewInfo("Loading configuration.");
                return Config.LoadConfig(Settings.ConfigFilePath);
            }
            Logger.AddNewInfo("Config file does not exist, initializing default configuration.");
            return new Config();
        }

        /// <summary>
        /// Save current user's config.
        /// </summary>
        public static void SaveConfig()
        {
            Logger.AddNewInfo("Saving configuration...");
            Config.SaveConfig(Config, Settings.ConfigFilePath);
        }

        static App()
        {
            Logger = new Logger();
        }
    }
}
