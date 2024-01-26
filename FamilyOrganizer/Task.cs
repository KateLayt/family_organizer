using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.UserDataTasks;

namespace FamilyOrganizer
{
    internal class Task
    {
        public readonly int ID = TaskManager.Count++;
        private string _name;


    }
}
