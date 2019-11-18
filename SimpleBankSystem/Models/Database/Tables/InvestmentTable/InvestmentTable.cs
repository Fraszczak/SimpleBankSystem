namespace SimpleBankSystem.Models
{
    public class InvestmentTable
    {
  
        public int ID { get; set; }
        public string Name { get; set; }

        public CurrenciesTable Currencies { get; set; }
        // rozbuduj
    }
}

