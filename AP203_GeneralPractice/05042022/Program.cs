using System;

namespace _05042022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group(GroupType.Programming)
            {
                Limit = 15
            };
            Group group2 = new Group(GroupType.Programming)
            {
                Limit = 10
            };
            Group group3 = new Group(GroupType.Design)
            {
                Limit = 8
            };
            Group group4 = new Group(GroupType.System)
            {
                Limit = 2
            };

            group1.ShowInfo();
            group2.ShowInfo();
            group3.ShowInfo();
            group4.ShowInfo();
        }
    }
}
