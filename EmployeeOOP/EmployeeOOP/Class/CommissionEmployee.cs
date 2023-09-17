namespace EmployeeOOP.Class
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public decimal commisionPercentaje { get; set; }
        public decimal sales { get; set; }
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
                $"Valor de ventas: {sales}"
                ;
        }
        #endregion
    }
}
