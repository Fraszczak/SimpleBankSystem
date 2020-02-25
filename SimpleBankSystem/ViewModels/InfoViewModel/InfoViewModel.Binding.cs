using SimpleBankSystem.Persistance;
using SimpleBankSystem.Persistance.Repository;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class InfoViewModel
    {
        private string accesibilityWindowTitle = "SimpleBankSystem - Info";

        private static UnitOfWork unitOfWork = new UnitOfWork(new PlutoContext());
        private string _accessibility = unitOfWork.Info.GetData("Accessibility");
        private string _seciurity = unitOfWork.Info.GetData("Seciurity");
        private string _legalInfo = unitOfWork.Info.GetData("Legal Info");

        

        public string AccesibilityWindowTitle
        {
            get
            {
                return this.accesibilityWindowTitle;
            }
            set
            {
                this.accesibilityWindowTitle = value;
                this.OnPropertyChanged();
            }
        }
        
        public string Accessibility
        {
            get
            {
                return this._accessibility;
            }
            set
            {
                this._accessibility = value;
                unitOfWork.Complete();
                this.OnPropertyChanged();
            }
        }
        
        public string Seciurity
        {
            get
            {
                return this._seciurity;
            }
            set
            {
                this._seciurity = value;
                this.OnPropertyChanged();
            }
        }
        
        public string LegalInfo
        {
            get
            {
                return this._legalInfo;
            }
            set
            {
                this._legalInfo = value;
                this.OnPropertyChanged();
            }
        }

    }
}
