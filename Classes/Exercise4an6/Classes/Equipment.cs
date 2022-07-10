using Exercise4_6.Interface;
using Exercise4_6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_6.Classes
{
    public class Equipment
    {
        IEquipment equipment = null;
        public bool Create(EquipmentModel equipmentModel)
        {
            switch (equipmentModel.TypeofEquipment)
            {
                case EquipementType.Mobile:
                    equipment = new Mobile(equipmentModel.Wheels);
                    return equipment.Create(equipmentModel);
                    
                case EquipementType.ImMobile:
                    equipment = new IMMobile(equipmentModel.Weight);
                    return equipment.Create(equipmentModel);
                default:
                    return false;
            }
            
        }

        public EquipmentModel GetEquipment()
        {

            return equipment.GetEquipment();
        }

        public void MoveByDistance(int distance)
        {
            equipment.MoveByDistance(distance);
        }

        public void MaintenanceCost()
        {
            equipment.MaintenanceCost();
        }


    }
}
