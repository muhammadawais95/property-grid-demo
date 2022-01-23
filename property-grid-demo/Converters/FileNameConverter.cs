using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_grid_demo
{
    public class FileNameConverter : StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(new string[] { "New File", "File1", "Document1" });
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            // Setting it to true changes the drop-down list style to a combo box style
            return false;
        }
    }
}