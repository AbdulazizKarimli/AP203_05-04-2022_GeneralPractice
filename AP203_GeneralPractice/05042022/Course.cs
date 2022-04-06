using System;
using System.Collections.Generic;
using System.Text;

namespace _05042022
{
    internal class Course
    {
        private List<Group> _groups;

        public Course()
        {
            _groups = new List<Group>();
        }

        public void AddGroup(Group group)
        {
            _groups.Add(group);
        }
        public void RemoveGroupByNo(string no)
        {
            if (string.IsNullOrWhiteSpace(no))
                throw new Exception("xeta");

            var group = _groups.Find(x => x.No == no);
            if (group == null)
                throw new Exception("bele bir qrup yoxdur");

            _groups.Remove(group);
        }
        public List<Group> GetGroupsByType(GroupType groupType)
        {
            return _groups.FindAll(g => g.GroupType == groupType);
        }
        public List<Group> FilterGroupsByLimit(int minLimit, int maxLimit)
        {
            return _groups.FindAll(g => g.Limit >= minLimit && g.Limit <= maxLimit);
        }
        public List<Group> GetAllGroups()
        {
            List<Group> groupsCopy = new List<Group>();
            groupsCopy.AddRange(_groups);

            return groupsCopy;
        }
    }
}
