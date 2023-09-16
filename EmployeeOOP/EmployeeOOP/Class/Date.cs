using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Class
{
    public class Date
    {
        #region Fields 

        private int _year;
        private int _month;
        private int _day;

        #endregion
        #region Methods 

        public Date(int day, int month, int year)
        {
            _year = year;
            _month = month; 
            _day = day; 
        }

        public override string ToString() 
        {
            //var dateConcatenated1 = _day + "/" + _month + "/" + _year;
            //var dateConcatenated2 = $"{_day}/{_month}/{_year}"; //Interpolación 
            var dateConcatenated3 = String.Format("{0}/{1}/{2}", _day, _month, _year);

            return dateConcatenated3;
        }

        #endregion
    }
    public class Person { }
}
