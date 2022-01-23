using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_string_list_converter
{
    public class StringListConverter : TypeConverter
    {
        /// <summary>
        /// Dictionary that maps a combination of type and property name to a list of strings
        /// </summary>
        private static Dictionary<(Type type, string propertyName), IEnumerable<string>> _lists = new Dictionary<(Type type, string propertyName), IEnumerable<string>>();

        public static void RegisterValuesForProperty(Type type, string propertyName, IEnumerable<string> list)
        {
            _lists[(type, propertyName)] = list;
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            if (_lists.TryGetValue((context.PropertyDescriptor.ComponentType, context.PropertyDescriptor.Name), out var list))
            {
                return new StandardValuesCollection(list.ToList());
            }
            else
            {
                throw new Exception("Unknown property " + context.PropertyDescriptor.ComponentType + " " + context.PropertyDescriptor.Name);
            }


        }
    }
}
