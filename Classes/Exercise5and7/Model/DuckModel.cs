using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaibhav_assignment.Classes.Exercise5.Classes;

namespace Vaibhav_assignment.Classes.Exercise5.Model
{
    public class DuckModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DuckType DuckType { get; set; }
        public int Weight { get; set; }
        public int NoOfWings { get; set; }
    }
}
