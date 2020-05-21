using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace CourseWork.Models
{
    public class BluetoothDevice : CommunicationDevice
    {
        public readonly string defaultImagePath = @"../../images/default/bluetooth.png";
        private string _brand;
        private string _model;
        private string _description;
        private string _imageLink;
        private double _dataTransmissionRange;
        private int _workingHours;
        private int _guaranteeMonth;
        private double _frequency;
        private double _price;
        private double _weight;

        public override string Brand
        {
            get => _brand;
            set => _brand = value;
        }
        public override string Model
        {
            get => _model;
            set => _model = value;
        }
        public override string Description
        {
            get => _description;
            set => _description = value;
        }

        public override double DataTransmissionRange
        {
            get => _dataTransmissionRange;
            set => _dataTransmissionRange = value;
        }
        public override int WorkingHours
        {
            get => _workingHours;
            set => _workingHours = value;
        }
        public override int GuaranteeMonth
        {
            get => _guaranteeMonth;
            set => _guaranteeMonth = value;
        }
        public override double Frequency
        {
            get => _frequency;
            set => _frequency = value;
        }
        public override double Price
        {
            get => _price;
            set => _price = value;
        }
        public override double Weight
        {
            get => _weight;
            set => _weight = value;
        }

        public override string IconPath
        {
            get => _imageLink;
            set => _imageLink = value;
        }    

        public override string DefaultImagePath
        {
            get => defaultImagePath;
        }

        public override XmlSchema GetSchema() => null;


        public override void ReadXml(XmlReader reader)
        {

        }
        public override void WriteXml(XmlWriter writer)
        {

        }

        public override string ToString()
        {
            return $"Brand:{_brand}, Model:{_model}";
        }
    }
}
