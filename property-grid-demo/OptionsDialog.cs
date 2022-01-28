using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace property_grid_demo
{
    public partial class OptionsDialog : Form
    {
        public OptionsDialog()
        {
            InitializeComponent();
        }

        private void OptionsDialog_Load(object sender, EventArgs e)
        {
            var appSettings = new AppSettings();
            optionsPropertyGrid.SelectedObject = appSettings;
        }

        private void optionsPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Console.WriteLine($"The changed item was {e.ChangedItem}");
            var x = e.ChangedItem.GetType().GetProperty("Instance").GetValue(e.ChangedItem);
        }
    }
}
