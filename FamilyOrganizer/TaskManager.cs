using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyOrganizer
{
    internal class TaskManager
    {
        public static int Count = 0;
        private static readonly Dictionary<int, string> _monthNames = new Dictionary<int, string>() {
            { 1, "Января"}, { 2, "Февраля" }, { 3, "Марта"}, { 4, "Апреля" }, { 5, "Мая"}, { 6, "Июня" },
            { 7, "Июля"}, { 8, "Августа" }, { 9, "Сентября"}, { 10, "Октября" }, { 11, "Ноября"}, { 12, "Декабря" }};
    }
}
