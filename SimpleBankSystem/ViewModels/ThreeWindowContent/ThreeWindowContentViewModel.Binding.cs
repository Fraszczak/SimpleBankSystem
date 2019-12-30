using SimpleBankSystem.Persistance;
using SimpleBankSystem.Persistance.Repository;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class ThreeWindowContentViewModel
    {
        private string _firstFromDataBase = "Accessibility";
        public string FirstFromDataBase
        {
            get
            {
                return _firstFromDataBase;
            }
            set
            {
                _firstFromDataBase = value;
                OnPropertyChanged();
            }
        }


        private string accesibilityWindowTitle = "SimpleBankSystem - Accesibility Info";
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
        
        private string _accessibility = new RegRepository(new PlutoContext()).GetData("Accessibility");
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



    }
}
