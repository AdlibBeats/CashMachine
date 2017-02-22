using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.Model
{
    public class Admin : INotifyPropertyChanged
    {
        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                OnPropertyChanged(nameof(Admin.ID));
            }
        }
        int _ID;

        public string Login
        {
            get { return _Login; }
            set
            {
                _Login = value;
                OnPropertyChanged(nameof(Admin.Login));
            }
        }
        string _Login;

        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                OnPropertyChanged(nameof(Admin.Password));
            }
        }
        string _Password;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(Admin.Name));
            }
        }
        string _Name;

        public string Surname
        {
            get { return _Surname; }
            set
            {
                _Surname = value;
                OnPropertyChanged(nameof(Admin.Surname));
            }
        }
        string _Surname;

        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                OnPropertyChanged(nameof(Admin.Email));
            }
        }
        string _Email;

        public string Phone
        {
            get { return _Phone; }
            set
            {
                _Phone = value;
                OnPropertyChanged(nameof(Admin.Phone));
            }
        }
        string _Phone;

        public string Role
        {
            get { return _Role; }
            set
            {
                _Role = value;
                OnPropertyChanged(nameof(Admin.Role));
            }
        }
        string _Role;

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
