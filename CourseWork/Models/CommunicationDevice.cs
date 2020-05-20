using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public abstract class CommunicationDevice
    {
        public abstract string IconPath { get; set; }
        public abstract string Brand { get; set; }
        public abstract string Model { get; set; }
        public abstract string Description { get; set; }
        public abstract CommunicationTypes[] CommunicationTypes { get; set;}
        public abstract double DataTransmissionRange { get; set; }    
        public abstract int WorkingHours { get; set; }
        public abstract int GuaranteeMonth { get; set; }     
        public abstract double Frequency { get; set; }
        public abstract double Price { get; set; }
        public abstract double Weight { get; set; }
        public abstract string ToShortString();
    }
}
