using Exercise4_6.Interface;
using Exercise4_6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_6.Classes
{
    public abstract class BaseEquipment : IEquipment
    {
        public abstract int MaintenanceCost();

        public EquipmentModel equipmentModel;

        protected BaseEquipment()
        {
            equipmentModel = new EquipmentModel();
        }
        bool IEquipment.Create(EquipmentModel _equipmentModel)
        {
            equipmentModel = _equipmentModel;
            return true;
        }

        public EquipmentModel GetEquipment()
        {
            return equipmentModel;
        }

        public void MoveByDistance(int Distance)
        {
            equipmentModel.DistanceMovedTillDate += Distance;
        }

        void IEquipment.MaintenanceCost()
        {
            MaintenanceCost();
        }
    }
}
