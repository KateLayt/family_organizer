using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyOrganizer
{
    internal class RepeatableTask : Task
    {
        private string _status;
        private int _interval;
        private DateTime _lastDone;
        public RepeatableTask(string name, DateTime deadline, Person executor, string status)
            : base(name, deadline, executor)
        {
            Status = status;
            _lastDone = deadline.Subtract(TimeSpan.FromDays(_interval));
        }

        public string Status
        {
            get { return _status; }
            private set { _status = value; }
        }

        public int Interval
        { 
            get { return _interval; } 
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException("Промежуток между повторами не может быть меньше одного дня.");
                _interval = value;
            }
        }

        public DateTime LastDone
        {
            get { return _lastDone; }
            private set
            {
                _lastDone = value;
            }
        }

        public void UpdateTask()
        {
            if (DateTime.Now >= Deadline)
            {
                Status = "За работу!";
                return;
            }

            long overallTicks = Deadline.Subtract(LastDone).Ticks;
            long currentTicks = Deadline.Subtract(DateTime.Now).Ticks;

            if (currentTicks < overallTicks / 3)
            {
                Status = "Всё хорошо";
            }

            else if (currentTicks > overallTicks / 3 && currentTicks < overallTicks*2 / 3)
            {
                Status = "Нормально";
            }

            else
            {
                Status = "За работу!";
            }

        }

        public void Complete()
        {
            LastDone = DateTime.Now;
            Deadline = DateTime.Now.Add(TimeSpan.FromDays(Interval));
            this.UpdateTask();
        }

    }
}
