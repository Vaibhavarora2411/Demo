using Exercise4_6.Interface;
using Exercise4_6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_6.Classes
{
    public class Mobile : BaseEquipment
    {
        public Mobile(int Wheels)
        {
            _Wheels = Wheels;
        }

        public int _Wheels { get; set; } = 0;
        public override int MaintenanceCost()
        {
            base.equipmentModel.MaintenanceCost = _Wheels * base.equipmentModel.DistanceMovedTillDate;
            return base.equipmentModel.MaintenanceCost;
        }

    
        public void MoveBy(int distance)
        {
            base.MoveByDistance(distance);
        }
    }
}
