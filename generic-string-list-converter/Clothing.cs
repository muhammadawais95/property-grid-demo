using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_string_list_converter
{
    public class Clothing
    {
        private string _name = "Shirt";
        private string _clothingSize = "M";
        private string _supplier = "Primark";

        [TypeConverter(typeof(StringListConverter))]
        public string ClothingSize
        {
            get { return _clothingSize; }
            set { _clothingSize = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [TypeConverter(typeof(StringListConverter))]
        public string Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }

    }
}
