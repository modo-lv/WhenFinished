using System;
using System.IO;
using System.Xml.Serialization;

namespace WhenFinished.Infrastructure
{
    /// <summary>
    /// User settings for the application.
    /// </summary>
    [Serializable]
    public class Config
    {
        /// <summary>
        /// Deserialize an XML file to a user configuration object.
        /// </summary>
        /// <param name="filePath">Path to the XML file.</param>
        /// <returns>A <see cref="Config"/> object with values deserialized from an XML file</returns>
        public static Config LoadConfig(String filePath)
        {
            var ser = new XmlSerializer(typeof(Config));
            using (var reader = new StreamReader(filePath))
            {
                return (Config)ser.Deserialize(reader);
            }
        }

        /// <summary>
        /// Serialize user configuration to a given XML file.
        /// </summary>
        /// <param name="config">User configuration to serialize.</param>
        /// <param name="filePath">Path to the XML file.</param>
        public static void SaveConfig(Config config, String filePath)
        {
            var ser = new XmlSerializer(typeof(Config));
            using (var writer = new StreamWriter(filePath))
            {
                ser.Serialize(writer, config);
            }
        }
    }
}
