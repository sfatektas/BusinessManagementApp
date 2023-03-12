using BusinessManagementApp.Common;
using BusinessManagementApp.Common.Consts;
using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers.Models;
using BussinesManagementApp.Dtos;
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
        public static void ClearTextBox (List<TextBox> textBoxes) {
            foreach (var item in textBoxes)
            {
                item.Text = "";
            }
        }
        public static void DisableTextBox(List<TextBox> textBoxes)
        {
            foreach (var item in textBoxes)
            {
                item.Enabled = false;
            }
        }
        public static void EnableTextBox(List<TextBox> textBoxes)
        {
            foreach (var item in textBoxes)
            {
                item.Enabled = true;
            }
        }
        public static bool IsNotNull(List<TextBox> textBoxes)
        {
            foreach (var item in textBoxes)
            {
                if (item.Text.Length == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void BindToComboboxMoneyTypeAndValues(List<ComboBox> comboBoxes)
        {
            var items = new List<ComboboxModel>();
            items.Add(new ComboboxModel { Text = "Seçiniz.", Value = 0 });
            items.Add(new ComboboxModel { Text = "TL", Value = (int)MoneyType.TL });
            items.Add(new ComboboxModel { Text = "Euro", Value = (int)MoneyType.Euro });
            items.Add(new ComboboxModel { Text = "Dolar" ,Value = (int)MoneyType.Dolar });
            foreach (var item in comboBoxes)
            {
                item.DataSource = items;
                item.ValueMember = "Value";
                item.DisplayMember = "Text";
            }
        }
        public static void IsOkPriceFormat(ref object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (e.KeyChar == '.' && (sender as TextBox).Text != "") && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.' && (sender as TextBox).Text == ""))
            {
                e.Handled = false;
            }
        }
        public static void IsOkNumberFormat(ref object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar) && e.KeyChar != '\b' )
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
        public static double GetDoubleMoneyFormat(this double value)
        {
            return double.Parse(value.ToString("0.##"));
        }
        public static string GetStringMoneyFormat(this double value)
        {
            return value.ToString("0.##");
        }
        public static int ParseWithError(string value)
        {
            try
            {
                if(value == "")
                {
                    MessageBox.Show("Boş değer");
                    return 0;
                }
                else
                return int.Parse(value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Sayı Formatı uygun değil");
                return 0;
            }
        }
        public static double doubleParseWithError(string value)
        {
            try
            {
                if (value == "")
                {
                    MessageBox.Show("Boş değer");
                    return 0;
                }
                else
                    return double.Parse(value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Sayı Formatı uygun değil");
                return 0;
            }
        }
        public static bool AreYouSure()
        {
            if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                return true;
            else
                return false;
        }
        public static List<CustomerOrderDataGridModel> ChangeModelTypeToCustomerOrderDataGridModel(List<CustomerOrderListDto> CustomerOrderLists)
        {
            List<CustomerOrderDataGridModel> list = new List<CustomerOrderDataGridModel>();
            foreach (var item in CustomerOrderLists)
            {
                list.Add(new()
                {
                    Id = item.Id,
                    Amount = item.Amount,
                    CustomerName = item.Customer.CominicatePersonName + " -- " + item.Customer.CompanyName,
                    Date = item.Date,
                    OrderStatus = item.OrderStatusTypeId == (int)OrderStatusType.Complated ? "Tamamlandı": "Ön Sipariş",
                    OrderStatusId = item.OrderStatusTypeId,
                    ProductName = item.Product.Name,
                    TotalKdvPrice = item.KdvPrice.GetDoubleMoneyFormat(),
                    TotalPrice = item.TotalPrice.GetDoubleMoneyFormat(),
                    UnitPrice = item.UnitPrice.GetDoubleMoneyFormat()
                });
            }
            return list;
        }
    }
}
