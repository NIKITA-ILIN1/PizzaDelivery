using System;
using System.Windows.Forms;

namespace PizzaDelivery.DataAccessObject.Services
{
    internal class UniversalMethodsCheckIsEmptyAndSelected
    {
        public static bool CheckStringsIsNullOfEmpty(params string[] strings)
        {

            foreach (string str in strings)
            {
                if (string.IsNullOrEmpty(str))
                    throw new Exception("Fields with strings is null or empty");
            }

            return true;
        }

        //public static bool CheckComboBoxesIsSelected(params ComboBox[] comboBoxes)
        //{

        //    foreach (ComboBox comboBox in comboBoxes)
        //    {
        //        if (comboBox.SelectedIndex == -1)
        //            throw new Exception("ComboBoxes no selected");
        //    }

        //    return true;
        //}
    }
}
