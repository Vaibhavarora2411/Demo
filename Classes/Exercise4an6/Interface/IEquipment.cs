using Exercise4_6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_6.Interface
{
    public interface IEquipment
    {
        bool Create(EquipmentModel equipmentModel);
        EquipmentModel GetEquipment();
        void MoveByDistance(int distance);
        void MaintenanceCost();
    }
}
