using System.ComponentModel.DataAnnotations;

namespace SimpleBankSystem.Models.Database.Core.Domain
{

    public class LoginToTable
    {
        public System.Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        
        public virtual UserTable UserTable { get; set; }

    }
}

