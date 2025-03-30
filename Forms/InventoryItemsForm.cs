using CodeSystem.ReportDataSetTableAdapters;
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
    public partial class InventoryItemsForm : UserControl
    {
        public InventoryItemsForm()
        {
            InitializeComponent();
            //this.Load += InventoryItemsForm_Load;
        }

       

        private void InventoryItemsForm_Load(object sender, EventArgs e)
        {
            this.tblItemTableAdapter.Fill(this.reportDataSet.tblItem);
            this.tblItemSizeTableAdapter.Fill(this.reportDataSet.tblItemSize);
            this.tblColorTableAdapter.Fill(this.reportDataSet.tblColor);
            this.tblItemTypeTableAdapter.Fill(this.reportDataSet.tblItemType);
            this.tblUseTypeTableAdapter.Fill(this.reportDataSet.tblUseType);
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add data from textboxes, comboBoxes, checkboxes to database (tblItem, tblItemGroup, tblItemOtherData)
            // Add data to tblItemGroup first
            DataRow newRow1 = reportDataSet.tblItemGroup.NewRow();
            newRow1["ID"] = itemGroupID_textBox.Text;
            newRow1["NameAr"] = arName_textBox.Text;
            newRow1["NameEn"] = enName_textBox.Text;
            newRow1["ShortName"] = shortName_textBox.Text;
            newRow1["VAT"] = vat_textBox.Text;
            newRow1["NotUsed"] = notUsed_checkbox.Checked;
            newRow1["UseTypeID"] = useTypeID_comboBox.SelectedValue;
            newRow1["ItemTypeID"] = itemTypeID_comboBox.SelectedValue;
            newRow1["FilePath"] = filePath_textBox.Text;
            newRow1["ItemNote"] = itemNote_textBox.Text;
            reportDataSet.tblItemGroup.Rows.Add(newRow1);
            tblItemGroupTableAdapter.Update(reportDataSet.tblItemGroup);

            // Add data to tblItem
            DataRow newRow = reportDataSet.tblItem.NewRow();
            newRow["ID"] = id_textBox.Text;
            newRow["Price"] = price_textBox.Text;
            newRow["MinimumPrice"] = minimumPrice_textBox.Text;
            newRow["WholesalePrice"] = wholesalePrice_textBox.Text;
            newRow["quickitem"] = quickItem_checkBox.Checked;
            newRow["ItemGroupID"] = itemGroupID_textBox.Text;
            newRow["WithVatPrice"] = withVatPrice_textBox.Text;
            reportDataSet.tblItem.Rows.Add(newRow);
            tblItemTableAdapter.Update(reportDataSet.tblItem);

            // Add data to tblItemOtherData1
            DataRow newRow2 = reportDataSet.tblItemOtherData1.NewRow();
            newRow2["ItemID"] = id_textBox.Text;
            newRow2["BarcodeNo"] = barcodeNumber_textBox.Text;
            newRow2["ColorID"] = colorID_comboBox.SelectedValue;
            newRow2["ItemPlaceID"] = itemPlaceID_comboBox.SelectedValue ?? DBNull.Value;
            newRow2["ItemSizeID"] = itemSizeID_comboBox.SelectedValue;
            newRow2["UnitCount"] = unitCount_textBox.Text;
            reportDataSet.tblItemOtherData1.Rows.Add(newRow2);
            tblItemOtherData1TableAdapter.Update(reportDataSet.tblItemOtherData1);


            // Add data to tblItemBalance1
            DataRow newRow3 = reportDataSet.tblItemBalance1.NewRow();
            newRow3["ItemID"] = id_textBox.Text;
            newRow3["OrderMinammBalance"] = minimumOrder_textBox.Text;
            newRow3["OrderCount"] = orderCount_textBox.Text;

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

        



    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
