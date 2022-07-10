using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_6.Model
{
    public enum EquipementType
    {
        Mobile,
        ImMobile
    }
    public class EquipmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DistanceMovedTillDate { get; set; } = 0;
        public int MaintenanceCost { get; set; } = 0;
        public int Wheels { get; set; } = 0;
        public int Weight { get; set; } = 0;

        public EquipementType TypeofEquipment { get; set; }

    }
}
