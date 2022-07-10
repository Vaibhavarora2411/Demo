using Exercise4_6.Classes;
using Exercise4_6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaibhav_assignment.Classes.Exercise4an6.Classes
{
    public class EqupmentExercise
    {
        public void Exercise4()
        {
            Equipment equipment = new Equipment();
            EquipmentModel equipmentModel = new EquipmentModel();
            equipmentModel.Name = "JCB";
            equipmentModel.Description = "JCB Machine";
            equipmentModel.Wheels = 6;
            equipmentModel.TypeofEquipment = EquipementType.Mobile;
            equipment.Create(equipmentModel);
            equipment.MoveByDistance(100);
            equipment.MoveByDistance(50);
            equipment.MaintenanceCost();
            Console.WriteLine("EquipmentType : {0}", equipment.GetEquipment().TypeofEquipment);
            Console.WriteLine("Wheels : {0}", equipment.GetEquipment().Wheels);
            Console.WriteLine("Total Distance : {0}", equipment.GetEquipment().DistanceMovedTillDate);
            Console.WriteLine("Maintenance Cost : {0}", equipment.GetEquipment().MaintenanceCost);


            equipment = new Equipment();
            equipmentModel = new EquipmentModel();
            equipmentModel.Name = "Ladder";
            equipmentModel.Description = "Ladder";
            equipmentModel.Weight = 4;
            equipmentModel.TypeofEquipment = EquipementType.ImMobile;
            equipment.Create(equipmentModel);
            equipment.MoveByDistance(100);
            equipment.MoveByDistance(50);
            equipment.MaintenanceCost();
            Console.WriteLine("EquipmentType : {0}", equipment.GetEquipment().TypeofEquipment);
            Console.WriteLine("Weight : {0}", equipment.GetEquipment().Weight);
            Console.WriteLine("Total Distance : {0}", equipment.GetEquipment().DistanceMovedTillDate);
            Console.WriteLine("Maintenance Cost : {0}", equipment.GetEquipment().MaintenanceCost);
        }

        private  List<Equipment> equipments = new List<Equipment>();

        public  void Exercise6()
        {
            equipments.Clear();
            Console.WriteLine("Create an Equipment");
            Equipment equipment = new Equipment();
            EquipmentModel equipmentModel = new EquipmentModel() { Name = "JCB", Description = "JCB Machine", Wheels = 6, TypeofEquipment = EquipementType.Mobile };
            equipment.Create(equipmentModel);
            equipment.MoveByDistance(10);
            equipment.MoveByDistance(20);
            equipment.MaintenanceCost();
            equipments.Add(equipment);
            Console.WriteLine("Added an Equipment in the List");

            equipment = new Equipment();
            equipmentModel = new EquipmentModel() { Name = "Thar", Description = "SUV", Wheels = 4, TypeofEquipment = EquipementType.Mobile };
            equipment.Create(equipmentModel);
            equipment.MaintenanceCost();
            equipments.Add(equipment);
            Console.WriteLine("Added an Equipment in the List");

            equipment = new Equipment();
            equipmentModel = new EquipmentModel() { Name = "Ladder", Description = "Ladder", Weight = 6, TypeofEquipment = EquipementType.ImMobile };
            equipment.Create(equipmentModel);
            equipment.MoveByDistance(200);
            equipment.MoveByDistance(50);
            equipment.MaintenanceCost();
            equipments.Add(equipment);
            Console.WriteLine("Added an Equipment in the List");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("All Equipment in the List");
            ListEquipments();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All Mobile Equipment in the List");
            ListMobileEquipments();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("All IMMobile Equipment in the List");
            ListIMMobileEquipments();
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("All UnMoved Equipment in the List");
            ListUnMovedEquipments();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Remove All Mobile Equipment in the List");

            RemoveMobileEquipments();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("All Equipment in the List");
            ListEquipments();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Remove All IMMobile Equipment in the List");

            RemoveIMMobileEquipments();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("All Equipment in the List");
            ListEquipments();
            Console.ForegroundColor = ConsoleColor.White;
        }

        private  void ListEquipments()
        {
            foreach (Equipment item in equipments)
            {
                Console.WriteLine("Equipment {0} - {1} - {2}", item.GetEquipment().Name, item.GetEquipment().Description, item.GetEquipment().TypeofEquipment);
            }
        }

        private  void ListMobileEquipments()
        {
            foreach (Equipment item in equipments.Where(x => x.GetEquipment().TypeofEquipment == EquipementType.Mobile))
            {
                Console.WriteLine("Equipment {0} - {1} - {2}", item.GetEquipment().Name, item.GetEquipment().Description, item.GetEquipment().TypeofEquipment);
                Console.WriteLine("TotalDistance : {0} -- Wheels : {1} -- MaintenanceCost : {2}", item.GetEquipment().DistanceMovedTillDate, item.GetEquipment().Wheels, item.GetEquipment().MaintenanceCost);

            }
        }

        private  void ListIMMobileEquipments()
        {
            foreach (Equipment item in equipments.Where(x => x.GetEquipment().TypeofEquipment == EquipementType.ImMobile))
            {
                Console.WriteLine("Equipment {0} - {1} - {2}", item.GetEquipment().Name, item.GetEquipment().Description, item.GetEquipment().TypeofEquipment);
                Console.WriteLine("TotalDistance : {0} -- Weight : {1} -- MaintenanceCost : {2}", item.GetEquipment().DistanceMovedTillDate, item.GetEquipment().Weight, item.GetEquipment().MaintenanceCost);
            }
        }

        private  void RemoveMobileEquipments()
        {
            equipments.RemoveAll(x => x.GetEquipment().TypeofEquipment == EquipementType.Mobile);
        }

        private  void RemoveIMMobileEquipments()
        {
            equipments.RemoveAll(x => x.GetEquipment().TypeofEquipment == EquipementType.ImMobile);
        }

        private  void ListUnMovedEquipments()
        {
            foreach (Equipment item in equipments.Where(x => x.GetEquipment().DistanceMovedTillDate == 0))
            {
                Console.WriteLine("Equipment {0} - {1} - {2}", item.GetEquipment().Name, item.GetEquipment().Description, item.GetEquipment().TypeofEquipment);
                Console.WriteLine("TotalDistance : {0} -- Type : {1} -- MaintenanceCost : {2}", item.GetEquipment().DistanceMovedTillDate, item.GetEquipment().TypeofEquipment, item.GetEquipment().MaintenanceCost);
            }
        }
    }
}
