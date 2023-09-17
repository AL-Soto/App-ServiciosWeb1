using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Class
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public decimal commisionPercentaje { get; set; }
        public int sales { get; set; }
        #endregion

        #region Methods
        public CommissionEmployee()
        {

        }
        public override decimal GetValueToPay()
        {
            return commisionPercentaje * sales;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Porcentaje de comision: {commisionPercentaje}" +
                $"Numero de ventas: {sales}"
                ;
        }
        #endregion
    }
}
