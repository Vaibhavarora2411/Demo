using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaibhav_assignment.Classes.Exercise5.Interface;
using Vaibhav_assignment.Classes.Exercise5.Model;

namespace Vaibhav_assignment.Classes.Exercise5.Classes
{
    public class Duck : IDuck
    {
        public DuckModel _duckModel;
        public Duck(DuckModel duckModel)
        {
            _duckModel = duckModel;
        }

        public string ShowDetails()
        {
            IDuck duck = null;
            switch (_duckModel.DuckType)
            {
                case DuckType.RubberDuck:
                    duck = new RubberDuck();
                    break;
                case DuckType.MallardDuck:
                    duck = new MallardDuck();
                    break;
                case DuckType.RedHead:
                    duck = new RedHeadDuck();
                    break;
                default:
                    break;
            }

            return duck.ShowDetails();
        }

        DuckModel IDuck.GetDuck()
        {
            return _duckModel;
        }
    }
}
