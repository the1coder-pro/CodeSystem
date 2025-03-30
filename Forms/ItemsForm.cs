using CodeSystem.Repositories;
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
    public partial class ItemsForm : UserControl
    {
        public ItemsForm()
        {
            InitializeComponent();
            this.Load += ItemsForm_Load;
        }

        public void ItemsForm_Load(object sender, EventArgs e)
        {
            UserRepository repo = new UserRepository();
            //ItemList_DataGridView.DataSource = itemRepository.GetItems()
            DataTable tblItem = repo.GetTableData("tblItem1");
            List<string> columns = repo.GetColumns("tblItem1");


            // order the columns of datatable tblItem to columns
            foreach (string column in columns)
            {
                if (!tblItem.Columns.Contains(column))
                {
                    tblItem.Columns.Add(column);
                }
            }

            // change the columns of grid view to the columns of the table
            ItemList_DataGridView.Columns.Clear();

            foreach (string column in columns)
            {
                ItemList_DataGridView.Columns.Add(column, column);
            }

            DataTable reorderedTable = ReorderDataTableColumns(tblItem, columns);

            // add data to datagrid view
            foreach (DataRow row in reorderedTable.Rows)
            {
                ItemList_DataGridView.Rows.Add(row.ItemArray);
            }


        }

        static DataTable ReorderDataTableColumns(DataTable originalTable, List<string> columnOrder)
        {
            // Create a new DataTable with the desired column order
            DataTable reorderedTable = new DataTable();

            // Add columns in the specified order
            foreach (string columnName in columnOrder)
            {
                if (originalTable.Columns.Contains(columnName))
                {
                    reorderedTable.Columns.Add(columnName, originalTable.Columns[columnName].DataType);
                }
            }

            // Copy rows from the original table to the new table
            foreach (DataRow originalRow in originalTable.Rows)
            {
                DataRow newRow = reorderedTable.NewRow();
                foreach (string columnName in columnOrder)
                {
                    if (originalTable.Columns.Contains(columnName))
                    {
                        newRow[columnName] = originalRow[columnName];
                    }
                }
                reorderedTable.Rows.Add(newRow);
            }

            return reorderedTable;
        }

        /*
         
         CostPrice
0
ID
1
ItemGroupID
1
LastPurchaseDate
3/13/2025 12:00:00 AM
LastPurchasePrice
10
MaxPurchasePrice
10
MinimumPrice
10
MinPurchasePrice
10
NameAr
جوال ايفون
NameEn
iPhone
NotUsed
False
Price
10
Qty
-52
quickitem
True
ShortName
iphone
VAT
0.15
WholesalePrice
0
CostPrice
0
ID
2
ItemGroupID
2
LastPurchaseDate
3/13/2025 12:00:00 AM
LastPurchasePrice
11.5
MaxPurchasePrice
11.5
MinimumPrice
0
MinPurchasePrice
11.5
NameAr
شاحن ايفون
NameEn
 iPhone Charger
NotUsed
False
Price
10
Qty
-91
quickitem
True
ShortName
charger-iphone
VAT
0.15
WholesalePrice
0
CostPrice
0
ID
3
ItemGroupID
3
LastPurchaseDate
3/13/2025 12:00:00 AM
LastPurchasePrice
120
MaxPurchasePrice
120
MinimumPrice
120
MinPurchasePrice
120
NameAr
سماعة
NameEn
headset
NotUsed
False
Price
120
Qty
-16
quickitem
True
ShortName
سماعة
VAT
0
WholesalePrice
0
         */



        public Item selectedItem;
        private void ItemList_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //// when user clicks on the row, the data of the row will be displayed in the textboxes
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.ItemList_DataGridView.Rows[e.RowIndex];
            //    NameAr_TextBox.Text = row.Cells["NameAr"].Value.ToString();
            //    NameEn_TextBox.Text = row.Cells["NameEn"].Value.ToString();
            //    ShortName_TextBox.Text = row.Cells["ShortName"].Value.ToString();
            //    VAT_TextBox.Text = row.Cells["VAT"].Value.ToString();
            //    //Qty_TextBox.Text = row.Cells["Qty"].Value.ToString();
            //    //MinimumPrice_TextBox.Text = row.Cells["MinimumPrice"].Value.ToString();
            //    //MaxPurchasePrice_TextBox.Text = row.Cells["MaxPurchasePrice"].Value.ToString();
            //    //MinPurchasePrice_TextBox.Text = row.Cells["MinPurchasePrice"].Value.ToString();
            //    //LastPurchasePrice_TextBox.Text = row.Cells["LastPurchasePrice"].Value.ToString();
            //    //LastPurchaseDate_TextBox.Text = row.Cells["LastPurchaseDate"].Value.ToString();
            //    GroupID_TextBox.Text = row.Cells["ItemGroupID"].Value.ToString();
            //    NotUsed_CheckBox.Checked = (bool)row.Cells["NotUsed"].Value;
            //    //QuickItem_CheckBox.Checked = (bool)row.Cells["quickitem"].Value;
            //}
        }

        private void ItemList_DataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ItemList_DataGridView.Rows.Count - 1) // Exclude empty row
            {
                DataGridViewRow row = this.ItemList_DataGridView.Rows[e.RowIndex];
                
                if (!row.IsNewRow)
                {
 //                   selectedItem = new Item(
 //    id: Convert.ToInt32(row.Cells["ID"].Value),
 //    itemGroupID: Convert.ToInt32(row.Cells["ItemGroupID"].Value),
 //    costPrice: Convert.ToDecimal(row.Cells["CostPrice"].Value),  // Make sure this column is included!
 //    lastPurchaseDate: Convert.ToDateTime(row.Cells["LastPurchaseDate"].Value),
 //    lastPurchasePrice: Convert.ToDecimal(row.Cells["LastPurchasePrice"].Value),
 //    maxPurchasePrice: Convert.ToDecimal(row.Cells["MaxPurchasePrice"].Value),
 //    minimumPrice: Convert.ToDecimal(row.Cells["MinimumPrice"].Value),
 //    minPurchasePrice: Convert.ToDecimal(row.Cells["MinPurchasePrice"].Value),
 //    nameAr: row.Cells["NameAr"].Value.ToString(),
 //    nameEn: row.Cells["NameEn"].Value.ToString(),
 //    notUsed: Convert.ToBoolean(row.Cells["NotUsed"].Value),
 //    price: Convert.ToDecimal(row.Cells["Price"].Value),  // Make sure this column is included!
 //    qty: Convert.ToInt32(row.Cells["Qty"].Value),
 //    quickItem: Convert.ToBoolean(row.Cells["quickitem"].Value),
 //    itemTypeID: Convert.ToInt32(row.Cells["ItemTypeId"].Value),
 //    useTypeID: Convert.ToInt32(row.Cells["UseTypeID"].Value),
 //    itemNote: row.Cells["ItemNote"].Value.ToString(),
 //    barcodeNo: "0303",
 //    colorID: Convert.ToInt32(row.Cells["ColorID"].Value),
 //    filePath: row.Cells["FilePath"].Value.ToString(),
 //    itemPlaceID: Convert.ToInt32(row.Cells["ItemPlaceID"].Value),
 //    itemSizeID: Convert.ToInt32(row.Cells["ItemSizeID"].Value),
 //    unitCount: Convert.ToInt32(row.Cells["UnitCount"].Value),
 //    shortName: row.Cells["ShortName"].Value.ToString(),
 //    vat: Convert.ToDecimal(row.Cells["VAT"].Value),
 //    wholesalePrice: Convert.ToDecimal(row.Cells["WholesalePrice"].Value)  // Ensure this column exists!
 //);


                }
            }
        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            // add new row to the datagridview
            ItemList_DataGridView.Rows.Add();

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {

            // get the last item data into item object
            DataGridViewRow row = this.ItemList_DataGridView.Rows[ItemList_DataGridView.Rows.Count - 2];
  //          selectedItem = new Item(
  //    id: Convert.ToInt32(row.Cells["ID"].Value),
  //    itemGroupID: Convert.ToInt32(row.Cells["ItemGroupID"].Value),
  //    costPrice: Convert.ToDecimal(row.Cells["CostPrice"].Value),  // Make sure this column is included!
  //    lastPurchaseDate: Convert.ToDateTime(row.Cells["LastPurchaseDate"].Value),
  //    lastPurchasePrice: Convert.ToDecimal(row.Cells["LastPurchasePrice"].Value),
  //    maxPurchasePrice: Convert.ToDecimal(row.Cells["MaxPurchasePrice"].Value),
  //    minimumPrice: Convert.ToDecimal(row.Cells["MinimumPrice"].Value),
  //    minPurchasePrice: Convert.ToDecimal(row.Cells["MinPurchasePrice"].Value),
  //    nameAr: row.Cells["NameAr"].Value.ToString(),
  //    nameEn: row.Cells["NameEn"].Value.ToString(),
  //    notUsed: Convert.ToBoolean(row.Cells["NotUsed"].Value),
  //    price: Convert.ToDecimal(row.Cells["Price"].Value),  // Make sure this column is included!
  //    qty: Convert.ToInt32(row.Cells["Qty"].Value),
  //    quickItem: Convert.ToBoolean(row.Cells["quickitem"].Value),
  //    itemTypeID: Convert.ToInt32(row.Cells["ItemTypeId"].Value),
  //    useTypeID: Convert.ToInt32(row.Cells["UseTypeID"].Value),
  //    itemNote: row.Cells["ItemNote"].Value.ToString(),
  //    barcodeNo: "0303",
  //    colorID: Convert.ToInt32(row.Cells["ColorID"].Value),
  //    filePath: row.Cells["FilePath"].Value.ToString(),
  //    itemPlaceID: Convert.ToInt32(row.Cells["ItemPlaceID"].Value),
  //    itemSizeID: Convert.ToInt32(row.Cells["ItemSizeID"].Value),
  //    unitCount: Convert.ToInt32(row.Cells["UnitCount"].Value),
  //    shortName: row.Cells["ShortName"].Value.ToString(),
  //    vat: Convert.ToDecimal(row.Cells["VAT"].Value),
  //    wholesalePrice: Convert.ToDecimal(row.Cells["WholesalePrice"].Value)  // Ensure this column exists!
  //);

            // save the data to the database
            selectedItem.Insert("\"C:\\Codes\\Codes101\\Report.accde\"");

            if (selectedItem.ID == 0)
            {
                MessageBox.Show("Item saved successfully");
            }
            else
            {
                MessageBox.Show("Item updated successfully");
            }

        }

        private void ItemList_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
