using CodeSystem.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CodeSystem.Forms
{
    public partial class InventoryForm : UserControl
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        public string savedPicturePath;

        private void fillFormDemoData()
        {
            // Fill the form with demo data for testing purposes 
            // get random number 
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);
            itemIDTextBox.Text = randomNumber.ToString();
            groupIDTextBox.Text = randomNumber.ToString();
            priceWithVATTextBox.Text = (randomNumber * (randomNumber / 100)).ToString();
          
            minimumPriceTextBox.Text = randomNumber.ToString();
            nameArabicTextBox.Text = " اسم العنصر " + randomNumber;
            nameEnglishTextBox.Text = " Item Name " + randomNumber;
            notUsedCheckBox.Checked = true;
            priceWithoutVATTextBox.Text = randomNumber.ToString();
            unitCountTextBox.Text = randomNumber.ToString();
            quickItemCheckBox.Checked = true;
            nameShortTextBox.Text = " Short Name " + randomNumber;
            VATPercentageTextBox.Text =  (randomNumber/ 100).ToString();
            wholesalePriceTextBox.Text = randomNumber.ToString();
            itemTypeComboBox.SelectedIndex = 0;
            useTypeComboBox.SelectedIndex = 0;
            itemNotesTextBox.Text = "Item Notes";
            barcodeNumberTextBox.Text = randomNumber.ToString();
            itemColorComboBox.SelectedIndex = 0;
            //itemPlaceComboBox.SelectedIndex = 0;

            

        }

        private void fillComboBoxes()
        {
            string languageToView = CurrentUser.Instance.language == "ar" ? "NameAr" : "NameEn";


            this.tblItemTableAdapter.Fill(this.reportDataSet.tblItem);
            this.tblItemSizeTableAdapter.Fill(this.reportDataSet.tblItemSize);
            this.tblColorTableAdapter.Fill(this.reportDataSet.tblColor);
            this.tblItemTypeTableAdapter.Fill(this.reportDataSet.tblItemType);
            this.tblUseTypeTableAdapter.Fill(this.reportDataSet.tblUseType);

            unitTypeComboBox.DisplayMember = languageToView;
            itemTypeComboBox.DisplayMember = languageToView;
            itemGroupComboBox.DisplayMember = languageToView;
            itemColorComboBox.DisplayMember = languageToView;
            useTypeComboBox.DisplayMember = languageToView;
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            fillComboBoxes();
            fillFormDemoData();

            this.tblItemOtherData1TableAdapter.Fill(this.reportDataSet.tblItemOtherData1);
            this.tblItemBalance1TableAdapter.Fill(this.reportDataSet.tblItemBalance1);

            this.tblItemGroupTableAdapter.Fill(this.reportDataSet.tblItemGroup);
            dataGridView1.DataSource = reportDataSet.tblItemGroup;

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

        // make a clear all textboxes comboboxes and checkboxes 
        private void clear_form()
        {
            itemIDTextBox.Text = "";
            nameArabicTextBox.Text = "";
            nameEnglishTextBox.Text = "";
            nameShortTextBox.Text = "";
            VATPercentageTextBox.Text = "";
            notUsedCheckBox.Checked = false;
            useTypeComboBox.SelectedValue = DBNull.Value;
            itemTypeComboBox.SelectedValue = DBNull.Value;
            savedPicturePath = "";
            itemNotesTextBox.Text = "";
            savedPictureBox.Image = null;
            priceWithoutVATTextBox.Text = "";
            minimumPriceTextBox.Text = "";
            wholesalePriceTextBox.Text = "";
            quickItemCheckBox.Checked = false;
            groupIDTextBox.Text = "";
            priceWithVATTextBox.Text = "";
            barcodeNumberTextBox.Text = "";
            itemColorComboBox.SelectedValue = DBNull.Value;
            itemPlaceComboBox.SelectedValue = DBNull.Value;
            unitTypeComboBox.SelectedValue = DBNull.Value;
            unitCountTextBox.Text = "";
            minimumReorderTextBox.Text = "";
            orderQuantityTextBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow1 = reportDataSet.tblItemGroup.NewRow();
                newRow1["ID"] = itemIDTextBox.Text;
                newRow1["NameAr"] = nameArabicTextBox.Text;
                newRow1["NameEn"] = nameEnglishTextBox.Text;
                newRow1["ShortName"] = nameShortTextBox.Text;
                newRow1["VAT"] = VATPercentageTextBox.Text;
                newRow1["NotUsed"] = notUsedCheckBox.Checked;
                newRow1["UseTypeID"] = useTypeComboBox.SelectedValue;
                newRow1["ItemTypeID"] = itemTypeComboBox.SelectedValue;
                newRow1["FilePath"] = savedPicturePath;
                newRow1["ItemNote"] = itemNotesTextBox.Text;
                reportDataSet.tblItemGroup.Rows.Add(newRow1);
                tblItemGroupTableAdapter.Update(reportDataSet.tblItemGroup);

                // Add data to tblItem
                DataRow newRow = reportDataSet.tblItem.NewRow();
                newRow["ID"] = itemIDTextBox.Text;
                newRow["Price"] = priceWithoutVATTextBox.Text;
                newRow["MinimumPrice"] = minimumPriceTextBox.Text;
                newRow["WholesalePrice"] = wholesalePriceTextBox.Text;
                newRow["quickitem"] = quickItemCheckBox.Checked;
                newRow["ItemGroupID"] = groupIDTextBox.Text;
                newRow["WithVatPrice"] = priceWithVATTextBox.Text;
                reportDataSet.tblItem.Rows.Add(newRow);
                tblItemTableAdapter.Update(reportDataSet.tblItem);

                // Add data to tblItemOtherData1
                DataRow newRow2 = reportDataSet.tblItemOtherData1.NewRow();
                newRow2["ItemID"] = itemIDTextBox.Text;
                newRow2["BarcodeNo"] = barcodeNumberTextBox.Text;
                newRow2["ColorID"] = itemColorComboBox.SelectedValue;
                newRow2["ItemPlaceID"] = itemPlaceComboBox.SelectedValue ?? DBNull.Value;
                newRow2["ItemSizeID"] = unitTypeComboBox.SelectedValue;
                newRow2["UnitCount"] = unitCountTextBox.Text;
                reportDataSet.tblItemOtherData1.Rows.Add(newRow2);
                tblItemOtherData1TableAdapter.Update(reportDataSet.tblItemOtherData1);


                // Add data to tblItemBalance1
                DataRow newRow3 = reportDataSet.tblItemBalance1.NewRow();
                newRow3["ItemID"] = itemIDTextBox.Text;
                newRow3["OrderMinammBalance"] = minimumReorderTextBox.Text;
                newRow3["OrderCount"] = orderQuantityTextBox.Text;

                reportDataSet.tblItemBalance1.Rows.Add(newRow3);

                // Set all other columns in the added row to zero, except for the ones you added
                foreach (DataColumn column in reportDataSet.tblItemBalance1.Columns)
                {
                    if (column.ColumnName != "ItemID" && column.ColumnName != "OrderMinammBalance" && column.ColumnName != "OrderCount")
                    {
                        if (column.DataType == typeof(DateTime))
                        {
                            newRow3[column] = DBNull.Value; // Set the value to DBNull for DateTime columns
                        }
                        else
                        {
                            newRow3[column] = 0; // Set the value to zero for other types
                        }
                    }
                }
                tblItemBalance1TableAdapter.Update(reportDataSet.tblItemBalance1);

                dataGridView1.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void selectPictureButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set file filter for image files
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file's path
                    string sourcePath = openFileDialog.FileName;
                    //MessageBox.Show($"Selected Path: {sourcePath}", "Image Selected");

                    // Define the destination folder and file
                    string destinationFolder = @"C:\Codes\Codes101\SavedPictures";
                    string destinationPath = Path.Combine(destinationFolder, Path.GetFileName(sourcePath));

                    try
                    {
                        // Ensure the destination directory exists
                        if (!Directory.Exists(destinationFolder))
                        {
                            Directory.CreateDirectory(destinationFolder);
                        }

                        // Copy the image file
                        File.Copy(sourcePath, destinationPath, overwrite: true);
                        //MessageBox.Show($"Image copied to: {destinationPath}", "Success");

                        // Save the path to the savedPicturePath variable
                        savedPicturePath = destinationPath;
                        savedPictureBox.Image = Image.FromFile(savedPicturePath);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error");
                    }
                }
            }
        
    }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                clear_form();
                DataGridView dataGridView = sender as DataGridView;

                // Get the clicked row
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Fill textboxes with values from the row's cells
                if (row != null)
                {
              

                    itemIDTextBox.Text = row.Cells[0].Value.ToString();
                    nameArabicTextBox.Text = row.Cells[1].Value.ToString();
                    nameEnglishTextBox.Text = row.Cells[2].Value.ToString();
                    nameShortTextBox.Text = row.Cells[3].Value.ToString();
                    VATPercentageTextBox.Text = row.Cells[4].Value.ToString();
                    notUsedCheckBox.Checked = (bool)row.Cells[5].Value;
                    useTypeComboBox.SelectedValue = row.Cells[6].Value;
                    itemTypeComboBox.SelectedValue = row.Cells[7].Value;
                    savedPicturePath = row.Cells[8].Value.ToString();
                    itemNotesTextBox.Text = row.Cells[9].Value.ToString();
                    
                    tblItemOtherData1BindingSource.Filter = $"ItemID = {itemIDTextBox.Text}";

                    if (tblItemOtherData1BindingSource.Count > 0)
                    {
                        DataRowView rowView = tblItemOtherData1BindingSource[0] as DataRowView;
                        if (rowView != null)
                        {
                            barcodeNumberTextBox.Text = rowView["BarcodeNo"].ToString();
                            itemColorComboBox.SelectedValue = rowView["ColorID"];
                            itemPlaceComboBox.SelectedValue = rowView["ItemPlaceID"];
                            unitTypeComboBox.SelectedValue = rowView["ItemSizeID"];
                            unitCountTextBox.Text = rowView["UnitCount"].ToString();
                        }
                    }

                    tblItemBalance1BindingSource.Filter = $"ItemID = {itemIDTextBox.Text}";

                    if (tblItemBalance1BindingSource.Count > 0)
                    {
                        DataRowView rowView = tblItemBalance1BindingSource[0] as DataRowView;
                        if (rowView != null)
                        {
                            minimumReorderTextBox.Text = rowView["OrderMinammBalance"].ToString();
                            orderQuantityTextBox.Text = rowView["OrderCount"].ToString();
                        }
                    }

                    tblItemBindingSource.Filter = $"ID = {itemIDTextBox.Text}";

                    if (tblItemBindingSource.Count > 0)
                    {
                        DataRowView rowView = tblItemBindingSource[0] as DataRowView;
                        if (rowView != null)
                        {
                            priceWithoutVATTextBox.Text = rowView["Price"].ToString();
                            minimumPriceTextBox.Text = rowView["MinimumPrice"].ToString();
                            wholesalePriceTextBox.Text = rowView["WholesalePrice"].ToString();
                            quickItemCheckBox.Checked = (bool)rowView["quickitem"];
                            groupIDTextBox.Text = rowView["ItemGroupID"].ToString();
                            priceWithVATTextBox.Text = rowView["WithVatPrice"].ToString();
                        }
                    }

                    //groupIDTextBox.Text = row.Cells[10].Value.ToString();
                    //itemGroupComboBox.SelectedValue = row.Cells[10].Value;
                    //priceWithoutVATTextBox.Text = row.Cells[11].Value.ToString();
                    //minimumPriceTextBox.Text = row.Cells[12].Value.ToString();
                    //wholesalePriceTextBox.Text = row.Cells[13].Value.ToString();
                    //quickItemCheckBox.Checked = (bool)row.Cells[14].Value;
                    //priceWithVATTextBox.Text = row.Cells[15].Value.ToString();
                    //barcodeNumberTextBox.Text = row.Cells[16].Value.ToString();
                    //itemColorComboBox.SelectedValue = row.Cells[17].Value;
                    //itemPlaceComboBox.SelectedValue = row.Cells[18].Value;
                    //unitTypeComboBox.SelectedValue = row.Cells[19].Value;
                    //unitCountTextBox.Text = row.Cells[20].Value.ToString();
                    //minimumReorderTextBox.Text = row.Cells[21].Value.ToString();
                    //orderQuantityTextBox.Text = row.Cells[22].Value.ToString();


                    // Display the image in the PictureBox if not null or empty 
                    if (!string.IsNullOrEmpty(savedPicturePath))
                    {
                        if (File.Exists(savedPicturePath)) {

                        savedPictureBox.Image = Image.FromFile(savedPicturePath);
                        }
                    }
                }
            }
        }
    }
}
