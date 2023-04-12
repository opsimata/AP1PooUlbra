using Bank.Employees;

namespace Bank.BankSystem
{
    public abstract class Authenticator : Employe
    {
        public Authenticator(string id, double salary) : base(id, salary)
        {

        }
        public string Password { get; set; }
        public string Login { get; set; }
        public virtual bool Authentication(string password, string login)
        {
            if (this.Password == password && this.Login == login)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
