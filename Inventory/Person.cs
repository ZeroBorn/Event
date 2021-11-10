using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Person
    {
        public event EventHandler<PropertyChangedEventArgs> PropertyChanged; 
        
        private string _firstName;
        private string _lastName;

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { var args = new PropertyChangedEventArgs(_firstName,value,nameof(FirstName));
                _firstName = value;
                OnPropertyChanged(this, args);
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set { var args = new PropertyChangedEventArgs(_lastName,value,nameof(LastName));
                _lastName = value;
                OnPropertyChanged(this, args);
            }
        }


        public virtual void OnPropertyChanged(object? sender,PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(sender,e);
        }
    }
}
