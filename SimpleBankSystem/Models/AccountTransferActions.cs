//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;

//namespace SimpleBankSystem.Models
//{
//    public sealed class AccountTransferActions : IAccountTransferActions
//    {
//        private object padLock;
//        private AccountTransferActions instance;

//        private decimal currentTotalAmount = DataBase.Instance.DecimalExecuteQuery("SELECT SUM(SpendPrices) FROM CurrentAccountSpendsTable");
//        private decimal saveTotalAmount = DataBase.Instance.DecimalExecuteQuery("SELECT SUM(SpendPrices) FROM SavingAccountTable");
//        private decimal creditTotalAmount = DataBase.Instance.DecimalExecuteQuery("SELECT SUM(SpendPrices) FROM CreditCardAccountSpendsTable");

//        public AccountTransferActions Instance
//        {
//            get
//            {
//                lock (padLock)
//                {
//                    if (instance == null)
//                        instance = new AccountTransferActions();

//                    return instance;
//                }
//            }
//        }

//        public decimal TransferCashFromLocalAccountToLocalAccount(ref decimal from, ref decimal secondtoAcc)
//        {
//            try
//            {

//                if (from < 0)
//                {
//                    throw new NotFiniteNumberException();
//                }
//                else if (from > currentTotalAmount)
//                {

//                }

//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//        }
//    }
//}
