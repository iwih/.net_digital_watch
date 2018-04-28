using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalWatch
{
    [DataContract]
    internal class Settings
    {
        [DataMember] internal Color ForeColor { set; get; }

        [DataMember] internal Color BackColor { set; get; }

        [DataMember] internal ButtonBorderStyle BorderStyle { set; get; }

        [DataMember] internal string FontFamily { set; get; }
        [DataMember] internal float FontSize { set; get; }

        [DataMember] internal Point Location { set; get; }

        public Settings(Color foreColor, Color backColor, ButtonBorderStyle borderStyle, Font font, Point location)
        {
            ForeColor = foreColor;
            BackColor = backColor;
            BorderStyle = borderStyle;
            FontFamily = font.FontFamily.Name;
            FontSize = font.Size;
            Location = location;
        }

        private static readonly string SettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "settings.json");

        internal static async Task WriteSettings(
            Color foreColor,
            Color backColor,
            ButtonBorderStyle borderStyle,
            Font font,
            Point location)
        {
            using (var memoryStream = new MemoryStream())
            {
                var settings = new Settings(foreColor, backColor, borderStyle, font, location);

                var serializer = new DataContractJsonSerializer(typeof(Settings));
                serializer.WriteObject(memoryStream, settings);

                memoryStream.Position = 0;

                using (var streamReader = new StreamReader(memoryStream))
                {
                    var jsonStr = await streamReader.ReadToEndAsync();

                    try
                    {
                        await Task.Factory.StartNew(() => File.WriteAllText(SettingsPath, jsonStr));
                    }
                    catch
                    {
                        //ignore}
                    }

                    streamReader.Close();
                }

                memoryStream.Close();
            }
        }

        internal static async Task<Settings> ReadSettings()
        {
            var jsonStr = string.Empty;
            if (!File.Exists(SettingsPath)) return null;

            try
            {
                jsonStr = await Task.Factory.StartNew(() => File.ReadAllText(SettingsPath));
            }
            catch
            {
                //
            }

            if (string.IsNullOrEmpty(jsonStr)) return null;
            Settings settings = null;
            try
            {
                using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonStr)))
                {
                    var serializer = new DataContractJsonSerializer(typeof(Settings));
                    settings = serializer.ReadObject(memoryStream) as Settings;
                }
            }
            catch
            {
                //
            }

            return settings;
        }
    }
}