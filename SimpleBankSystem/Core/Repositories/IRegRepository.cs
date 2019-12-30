using SimpleBankSystem.Core.Domain;

namespace SimpleBankSystem.Core.IRepositories
{
    interface IRegRepository : IRepository<RegTable>
    {
        string GetData(string whatKindOf);
    }
}

//LegalInfo
//Security
//Accesibility