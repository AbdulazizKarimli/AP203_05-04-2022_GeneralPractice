﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _05042022
{
    internal class Room
    {
        private static int _id;

        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }

        public Room(string name, double price, int personCapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }

        public string ShowInfo()
        {
            return $"Id: {Id} - Name: {Name} - Price: {Price} - IsAvailable: {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
