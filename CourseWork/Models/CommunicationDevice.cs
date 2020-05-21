using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CourseWork.Models
{
    public abstract class CommunicationDevice : IXmlSerializable
    {
        public abstract string DefaultImagePath { get; }
        public abstract string IconPath { get; set; }
        public abstract string Brand { get; set; }
        public abstract string Model { get; set; }
        public abstract string Description { get; set; }
        public abstract double DataTransmissionRange { get; set; }    
        public abstract int WorkingHours { get; set; }
        public abstract int GuaranteeMonth { get; set; }     
        public abstract double Frequency { get; set; }
        public abstract double Price { get; set; }
        public abstract double Weight { get; set; }

        public static List<CommunicationDevice> ReadDevicesList(string fileName)
        {
            List<CommunicationDevice> devices = new List<CommunicationDevice>();
            if(File.Exists(fileName))
            {
                using (XmlReader reader = XmlReader.Create(fileName))
                {
                    reader.MoveToContent();
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            CommunicationDevice device = CreateDeviceInstance(reader.Name);
                            device.ReadXml(reader);
                            devices.Add(device);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return devices;
        }

        public static void WriteDevicesToFile(string fileName, List<CommunicationDevice> devices)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = false;
            settings.NewLineOnAttributes = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);
            xmlWriter.WriteStartElement("Devices");
            devices.ForEach(device =>
            {
                device.WriteXml(xmlWriter);
            });
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }

        private static CommunicationDevice CreateDeviceInstance(string selectedType)
        {        
            switch (selectedType)
            {
                case "BluetoothDevice":
                    return new BluetoothDevice();
                case "RadioDevice":
                    return new RadioDevice();
                case "MobileDevice":
                    return new MobileDevice();
                case "WiFiDevice":
                    return new WiFiDevice();
                case "SatelliteDevice":
                    return new SatelliteDevice();

                default:
                    return null;
            }

        }

        public abstract XmlSchema GetSchema();
        public abstract void ReadXml(XmlReader reader);
        public abstract void WriteXml(XmlWriter writer);
    }
}
