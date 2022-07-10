using Exercise4_6.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_6.Classes
{
    public class IMMobile : BaseEquipment
    {
        public int _Weight { get; set; } = 0;

        public IMMobile(int Weight)
        {
            _Weight = Weight;
        }
        public override int MaintenanceCost()
        {
            base.equipmentModel.MaintenanceCost = _Weight * base.equipmentModel.DistanceMovedTillDate;
            return base.equipmentModel.MaintenanceCost;
        }

       
        public void MoveBy(int distance)
        {
            base.MoveByDistance(distance);
        }
    }
}
