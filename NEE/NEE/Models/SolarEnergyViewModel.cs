using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEE.Models
{
    public class SolarEnergyViewModel
    {
        public string IntegrationType { get; set; }
        public string PVCellsType { get; set; }
        public int OrientationFieldType { get; set; }
        public int RoofSlopeType { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Area { get; set; }

    }
}
