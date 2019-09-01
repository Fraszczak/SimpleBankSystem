
namespace SimpleBankSystem.ViewModels.LoginWindow
{
    public sealed partial class LegalInfoWindow
    {
        private string legaliInfoWindowTitle = "SimpleBankSystem - Legal Info";
        public string LegaliInfoWindowTitle
        {
            get
            {
                return this.legaliInfoWindowTitle;
            }
            set
            {
                this.legaliInfoWindowTitle = value;
                this.OnPropertyChanged();
            }
        }

    }
}
