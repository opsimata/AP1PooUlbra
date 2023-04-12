using Bank.BankSystem;
using Bank.Utilitaries;

namespace Bank.Employees
{
    public class AccountManager : Authenticator
    {
        public AccountManager(string id) : base(id, 7000)
        {

        }
        public override void IncreaseWage()
        {
            this.Salary *= .1;
        }
        public override double GetBonus()
        {
            return this.Salary * .05;
        }
        public override bool Authentication(string password, string login)
        {
            return this.Password == password;
        }

    }
}