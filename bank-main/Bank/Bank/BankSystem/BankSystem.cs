using Bank.BankSystem;
using Bank.Utilitaries;
using Bank.Employees;
using Bank.Utilitaries;

namespace Bank.BankSystem
{
    public class LoginSystem
    {
        public bool Login(Authenticator employe, string password, string login)
        {
            bool authenticatedUser = employe.Authentication(password, login);

            if (authenticatedUser == true)
            {
                General.Print("User: " + employe.Name + "\nLogin Authorized! Welcome!");
                return true;
            }
            else
            {
                General.Print("User: " + employe.Name + "\nLogin Unauthorized! Wrong Credentials!");
                return false;
            }
        }
    }
}
