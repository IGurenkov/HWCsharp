using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Seminar
{

    public class Configuration
    {
        public string AppName { get; set; }
        public int Param1 { get; set; }
        public string Param2 { get; set; }

    }

    internal class Sample02
    {

        public static Configuration LoadConfigurationFromXml(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Configuration));
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            Configuration configuration = (Configuration)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
            return configuration;
        }

        public static void SaveConfigurationToXml(string fileName, Configuration configuration)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Configuration));
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, configuration);
            fileStream.Close();
        }

        static void Main(string[] args)
        {
            Configuration configuration = 
                LoadConfigurationFromXml(AppDomain.CurrentDomain.BaseDirectory + "AppConfiguration.xml");
            if (configuration != null)
            {
                Console.WriteLine($"{configuration.AppName} {configuration.Param1} {configuration.Param2}");
            }

            configuration.Param1 = 500;
            configuration.Param2 = "Change property";

            SaveConfigurationToXml(
                AppDomain.CurrentDomain.BaseDirectory + "AppConfiguration.new.xml", configuration);


            configuration =
                LoadConfigurationFromXml(AppDomain.CurrentDomain.BaseDirectory + "AppConfiguration.new.xml");
            if (configuration != null)
            {
                Console.WriteLine($"{configuration.AppName} {configuration.Param1} {configuration.Param2}");
            }

            Console.ReadKey();
        }
    }
}
