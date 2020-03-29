using System.Linq;
using System.Xml.Linq;
using SimpleBankSystem.Persistance;
using SimpleBankSystem.Persistance.Repository;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class InfoViewModel
    {
        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());

        private string _infoWindowTitle = unitOfWork.Info.GetData("InfoWindowTitle");
        public string InfoWindowTitle
        {
            get => _infoWindowTitle;
            set => OnPropertyChanged("InfoWindowTitle");
        }
        private string _accessybilityDescryption = unitOfWork.Info.GetData("Accessibility");
        public string Accessibility
        {
            get => _accessybilityDescryption;
            set => OnPropertyChanged("Accessibility");
        }
        private string _seciurityDescryption =  unitOfWork.Info.GetData("Security");
        public string Seciurity
        {
            get => _seciurityDescryption;
            set => OnPropertyChanged("Security");
        } 
        private string _legalInfoDescryption = unitOfWork.Info.GetData("Legal Info");
        public string LegalInfo
        {
            get => _legalInfoDescryption;
            set => OnPropertyChanged("LegalInfo");
        }
    }
}
