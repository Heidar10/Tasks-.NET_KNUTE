using System;

namespace Task_2
{
    class DateClass
    {
        DateTime date;

        public DateClass()
        {
            date = new DateTime(2009, 1, 1);
        }

        public DateClass(DateTime date)
        {
            this.date = date;
        }

        public DateTime PrevDay()
        {
            return date.Subtract(TimeSpan.FromDays(1));
        }

        public DateTime NextDay()
        {
            return date.Add(TimeSpan.FromDays(1));
        }

        public int DaysLeft()
        {
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public bool IsLeap
        {
            get { return DateTime.IsLeapYear(date.Year); }
        }
        
        public static bool operator !(DateClass a)
        {
            return DateTime.DaysInMonth(a.Date.Year, a.Date.Month) != a.Date.Day;
        }

        public static bool operator true(DateClass a)
        {
            return a.Date.Month == 1;
        }

        public static bool operator false(DateClass a)
        {
            return a.date.Month != 1;
        }

        public static bool operator &(DateClass a, DateClass b)
        {
            return a.Date.Equals(b.Date);
        }

        public override string ToString()
        {
            return date.ToString();
        }
    }
}
