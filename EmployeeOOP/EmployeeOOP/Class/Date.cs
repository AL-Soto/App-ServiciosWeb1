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
            _year = ValidateYear(year);
            _month = ValidateMounth(month); 
            _day = ValidateDay(day, month, year); 
        }

        private int ValidateDay(int day, int month, int year)
        {
            //Validar si el dia ingresado es de año bisiestro 
            if (month ==2 && day == 29 && IsleapYear(year))
            {
                return day;
            }
            if(month == 2 && day == 29 && IsleapYear(year))
            {
                bool isLeapYear = false;
                IsLeapYearException(isLeapYear, year);
            }

            int[] daysPerMounth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            if (day >= 1 && day <= daysPerMounth[month])
            {
                return day;
            }
            else
            {
                //Exception Creation 
                throw new DayException(String.Format("El Dia {0} no es valido para el mes {1}.", day, month));
            }

        }

        private void IsLeapYearException(bool isLeapYear, int year)
        {
            if (!isLeapYear)
            {
                //Exception Creation 
                throw new YearException(String.Format("El Año {0} no es Bisiestro.", year));
            }

            
        }

        private bool IsleapYear(int year) 
        {
            return (year % 400 == 0 || year % 4 == 0 && year % 100 != 0); 
        }


        private int ValidateYear(int year)
        {
           if (year >= 1900)
            {
                return year;
            }
            else
            {
                //Exception Creation 
                throw new YearException(String.Format("El Año {0} no es valido.", year));
            }
        }

        private int ValidateMounth(int month)
        {
            if(month >=1 && month <= 12)
            {
                return month;
            }
            else
            {
                //Exception Creation 
                throw new MonthException(String.Format("El mes {0} no es valido.", month));
            }
        }

        public override string ToString() 
        {
            //var dateConcatenated1 = _day + "/" + _month + "/" + _year;
            //var dateConcatenated2 = $"{_day:00}/{_month:00}/{_year:0000}"; //Interpolación 
            var dateConcatenated3 = String.Format("{0}/{1}/{2}", _day, _month, _year);

            return dateConcatenated3;
        }

        #endregion
    }
    public class Person { }
}
