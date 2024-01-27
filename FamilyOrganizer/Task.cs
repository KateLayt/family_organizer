using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyOrganizer
{
    internal class Task
    {
        private static int _count = 0;
        public readonly int ID = _count++;
        private string _name;
        private DateTime _deadline;
        private Person _executor;

        public Task(string name, DateTime deadline, Person executor)
        {
            Name = name;
            Deadline = deadline;
            Executor = executor;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("Название задания не может быть пустым.");
                _name = value;
            }

        }

        public DateTime Deadline
        {
            get { return _deadline; }
            set
            {
                if (Deadline < DateTime.Today) throw new ArgumentOutOfRangeException("Крайний срок не может быть раньше сегодняшнего дня.");
                _deadline = value;
            }
        }

        public Person Executor
        {
            get { return _executor; }
            set
            {
                if (value == null) throw new ArgumentNullException("У задачи должен быть исполнитель.");
                _executor = value;
            }
        }
    }
}
