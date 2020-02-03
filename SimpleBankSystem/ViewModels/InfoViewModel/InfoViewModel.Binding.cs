using SimpleBankSystem.Persistance;
using SimpleBankSystem.Persistance.Repository;
namespace SimpleBankSystem.ViewModels
{
    public sealed partial class InfoViewModel
    {
        private string accesibilityWindowTitle = "SimpleBankSystem - Info";
        private string _accessibility = new InfoRepository(new PlutoContext()).GetData("Accessibility");
        private string _seciurity = new InfoRepository(new PlutoContext()).GetData("Seciurity");
        private string _legalInfo = new InfoRepository(new PlutoContext()).GetData("Legal Info");


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
