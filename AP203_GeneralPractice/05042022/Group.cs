using System;
using System.Collections.Generic;
using System.Text;

namespace _05042022
{
    internal class Group
    {
        private static int _noP = 1000;
        private static int _noD = 1000;
        private static int _noS = 1000;

        public string No { get; set; }
        public GroupType GroupType { get; set; }
        public int Limit { get; set; }

        public Group(GroupType groupType)
        {
            GroupType = groupType;
            switch (groupType)
            {
                case GroupType.Programming:
                    _noP++;
                    No = groupType.ToString().Substring(0,2).ToUpper() + _noP;
                    break;
                case GroupType.Design:
                    _noD++;
                    No = groupType.ToString().Substring(0,2).ToUpper() + _noD;
                    break;
                case GroupType.System:
                    _noS++;
                    No = groupType.ToString().Substring(0,2).ToUpper() + _noS;
                    break;
                default:
                    break;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"No: {No} - Limit: {Limit}");
        }
    }
}
