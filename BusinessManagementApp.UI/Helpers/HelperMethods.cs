using BusinessManagementApp.Common;
using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers.Models;
using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.UI.Helpers
{
    public static class HelperMethods
    {
        public static void ShowErrors(List<ValidationError> validationErrors)
        {
            string errortext = "";
            foreach (ValidationError error in validationErrors)
            {
                errortext += error.ErrorMessage+"\n";
            }
            MessageBox.Show(errortext);
        }
        public static void ComboboxListBindToCombobox(List<ComboboxModel> list ,List<ComboBox> comboboxes)
        {
            list.Insert(0, new() { Text = "Seçiniz. ", Value = 0 });
            foreach (var item in comboboxes)
            {
                item.DataSource = list;
                item.ValueMember = "Value";
                item.DisplayMember = "Text";
            }
        }
    }
}
