using Bank.Employees;
using Bank.Utilitaries;

namespace Bank.Employees
{
    public class Assistant : Employe
    {
        public Assistant(string id) : base(id, 2000)
        {

        }
        public override void IncreaseWage()
        {
            this.Salary *= 1.1;
        }
        public override double GetBonus()
        {
            return this.Salary * .2;
        }
    }
}