using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace CourseWork.Models
{
    public class WiFiDevice : CommunicationDevice
    {
        public readonly string defaultImagePath = @"../../images/default/wifi.png";
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
            reader.MoveToContent();
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "Brand":
                            reader.Read();
                            _brand = reader.Value;
                            break;

                        case "Model":
                            reader.Read();
                            _model = reader.Value;
                            break;

                        case "Description":
                            reader.Read();
                            _description = reader.Value;
                            break;


                        case "ImageLink":
                            reader.Read();
                            _imageLink = reader.Value;
                            break;

                        case "DataTransmissionRange":
                            reader.Read();
                            _dataTransmissionRange = double.Parse(reader.Value);
                            break;

                        case "WorkingHours":
                            reader.Read();
                            _workingHours = int.Parse(reader.Value);
                            break;

                        case "GuaranteeMonth":
                            reader.Read();
                            _guaranteeMonth = int.Parse(reader.Value);
                            break;

                        case "Frequency":
                            reader.Read();
                            _frequency = double.Parse(reader.Value);
                            break;

                        case "Price":
                            reader.Read();
                            _price = double.Parse(reader.Value);
                            break;

                        case "Weight":
                            reader.Read();
                            _weight = double.Parse(reader.Value);
                            break;
                    }
                }
                if (reader.Name.Equals("WiFiDevice"))
                {
                    reader.Read();
                    break;
                }
            }
        }
        public override void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("WiFiDevice");
            writer.WriteElementString("Brand", _brand);
            writer.WriteElementString("Model", _model);
            writer.WriteElementString("Description", _description);
            writer.WriteElementString("ImageLink", _imageLink != null ? _imageLink : defaultImagePath);
            writer.WriteElementString("DataTransmissionRange", _dataTransmissionRange.ToString());
            writer.WriteElementString("WorkingHours", _workingHours.ToString());
            writer.WriteElementString("GuaranteeMonth", _guaranteeMonth.ToString());
            writer.WriteElementString("Frequency", _frequency.ToString());
            writer.WriteElementString("Price", _price.ToString());
            writer.WriteElementString("Weight", _weight.ToString());

            writer.WriteEndElement();
        }
        public override string ToString()
        {
            return $"Бренд: {_brand}, Модель: {_model}, Гарантія: {_guaranteeMonth}, Вага: {_weight} кг, Частота сигналу: {_frequency} Гц, Ціна: {_price} грн ";
        }
    }
}
