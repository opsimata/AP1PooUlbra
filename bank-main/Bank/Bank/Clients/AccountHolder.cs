namespace Bank.Client
{
    public class AccountHolder
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Profession { get; set; }
        public static int TotalClients { get; set; }

        public AccountHolder()
        {
            TotalClients++;
        }
    }
}
