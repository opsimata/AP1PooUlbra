using Bank.Employees;
using Bank.Utilitaries;
using Bank.BankSystem;
using Bank.Client;
using Bank.Accounts;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implementação dos funcionarios do banco
            #region
            CalcBonus();

            void CalcBonus()
            {
                General.Linebreak();
                General.Print("--------------------------------------------------");
                General.Linebreak();
                General.Print("Bank Employees Data: ");
                General.Linebreak();

                BonusManager manager = new BonusManager();

                CEO director = new CEO("617.549.456-47");
                director.Name = "Scrooge McDuck";

                General.Print("CEO Name: " + director.Name);
                General.Print("CEO Salary: " + director.Salary);
                General.Print("CEO Salary Bonus: " + director.GetBonus());
                General.Linebreak();

                Designer designer01 = new Designer("132.149.167-81");
                designer01.Name = "Huey Duck";

                General.Print("Designer Name: " + designer01.Name);
                General.Print("Designer Salary: " + designer01.Salary);
                General.Print("Designer Salary Bonus: " + designer01.GetBonus());
                General.Linebreak();

                Assistant assistant01 = new Assistant("973.168.741-21");
                assistant01.Name = "Dewey Duck";

                General.Print("Assistant Name: " + assistant01.Name);
                General.Print("Assistant Salary: " + assistant01.Salary);
                General.Print("Assistant Salary Bonus: " + assistant01.GetBonus());
                General.Linebreak();

                AccountManager accountManager01 = new AccountManager("348.974.358-69");
                accountManager01.Name = "Louie Duck";

                General.Print("Account Manager Name: " + accountManager01.Name);
                General.Print("Account Manager Salary: " + accountManager01.Salary);
                General.Print("Account Manager Salary Bonus: " + accountManager01.GetBonus());
                General.Linebreak();

                manager.Register(director);
                manager.Register(designer01);
                manager.Register(assistant01);
                manager.Register(accountManager01);

                General.Linebreak();

                General.Print("Total of all employees bonuses: $" + manager.BonusesTotal);

                General.Linebreak();

                General.Print("--------------------------------------------------");

                General.Linebreak();
            }

            #endregion

            //Validação do login dos funcionarios do CEO e do Gerente de Contas
            #region
            UseLoginSystem();

            void UseLoginSystem()
            {
                General.Print("Login Validation for the CEO and the Accounts Manager: ");
                General.Linebreak();
                LoginSystem system = new LoginSystem();

                CEO director02 = new CEO("074.801.374-16");
                director02.Name = "Launchpad McQuack";
                director02.Password = "123";
                director02.Login = "McQuack";

                AccountManager accountManager02 = new AccountManager("219.412.635-25");
                accountManager02.Name = "Donald Duck";
                accountManager02.Password = "321";
                accountManager02.Login = "Donald";

                system.Login(director02, "123", "McQuack");
                General.Linebreak();
                system.Login(accountManager02, "674", "Donald");
                General.Linebreak();

                General.Print("--------------------------------------------------");
                General.Linebreak();
            }
            #endregion

            //Criação dos clientes e de suas contas
            #region

            Account account01 = new Account(283, "1234-5");
            account01.AccountHolder = new AccountHolder();
            account01.AccountHolder.Name = "Person 01";
            account01.AccountHolder.Profession = "Developer";
            account01.AccountHolder.ID = "341.467.219-71";

            Account account02 = new Account(236, "2794-0");
            account02.AccountHolder = new AccountHolder();
            account02.AccountHolder.Name = "Person 02";
            account02.AccountHolder.Profession = "Teacher";
            account02.AccountHolder.ID = "123.456.789-94";

            Account account03 = new Account(283, "6734-4");
            account03.AccountHolder = new AccountHolder();
            account03.AccountHolder.Name = "Person 03";
            account03.AccountHolder.Profession = "Artist";
            account03.AccountHolder.ID = "032.709.149-34";

            #endregion

            //Exemplo de oprerações nas contas
            General.Print("Operations examples: ");
            General.Linebreak();

            //Exemplo de saque
            #region
            General.Print("Withdraw of $200 example on Account 01:");
            General.Print("Account 01 balance before the withdraw: $" + account01.GetBalance());
            account01.Withdraw(200);
            General.Print("Account 01 balance after the withdraw: $" + account01.GetBalance());

            General.Linebreak();
            General.Linebreak();
            #endregion

            //Exemplo de deposito
            #region
            General.Print("Deposit of $10000 example on Account 01:");
            General.Print("Account 01 balance before the deposit: $" + account01.GetBalance());
            account01.Deposit(10000);
            General.Print("Account 01 balance after the deposit: $" + account01.GetBalance());

            General.Linebreak();
            General.Linebreak();
            #endregion

            //Exemplo transferencia:
            #region
            General.Print("Example of a $2000 transfer from Account 02 to Account 01:");
            General.Print("Account 02 balance before the transfer: $" + account02.GetBalance());
            General.Print("Account 01 balance before the transfer: $" + account01.GetBalance());
            account02.Transfer(2000, account01);
            General.Linebreak();
            General.Print("Account 02 balance after the transfer: $" + account02.GetBalance());
            General.Print("Account 01 balance after the transfer: $" + account01.GetBalance());
            General.Linebreak();
            General.Print("--------------------------------------------------");
            General.Linebreak();
            #endregion

            //Mostra informações das contas + clientes.
            #region
            General.Print("Clients Data + Account Data: ");

            General.Linebreak();
            account01.PrintData();

            General.Linebreak();
            account02.PrintData();

            General.Linebreak();
            account03.PrintData();

            General.Linebreak();
            General.Print("--------------------------------------------------");
            General.Linebreak();
            #endregion

            //Mostra o número total de contas criadas
            #region
            General.Print("Total of registered accounts: " + Account.TotalAccounts);

            General.Linebreak();
            General.Print("--------------------------------------------------");
            General.Linebreak();

            #endregion

            Console.Write("Press any key to close...");
            Console.ReadLine();
        }
    }
}