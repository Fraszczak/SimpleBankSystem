using SimpleBankSystem.Core.Domain;

namespace SimpleBankSystem.Core.IRepositories
{
    interface IInfoRepository : IRepository<InfoTable>
    {
        string GetData(string whatKindOf);
    }
}

//LegalInfo
//Security
//Accesibility