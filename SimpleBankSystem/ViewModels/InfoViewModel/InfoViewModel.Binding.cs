using SimpleBankSystem.Persistance;
using SimpleBankSystem.Persistance.Repository;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class InfoViewModel
    {
        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());

        private string _accessibilityWindowTitle = unitOfWork.Info.GetData("InfoWindowTitle");
        public string AccesibilityWindowTitle
        {
            get => _accessibilityWindowTitle;
            set => OnPropertyChanged();
        }
        private string _accessybilityDescryption = unitOfWork.Info.GetData("Accessibility");
        public string Accessibility
        {
            get => _accessybilityDescryption;
            set => OnPropertyChanged();
        }
        private string _seciurityDescryption =  unitOfWork.Info.GetData("Seciurity");
        public string Seciurity
        {
            get => _seciurityDescryption;
            set => OnPropertyChanged();
        } 
        private string _legalInfoDescryption = unitOfWork.Info.GetData("Legal Info");
        public string LegalInfo
        {
            get => _legalInfoDescryption;
            set => OnPropertyChanged();
        } 
    }
}
