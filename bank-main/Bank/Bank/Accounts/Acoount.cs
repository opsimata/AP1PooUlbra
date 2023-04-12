using Bank.Client;
using Bank.Utilitaries;

namespace Bank.Accounts
{
    public class Account
    {
        public static int TotalAccounts { get; private set; }

        public int agencyNumber;
        public int AgencyNumber
        {
            get { return this.agencyNumber; }
            private set
            {
                if (value > 0)
                {
                    this.agencyNumber = value;
                }
            }
        }
        public string AccountNumber { get; set; }
        public AccountHolder AccountHolder { get; set; }

        private double AccountBalance;
        public void Deposit(double value)
        {
            this.AccountBalance += value;
        }

        public void PrintClientData()
        {
            General.Print("Client: " + AccountHolder.Name);
            General.Print("Client ID: " + AccountHolder.ID);
            General.Print("Client profession: " + AccountHolder.Profession);
            General.Print("Account number: " + AccountNumber);
            General.Print("Agency number: " + agencyNumber);
            General.Print("Balance: $" + this.AccountBalance);
        }

        public bool Withdraw(double value)
        {
            if (value <= this.AccountBalance)
            {
                this.AccountBalance -= value;
                return true;
            }
            else
            {
                Console.WriteLine("\nInvalid operation!\nNo sufficient founds!\n");
                return false;
            }
        }
        public bool Transfer(double value, Account receiver)
        {
            if (this.AccountBalance < value)
            {
                Console.WriteLine("\nInvalid operation!\nNo sufficient founds!\n");
                return false;
            }
            else
            {
                Withdraw(value);
                receiver.Deposit(value);
                return true;
            }
        }

        public void SetBalance(double value)
        {
            if (value < 0)
            {
                return;
            }
            else
            {
                this.AccountBalance = value;
            }
        }

        public double GetBalance()
        {
            return this.AccountBalance;
        }

        public Account(int agencyNumber, string accountNumber, string accountHolder, double accountBalance, string accountHolderName, string accountHolderID, string accountHolderProfession)
        {
            this.AccountHolder.Name = accountHolderName;
            this.AccountHolder.ID = accountHolderID;
            this.AccountHolder.Profession = accountHolderProfession;
            this.AgencyNumber = agencyNumber;
            this.AccountNumber = accountNumber;
            this.AccountBalance = accountBalance;

            TotalAccounts++;
        }
    }
}