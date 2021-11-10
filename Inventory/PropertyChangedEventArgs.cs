using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class PropertyChangedEventArgs : EventArgs
    {
        public PropertyChangedEventArgs(string previosValue, string newValue, string propertyName)
        {
            PreviosValue = previosValue;
            NewValue = newValue;
            PropertyName = propertyName;
        }

        public string PreviosValue { get; }
        public string NewValue { get; }
        public string PropertyName { get; }
    }
}
