namespace EmployeeOOP.Class
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public int hours { get; set; }
        public decimal hoursValue { get; set; }


        #endregion

        #region Methods 

        public HourlyEmployee()
        {

        }
        public override decimal GetValueToPay()
        {
            return hoursValue * hours;
        }


        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Horas: {hours}" +
                $"Valor por Hora: {hoursValue}"
                ;
        }

        #endregion

    }
}
