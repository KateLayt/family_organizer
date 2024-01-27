using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyOrganizer
{
    internal class DateConverter
    {
        private static readonly Dictionary<int, string> MonthNames = new Dictionary<int, string>() {
            { 1, "Января"}, { 2, "Февраля" }, { 3, "Марта"}, { 4, "Апреля" }, { 5, "Мая"}, { 6, "Июня" },
            { 7, "Июля"}, { 8, "Августа" }, { 9, "Сентября"}, { 10, "Октября" }, { 11, "Ноября"}, { 12, "Декабря" }};

        public static string RepresentDate(DateTime date)
        {

            return date.Day.ToString() + " " + MonthNames[date.Month];
        }

        public static string RepresentDifference(DateTime date1, DateTime date2)
        {
            int difference = (date1 < date2) ? date2.Subtract(date1).Days : date1.Subtract(date2).Days;
            string result = difference.ToString();
            if (difference % 10 == 1)
            {
                result += " день";
            }
            else if (new[] { 2, 3, 4 }.Contains(difference % 10))
            {
                result += " дня";
            }
            else
            {
                result += " дней";
            }
            return result;
        }
    }
}
