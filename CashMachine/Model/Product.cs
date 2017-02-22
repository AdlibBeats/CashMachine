using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.Model
{
    public class Product : INotifyPropertyChanged
    {
        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                OnPropertyChanged(nameof(Product.ID));
            }
        }
        int _ID;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged(nameof(Product.Name));
            }
        }
        string _Name;

        public double PurchasePrice
        {
            get { return _PurchasePrice; }
            set
            {
                _PurchasePrice = value;
                OnPropertyChanged(nameof(Product.PurchasePrice));
            }
        }
        double _PurchasePrice;

        public double WholesalePrice
        {
            get { return _WholesalePrice; }
            set
            {
                _WholesalePrice = value;
                OnPropertyChanged(nameof(Product.WholesalePrice));
            }
        }
        double _WholesalePrice;

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
