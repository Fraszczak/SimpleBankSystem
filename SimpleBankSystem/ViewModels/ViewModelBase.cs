using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace SimpleBankSystem.ViewModels
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows.Controls;

    public abstract class ViewModelBase : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                Validate();
            }
        }
       
        #endregion
        #region INotifyDataErrorInfo
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public void OnPropertyErrorsChanged(string propertyName)
        {

            EventHandler<DataErrorsChangedEventArgs> handler = ErrorsChanged;
            if (handler == null) return;

            var arg = new DataErrorsChangedEventArgs(propertyName);
            handler.Invoke(this, arg);
            
        }

        public IEnumerable GetErrors(string propertyName)
        {
            List<string> errors = new List<string>();
            
            if (propertyName != null)
            {
                _errors.TryGetValue(propertyName, out errors);
                return errors;
            }

            return null;
        }

        public bool HasErrors
        {
            get
            {
                try
                {
                    var _errorsCount = _errors.Values.FirstOrDefault(list => list.Count > 0);
                    if (_errorsCount != null)
                        return true;

                    return false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return true;
                }
            }
        }
        #endregion

        #region DataInputValidation
        private Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();
        private object _lock = new object();

        private void Validate()
        {
            double WaitSecondsBeforeValidation = 1;
            Task waitTask = new Task(() => Thread.Sleep(
                TimeSpan.FromSeconds(WaitSecondsBeforeValidation)));
            waitTask.ContinueWith((_) => RealValidation());
            waitTask.Start();
        }

        private void RealValidation()
        {
            lock (_lock)
            {
                List<string> errorList;

                //Validate Forename

                if (!_errors.TryGetValue("Forename", out errorList))
                    errorList = new List<string>();
                else errorList.Clear();

                if (string.IsNullOrEmpty(Forename))
                    errorList.Add("The name can't be null or empty.");
                else if (Forename.Length > 50 || Forename.Length < 2)
                    errorList.Add("The Forename must be between 2 and 50 characters long");
                else if (!Regex.IsMatch(Forename, @"^[a-zA-Z]+$"))
                    errorList.Add("The Forename must only contain letters (a-z A-Z).");

                _errors["Forename"] = errorList;
                if (errorList.Count > 0) OnPropertyErrorsChanged("Forename");


                //Validate Lastname

                if (!_errors.TryGetValue("Lastname", out errorList))
                    errorList = new List<string>();
                else errorList.Clear();

                if (string.IsNullOrEmpty(Lastname))
                    errorList.Add("The Lastname can't be null or empty.");
                else if (Lastname.Length > 50 || Lastname.Length < 2)
                    errorList.Add("The Lastname must be between 2 and 50 characters long");
                else if (!Regex.IsMatch(Forename, @"^[a-zA-Z]+$"))
                    errorList.Add("The Lastname must only contain letters (a-z A-Z).");

                _errors["Lastname"] = errorList;
                if (errorList.Count > 0) OnPropertyErrorsChanged("Lastname");


                //Validate Title

                if (!_errors.TryGetValue("Title", out errorList))
                    errorList = new List<string>();
                else errorList.Clear();

                if (string.IsNullOrEmpty(Title))
                    errorList.Add("The Title can't be null or empty.");
                else if (!Title.Contains("Mr") || !Title.Contains("Ms") || !Title.Contains("Mis"))
                    errorList.Add("Wrong title, the right one are \"Mr\", \"Ms\", \"Mis\"");
                else if (!Regex.IsMatch(Title, @"^[a-zA-Z]+$"))
                    errorList.Add("The Forename must only contain letters (a-z A-Z).");

                _errors["Title"] = errorList;
                if (errorList.Count > 0) OnPropertyErrorsChanged("Title");


                //Validate Phone Number

                if (!_errors.TryGetValue("PhoneNumber", out errorList))
                    errorList = new List<string>();
                else errorList.Clear();

                if (string.IsNullOrEmpty(PhoneNumber))
                    errorList.Add("The Phone number can't be null or empty.");
                else if (PhoneNumber.Length > 13 || PhoneNumber.Length < 9)
                    errorList.Add("Phone number must be between 9 and 13 numbers long");
                else if (!Regex.IsMatch(PhoneNumber, @"^[1-9]+$"))
                    errorList.Add("The Phone number must only contain numbers.");

                _errors["PhoneNumber"] = errorList;
                if (errorList.Count > 0) OnPropertyErrorsChanged("PhoneNumber");


                //Validate Email

                if (!_errors.TryGetValue("Email", out errorList))
                    errorList = new List<string>();
                else errorList.Clear();

                if (string.IsNullOrEmpty(Email))
                    errorList.Add("The Email number can't be null or empty.");
                else if (Email.Contains('@') || !Email.Contains('.'))
                    errorList.Add("Email have to contain \'@\' and \'.\'");
                else if (Email.Length > 50 || Email.Length < 6)
                    errorList.Add("Email must be between 6 and 50 numbers long");

                _errors["Email"] = errorList;
                if (errorList.Count > 0) OnPropertyErrorsChanged("Email");


                //Validate Login



                if (!_errors.TryGetValue("Login", out errorList))
                    errorList = new List<string>();
                else errorList.Clear();

                if (string.IsNullOrEmpty(Login))
                    errorList.Add("The Login number can't be null or empty.");
                else if (!Regex.IsMatch(Login, @"^[1-9]+$"))
                    errorList.Add("The Login number must only contain numbers.");
                else if (Login.Length > 50 || Login.Length < 6)
                    errorList.Add("The Login must be between 6 and 50 numbers long");
                else if (!Login.Contains('0') || !Login.Contains('1') || !Login.Contains('2') || !Login.Contains('3')
                         || !Login.Contains('4') || !Login.Contains('5') || !Login.Contains('6') || !Login.Contains('7') 
                         || !Login.Contains('8') || !Login.Contains('9'))
                    errorList.Add("The Login have to contain one number (1-9)");
                _errors["Login"] = errorList;
                if (errorList.Count > 0) OnPropertyErrorsChanged("Login");


                //Validate Password

                if (!_errors.TryGetValue("Password", out errorList))
                    errorList = new List<string>();
                else errorList.Clear();

                if (string.IsNullOrEmpty(Password))
                    errorList.Add("The Password number can't be null or empty.");
                else if (Email.Contains('@') || !Password.Contains('.'))
                    errorList.Add("The Password have to contain \'@\' and \'.\'");
                else if (Email.Length > 50 || Password.Length < 6)
                    errorList.Add("The Password must be between 6 and 50 numbers long");

                _errors["Password"] = errorList;
                if (errorList.Count > 0) OnPropertyErrorsChanged("Password");
            }
        }
        #endregion

        #region CreateAccountWindow  -  Variables
        private string _forename;
        private string _lastname;
        private string _title;
        private string _phoneNumber;
        private string _email;
        private string _login;
        private string _password;

        public string Forename
        {
            get => _forename;
            set
            {
                _forename = value;
                OnPropertyChanged("Forename");
            }
        }
        public string Lastname
        {
            get => _lastname;
            set
            {
                _lastname = value;
                OnPropertyChanged("Lastname");
            }
        }
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        #endregion

        #region LoginWindow  -  Variables

        

        #endregion
    }
}


