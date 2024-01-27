using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyOrganizer
{
    internal class OneTimeTask : Task
    {
        private bool _isDone;
        public OneTimeTask(string name, DateTime deadline, Person executor)
            :base(name, deadline, executor)
        {
            _isDone = false;
        }

        public void Finish() { _isDone = true; }

        public void Restart() { _isDone = false; }

        public string GetStatus()
        {
            if (_isDone) return "Завершено";
            else return "Не завершено";
        }
    }
}
