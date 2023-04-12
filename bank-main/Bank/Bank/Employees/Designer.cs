using Bank.Employees;
using Bank.Utilitaries;

namespace Bank.Employees
{
    public class Designer : Employe
    {

        public Designer(string id) : base(id, 6000)
        {

        }

        public override void IncreaseWage()
        {
            this.Salary *= .4;
        }
        public override double GetBonus()
        {
            return this.Salary * .17;
        }
    }
}