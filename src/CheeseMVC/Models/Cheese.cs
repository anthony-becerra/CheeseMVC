using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CheeseId { get; set; } // Make each object unique with their own ID
        private static int nextId = 1;

        // Default constructor
        public Cheese() {
            CheeseId = nextId;
            nextId++;
        }
    }
}
