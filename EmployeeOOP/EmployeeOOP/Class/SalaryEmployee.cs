namespace EmployeeOOP.Class
{
    public class SalaryEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; }

        #endregion

        #region Methods

        public SalaryEmployee()
        {
            
        }

        #endregion
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario Devengado: {Salary:C2}\n\t";
        }
    }
}
