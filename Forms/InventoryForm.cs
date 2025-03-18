using CodeSystem.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSystem.Forms
{
    public partial class InventoryForm : UserControl
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void fillComboBoxes()
        {
            string languageToView = CurrentUser.Instance.language == "ar" ? "NameAr" : "NameEn";

            DataTable types = Item.GetDataFromTable("tblItemType");

            itemTypeComboBox.DataSource = types;
            itemTypeComboBox.ValueMember = "ID";
            itemTypeComboBox.DisplayMember = languageToView;

            DataTable units = Item.GetDataFromTable("tblItemSize");

            unitTypeComboBox.DataSource = units;
            unitTypeComboBox.ValueMember = "ID";
            unitTypeComboBox.DisplayMember = languageToView;

            DataTable groups = Item.GetDataFromTable("tblItemGroup");

            itemGroupComboBox.DataSource = groups;
            itemGroupComboBox.ValueMember = "ID";
            itemGroupComboBox.DisplayMember = languageToView;

            DataTable colors = Item.GetDataFromTable("tblColor");


            itemColorComboBox.DataSource = colors;
            itemColorComboBox.ValueMember = "ID";
            itemColorComboBox.DisplayMember = languageToView;

            DataTable useTypes = Item.GetDataFromTable("tblUseType");

            useTypeComboBox.DataSource = useTypes;
            useTypeComboBox.ValueMember = "ID";
            useTypeComboBox.DisplayMember = languageToView;
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            fillComboBoxes();

        }


        private void itemTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupIDTextBox.Text = itemGroupComboBox.SelectedValue.ToString();
        }

        private void groupIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (groupIDTextBox.Text == "")
            {
                itemGroupComboBox.SelectedIndex = 0;
            }
            else
            {
                bool valueExists = false;

                // Iterate through ComboBox items to check for the value
                foreach (var item in itemGroupComboBox.Items)
                {
                    // Assume ComboBox items are DataRowView objects
                    DataRowView rowView = item as DataRowView;

                    if (rowView != null && rowView["ID"].ToString() == groupIDTextBox.Text)
                    {
                        valueExists = true;
                        break;
                    }
                }

                // Take action based on whether the value exists
                if (valueExists)
                {
                   itemGroupComboBox.SelectedValue = groupIDTextBox.Text;
                }
               
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Get data from the form textboxes and comboboxes
            int id = Convert.ToInt32(itemIDTextBox.Text);
            int itemGroupID = Convert.ToInt32(groupIDTextBox.Text);
            decimal costPrice = Convert.ToDecimal(priceWithVATTextBox.Text);
            DateTime lastPurchaseDate = Convert.ToDateTime(lastPurchaseDateTextBox.Text);
            decimal lastPurchasePrice =Convert.ToDecimal(lastPurchasePriceTextBox.Text);
            decimal maxPurchasePrice = Convert.ToDecimal(maxPurchasePriceTextBox.Text);
            decimal minimumPrice = Convert.ToDecimal(minimumPriceTextBox.Text);
            decimal minPurchasePrice =  Convert.ToDecimal(minPurchasePriceTextBox.Text);
            string nameAr = nameArabicTextBox.Text;
            string nameEn = nameEnglishTextBox.Text;
            bool notUsed = notUsedCheckBox.Checked;
            decimal price = Convert.ToDecimal(priceWithoutVATTextBox.Text);
            int qty = Convert.ToInt32(quantityTextBox.Text);
            bool quickItem = quickItemCheckBox.Checked;
            string shortName = nameShortTextBox.Text;
            decimal vat = Convert.ToDecimal(VATPercentageTextBox.Text);
            decimal wholesalePrice = Convert.ToDecimal(wholesalePriceTextBox.Text);
            int itemTypeID = Convert.ToInt32(itemTypeComboBox.SelectedValue);
            int useTypeID = Convert.ToInt32(useTypeComboBox.SelectedValue);
            string itemNote = itemNotesTextBox.Text;
            string barcodeNo = barcodeNumberTextBox.Text;
            int? colorID = string.IsNullOrEmpty(itemColorComboBox.SelectedValue?.ToString()) ? (int?)null : Convert.ToInt32(itemColorComboBox.SelectedValue);
            string filePath = "";
            int? itemPlaceID = string.IsNullOrEmpty(itemPlaceComboBox.SelectedValue?.ToString()) ? (int?)null : Convert.ToInt32(itemPlaceComboBox.SelectedValue);
            int? itemSizeID = string.IsNullOrEmpty(unitTypeComboBox.SelectedValue?.ToString()) ? (int?)null : Convert.ToInt32(unitTypeComboBox.SelectedValue);
            int unitCount = Convert.ToInt32(quantityTextBox.Text);

            // Create a new Item object
            Item newItem = new Item(id, itemGroupID, costPrice, lastPurchaseDate, lastPurchasePrice, maxPurchasePrice, minimumPrice, minPurchasePrice, nameAr, nameEn, notUsed, price, qty, quickItem, shortName, vat, wholesalePrice, itemTypeID, useTypeID, itemNote, barcodeNo, colorID, filePath, itemPlaceID, itemSizeID, unitCount);

            // Insert the new item into the database
            bool isInserted = newItem.Insert("\"C:\\Codes\\Codes101\\Report.accde\"");

            // Check if the item was successfully inserted
            if (isInserted)
            {
                MessageBox.Show("Item successfully added to the inventory.");
            }
            else
            {
                MessageBox.Show("Failed to add item to the inventory.");
            }
        }
    }
}
