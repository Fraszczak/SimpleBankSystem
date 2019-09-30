using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Models
{
    public sealed class AccountTransfersState : INotifyPropertyChanged
    {
        private decimal charge;
        private decimal income;
        private decimal amount;

        public decimal Charge
        {
            get
            {
                return charge;
                
            }
            set
            {
                this.charge = value;
                if (value > 0)
                    Amount -= value;
                else Amount += value;
                OnPropertyChanged("AccountTransferChargeState");            

            }
        }

        public decimal Income
        {
            get
            {
                return income;
            }
            set
            {
                this.income = value;
                if (Income > 0)
                    Amount += value;
                else Amount -= value;
                OnPropertyChanged("AccountTransferIncomeState");
            }
        }
        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                OnPropertyChanged("AccountTransferAmountState");
            }
        }
        

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(string propertyName)
        {
            // Verify that the property name matches a real,
            // public, instance property on this object.
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                string msg = "Invalid property name: " + propertyName;
                Debug.Fail(msg);
            }
        }

        #endregion // INotifyPropertyChanged
    }
}
