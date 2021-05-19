using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisTakipPL
{
    public class Utilities
    {
        public static void AutoComplete(ComboBox comboBox)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                collection.Add(comboBox.GetItemText(comboBox.Items[i]));
            }
            comboBox.AutoCompleteCustomSource = collection;
        }

        public static void LoadComboBox(ComboBox comboBox, object result, string displayMember, string valueMember)
        {
            comboBox.DataSource = result;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        public static void CombobxControl(ComboBox comboBox, Label label)
        {
            if (comboBox.FindStringExact(comboBox.Text) != -1)
            {
                label.ForeColor = Color.Black;
                comboBox.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Geçersiz Değer.");
                comboBox.SelectedIndex = 0;
                label.ForeColor = Color.Red;
                comboBox.ForeColor = Color.Red;
            }
        }
    }
}
