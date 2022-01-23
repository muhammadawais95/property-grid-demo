using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generic_string_list_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var values = new List<string>();

            values.Add("XS");
            values.Add("S");
            values.Add("M");
            values.Add("L");
            values.Add("XL");
            StringListConverter.RegisterValuesForProperty(typeof(Clothing), nameof(Clothing.ClothingSize), values);

            values = new List<string>();
            values.Add("Primark");
            values.Add("M&S");
            values.Add("Sports Direct");
            StringListConverter.RegisterValuesForProperty(typeof(Clothing), nameof(Clothing.Supplier), values);

            var clothing = new Clothing();
            propertyGrid1.SelectedObject = clothing;
        }
    }
}
