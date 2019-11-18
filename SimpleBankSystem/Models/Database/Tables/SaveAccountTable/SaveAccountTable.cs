namespace SimpleBankSystem.Models
{
    public class SaveAccountTable
    {
     
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal? Ballance { get; set; }

        public int? CurrentAccountID { get; set; }
        public CurrentAccountTable CurrentAccount { get; set; }
    
       
    }
}

