using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaibhav_assignment.Classes.Exercise5.Classes;
using Vaibhav_assignment.Classes.Exercise5.Model;

namespace Vaibhav_assignment.Classes.Exercise5.Interface
{
    public interface IDuck
    {
        DuckModel GetDuck();
        string ShowDetails();

    }
}
