using Bank.BankSystem;
using Bank.BankSystem;
using Bank.Utilitaries;

namespace Bank.Employees
{
    public class CEO : Authenticator
    {

        public CEO(string id) : base(id, 100000)
        {

        }
        public override void IncreaseWage()
        {
            this.Salary *= 1.01;
        }
        public override double GetBonus()
        {
            return this.Salary * .35;
        }
        public override bool Authentication(string password, string login)
        {
            return this.Password == password;
        }
    }
}