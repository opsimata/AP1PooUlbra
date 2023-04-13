using Bank.Client;

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

        private double AccountBalance = 5000;

        public void PrintData()
        {
            Console.WriteLine("Client: " + AccountHolder.Name);
            Console.WriteLine("Client ID: " + AccountHolder.ID);
            Console.WriteLine("Client profession: " + AccountHolder.Profession);
            Console.WriteLine("Account number: " + AccountNumber);
            Console.WriteLine("Agency number: " + agencyNumber);
            Console.WriteLine("Balance: $" + this.AccountBalance);
        }
        public void Deposit(double value)
        {
            this.AccountBalance += value;
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

        public Account(int agencyNumber, string accountNumber)
        {
            this.AgencyNumber = agencyNumber;
            this.AccountNumber = accountNumber;

            TotalAccounts++;
        }
    }
}