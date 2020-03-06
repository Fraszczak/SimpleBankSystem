using System.Collections.ObjectModel;

namespace SimpleBankSystem.Models.Database.Core.Domain
{
    public class UserTable
    {
        public UserTable()
        {
            Accounts = new ObservableCollection<Account>();
        }

        public System.Guid Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
        public virtual LoginToTable LoginTo { get; set; }
        
        public virtual ObservableCollection<Account> Accounts {get; set;}
    }
}
