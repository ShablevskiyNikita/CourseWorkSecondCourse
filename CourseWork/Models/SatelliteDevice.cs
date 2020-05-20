﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class SatelliteDevice : CommunicationDevice
    {
        public readonly string defaultImagePath = @"../../images/default/satellite.png";
        private string _brand;
        private string _model;
        private string _description;
        private string _imageLink;
        private CommunicationTypes[] _communicationTypes;
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

        public override CommunicationTypes[] CommunicationTypes
        {
            get => _communicationTypes;
            set => _communicationTypes = value;
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
            get => _imageLink != null ? _imageLink : defaultImagePath;
            set => _imageLink = value;
        }

        public override string ToShortString()
        {
            return $"Brand:{_brand}, Model:{_model}";
        }
        public override string ToString()
        {
            return "";
        }
    }
}
