namespace SimpleBankSystem.Core.Domain
{
    public class InvestmentTable
    {
  
        public System.Guid ID { get; set; }
        public string Name { get; set; }

        //Waluta inwestycji klucz obcy
        public virtual CurrenciesTable Currencies { get; set; }
        // rozbuduj
    }
}

