using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaibhav_assignment.Classes.Exercise5.Interface;
using Vaibhav_assignment.Classes.Exercise5.Model;

namespace Vaibhav_assignment.Classes.Exercise5.Classes
{
    public class RubberDuck : IDuck
    {
        private DuckModel _duckModel = new DuckModel(); 
        public DuckModel GetDuck()
        {
            return new DuckModel() { Id = 1, Name = "DuckName", DuckType = DuckType.RubberDuck, NoOfWings = 1, Weight = 1 };
        }

        public string ShowDetails()
        {
           return "Rubber Ducks don't fly and squeak";
        }
    }

    public class MallardDuck : IDuck
    {
        public DuckModel GetDuck()
        {
            return new DuckModel() { Id = 1, Name = "DuckName", DuckType = DuckType.MallardDuck, NoOfWings = 2, Weight = 2 };
        }

        public string ShowDetails()
        {
            return "Mallard Ducks fly slow and quack loud";
        }
    }

    public class RedHeadDuck : IDuck
    {

        public DuckModel GetDuck()
        {
            return new DuckModel() { Id=1, Name="DuckName",DuckType = DuckType.RedHead, NoOfWings=3,Weight=3 };
        }

        public string ShowDetails()
        {
            return "RedHead Ducks fly fast and quack mild";
        }
    }
}
