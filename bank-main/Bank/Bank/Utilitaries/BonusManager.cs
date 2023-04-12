using Bank.Employees;

namespace Bank.Utilitaries
{
    public class BonusManager
    {
        public double BonusesTotal { get; private set; }

        public void Register(Employe employe)
        {
            this.BonusesTotal += employe.GetBonus();
        }
    }
}