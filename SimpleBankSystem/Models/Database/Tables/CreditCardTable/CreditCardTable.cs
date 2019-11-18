namespace SimpleBankSystem.Models
{
    public class CreditCardTable
    {
      
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal? Ballance { get; set; }

        public CurrentAccountTable CurrentAccount { get; set; }
        public int? CurentAccountID { get; set; }


    }

}

