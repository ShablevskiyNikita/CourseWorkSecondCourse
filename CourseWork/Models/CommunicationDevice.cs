using System;
using System.Collections.Generic;
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

        public abstract XmlSchema GetSchema();
        public abstract void ReadXml(XmlReader reader);
        public abstract void WriteXml(XmlWriter writer);
    }
}
