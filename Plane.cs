using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneApp
{
    // Task - create a basic plane class using different types of properties

    public enum PlaneType { Turboprop, Piston, Jet }
    class Plane
    {
        // properties list
        public string Model { get; set; }
        public PlaneType Type { get; set; }
        public int CurrentCapacity { get; set; }
        public int MaxCapacity { get; set; }

        // static field
        private static int count = 0;

        // readonly properties
        public readonly int id;
        public readonly DateTime DateOfSetOff;
        public readonly DateTime DateOfArrival;


        // default and parameterized constructors
        public Plane() { }
        public Plane (string m, PlaneType t, int currentC, int maxC)
        {
            id = count;
            Model = m;
            Type = t;
            CurrentCapacity = currentC;
            MaxCapacity = maxC;

            DateOfSetOff = DateTime.Today;
            DateOfArrival = DateTime.Now;
        }

        // methods
        public void ShowInfo()
        {
            Console.WriteLine("- - - - - - - Plane Information - - - - - - -");
            Console.WriteLine($"Plane # {id}");
            Console.WriteLine($"Model name: {Model}");
            Console.WriteLine($"Type of the plane [{Type}]");
            Console.WriteLine($"Current capacity is: {CurrentCapacity}");
            Console.WriteLine($"Maximum capacity is: {MaxCapacity}");
            Console.WriteLine($"Date of set off - {DateOfSetOff}");
            Console.WriteLine($"Arrival date - {DateOfArrival}");
        }
        public void AddASeat()
        {
            if (CurrentCapacity < MaxCapacity)
            {
                CurrentCapacity++;
                Console.WriteLine($"You've added the seat!");
            }
            else
            { 
                CurrentCapacity = MaxCapacity;
                Console.WriteLine($"The amount of seats has already reached the MAX amount!");
            }

        }
        public void RemoveASeat()
        {
            if (CurrentCapacity > 0)
            {
                CurrentCapacity--;
                Console.WriteLine($"You've removed the seat!");
            }
            else
            { 
                CurrentCapacity = 0;
                Console.WriteLine($"There's no place to sit left!");
            }
        }
        public void ChangeMaxCapacity(int value)
        {
            MaxCapacity = value;
            Console.WriteLine($"Your new MAX capacity is: {MaxCapacity}.");
        }
    }
}
