using SimpleBankSystem.Models.Database.Core.Domain;

namespace SimpleBankSystem.Core.IRepositories
{
    public interface IInfoRepository : IRepository<InfoTable>
    {
        string GetData(string whatKindOf);
    }
}

//LegalInfo
//Security
//Accesibility