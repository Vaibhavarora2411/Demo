using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaibhav_assignment.Classes.Exercise5.Classes;
using Vaibhav_assignment.Classes.Exercise5.Interface;
using Vaibhav_assignment.Classes.Exercise5.Model;

namespace Vaibhav_assignment.Classes.Exercise5
{

    public class DuckExercise
    {
        private List<IDuck> ducks = new List<IDuck>();
        public DuckExercise()
        {
        }

        public void ExecuteExercise5()
        {
            Console.WriteLine("Adding the Ducks");

            DuckModel duckModel = new DuckModel();
            duckModel.Id = 1;
            duckModel.DuckType = DuckType.RubberDuck;
            duckModel.Weight = 4;
            duckModel.NoOfWings = 1;
            AddDuck(duckModel);
            ShowDuckDetails(duckModel);

            duckModel = new DuckModel();
            duckModel.Id = 2;
            duckModel.DuckType = DuckType.MallardDuck;
            duckModel.Weight = 2;
            duckModel.NoOfWings = 5;
            AddDuck(duckModel);
            ShowDuckDetails(duckModel);

            duckModel = new DuckModel();
            duckModel.Id = 3;
            duckModel.DuckType = DuckType.RedHead;
            duckModel.Weight = 3;
            duckModel.NoOfWings = 2;
            AddDuck(duckModel);
            ShowDuckDetails(duckModel);
        }

        public void ExecuteExercise7()
        {
            //Show all the Ducks Default Iteration
            Console.WriteLine("Show all the Ducks order by default field - Weight");
            foreach (IDuck duck in List())
            {
                Console.WriteLine("Id : {0}, DuckType : {1}, DuckWeight : {2}, DuckWings : {3} ", duck.GetDuck().Id, duck.GetDuck().DuckType, duck.GetDuck().Weight, duck.GetDuck().NoOfWings);
            }

            Console.ForegroundColor = ConsoleColor.White;

            //Show all the Ducks custom Iteration
            Console.WriteLine("Show all the Ducks order by No. of Wings");
            
            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (IDuck duck in ListOrderByNoOfWings())
            {
                Console.WriteLine("Id : {0}, DuckType : {1}, DuckWeight : {2}, DuckWings : {3} ", duck.GetDuck().Id, duck.GetDuck().DuckType, duck.GetDuck().Weight, duck.GetDuck().NoOfWings);
            }
            Console.ForegroundColor = ConsoleColor.Red;

            //Remove a Duck with Id 2
            Console.WriteLine("Remove a duck with id : 2");

            RemoveDuck(2);

            Console.ForegroundColor = ConsoleColor.White;
            //Show all the Ducks Default Iteration
            Console.WriteLine("List All the Ducks");

            foreach (IDuck duck in List())
            {
                Console.WriteLine("Id : {0}, DuckType : {1}, DuckWeight : {2}, DuckWings : {3} ", duck.GetDuck().Id, duck.GetDuck().DuckType, duck.GetDuck().Weight, duck.GetDuck().NoOfWings);
            }
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Remove All the Ducks");

            RemoveAllDucks();

            Console.ForegroundColor = ConsoleColor.Yellow;
            //Show all the Ducks Default Iteration
            Console.WriteLine("List All the Ducks");

            foreach (IDuck duck in List())
            {
                Console.WriteLine("Id : {0}, DuckType : {1}, DuckWeight : {2}, DuckWings : {3} ", duck.GetDuck().Id, duck.GetDuck().DuckType, duck.GetDuck().Weight, duck.GetDuck().NoOfWings);
            }
            Console.ResetColor();

        }

        public void ShowDuckDetails(DuckModel duckModel)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Showing Duck Details");
            IDuck duck = ducks.Find(x=>x.GetDuck().Id== duckModel.Id);
            Console.WriteLine(duck.ShowDetails());
            Console.ResetColor();

        }
        public void AddDuck(DuckModel duckModel)
        {
           IDuck duck = new Duck(duckModel);
            ducks.Add(duck);
            Console.WriteLine("Added the Duck with Id : {0} and DuckType {1}", duck.GetDuck().Id,duck.GetDuck().DuckType);

        }

        public void RemoveDuck(int id)
        {
            IDuck duck = ducks.Where(x => x.GetDuck().Id == id).FirstOrDefault();
            ducks.Remove(duck);
        }

        public void RemoveAllDucks()
        {
            ducks.Clear();
        }

        public IEnumerable<IDuck> List()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return ducks.AsEnumerable().OrderBy(duck=>duck.GetDuck().Weight).ToList();
            
        }

        public IEnumerable<IDuck> ListOrderByNoOfWings()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return ducks.AsEnumerable().OrderBy(duck => duck.GetDuck().NoOfWings);
        }
    }
}
