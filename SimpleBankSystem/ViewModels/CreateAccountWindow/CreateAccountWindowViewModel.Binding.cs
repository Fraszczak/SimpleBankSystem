
using System.Collections.Generic;
using System.ComponentModel;
using SimpleBankSystem.Persistance;

namespace SimpleBankSystem.ViewModels
{
    public sealed partial class CreateAccountWindowViewModel : IDataErrorInfo
    {
        private static readonly UnitOfWork unitOfWork = new UnitOfWork(new SBSDatabaseContext());

        private string _createAccountWindowTitle = unitOfWork.Info.GetData("CreateAccountWindowTitle");

        public string CreateAccountWindowTitle
        {
            get => _createAccountWindowTitle;
            set => OnPropertyChanged();
        }


        
        //Think about separate class for below

        private string _forename;
        private string _lastname;
        private string _title;
        private string _phoneNumber = "";
        private string _email;

        public string Forename
        {
            get => _forename;
            set
            {
                _forename = value;
                OnPropertyChanged();
            }
        }

        public string Lastname
        {
            get => _lastname;
            set
            {
                _lastname = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Error => null;

        public string this[string columnName]
        {
            get
            {
                string msg = null;
                switch (columnName)
                {
                    case "Forename":
                    {


                        break;
                    }
                    case "Lastname":
                    {


                        break;
                    }
                    case "Title":
                    {


                        break;
                    }
                    case "PhoneNumber":
                    {
                        foreach (var single in ValidationHelper.listOfLetter)
                        {
                            if (PhoneNumber.Contains(single.ToString()) || PhoneNumber.Length.Equals(0) || PhoneNumber.Length == 0)
                            {
                                msg = "Invalid phone number";
                            }
                        }

                        break;
                    }
                    case "Email":
                    {


                        break;
                    }
                }

                return msg;
            }
        }

       
        
    }
    public static class ValidationHelper
    {
       public static List<char> listOfLetter = new List<char>()
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'r', 's', 't', 'q', 'u', 'w', 'x', 'y',
            'z'
        };

        static List<char> listOfChar = new List<char>()
        {
            ',', '.', '?', ';', ':', '\'', '\\', '[', ']', '{', '}',
            '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-',
            '+', '~', '|', '/', '?', '1', '2', '3', '4', '5', '6', '7',
            '8', '9', '0'
        };

    }
}



//foreach

//(var single in listOfChar)
//{
//if (userTable.FirstName.Contains(single) || userTable.FirstName.Length.Equals(0)
//|| userTable.LastName.Contains(single) ||
//userTable.LastName.Length.Equals(0)
//|| userTable.Title.Contains(single) ||
//userTable.Title.Length.Equals(0))
//{
//    return false;
//}
//}

////Przyda sie jeszcze sprawdzanie zdublowanych loginow
//foreach (var single in listOfLetter)
//{
//if (userTable.PhoneNumber.Contains(single) || userTable.PhoneNumber.Length.Equals(0)
//|| userTable.Login.Length.Equals(0))
//{
//    return false;
//}
//}