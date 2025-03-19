using CodeSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace CodeSystem
{
    public class Item
    {
        // Properties of the Item
        public int ID { get; set; }
        public int ItemGroupID { get; set; }
        public decimal CostPrice { get; set; }
        public DateTime LastPurchaseDate { get; set; }
        public decimal? LastPurchasePrice { get; set; }
        public decimal? MaxPurchasePrice { get; set; }
        public decimal MinimumPrice { get; set; }
        public decimal? MinPurchasePrice { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public bool NotUsed { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public bool QuickItem { get; set; }
        public string ShortName { get; set; }
        public decimal VAT { get; set; }
        public decimal WholesalePrice { get; set; }

        // New properties for tblItemGroup and tblItemOtherData
        public int ItemTypeID { get; set; }
        public int UseTypeID { get; set; }
        public string ItemNote { get; set; }
        public string BarcodeNo { get; set; }
        public int? ColorID { get; set; }
        public string FilePath { get; set; }
        public int? ItemPlaceID { get; set; }
        public int? ItemSizeID { get; set; }
        public int UnitCount { get; set; }

        public static DataTable GetDataFromTable(string databaseTableName)
        {
            UserRepository repo = new UserRepository();
            List<string> tables = repo.GetTables();
            DataTable table = repo.GetTableData(databaseTableName); // tblItemOtherData , tblItemOtherData1 , tblItemSize , tblItemType , tblItemPlace

            return table;
        }


        // Constructor to initialize the Item object
        public Item(int id, int itemGroupID, decimal costPrice, DateTime lastPurchaseDate, decimal? lastPurchasePrice,
                    decimal? maxPurchasePrice, decimal minimumPrice, decimal? minPurchasePrice, string nameAr,
                    string nameEn, bool notUsed, decimal price, int qty, bool quickItem, string shortName,
                    decimal vat, decimal wholesalePrice, int itemTypeID, int useTypeID, string itemNote,
                    string barcodeNo, int? colorID, string filePath, int? itemPlaceID, int? itemSizeID, int unitCount)
        {
            ID = id;
            ItemGroupID = itemGroupID;
            CostPrice = costPrice;
            LastPurchaseDate = lastPurchaseDate;
            LastPurchasePrice = lastPurchasePrice ;
            MaxPurchasePrice = maxPurchasePrice;
            MinimumPrice = minimumPrice;
            MinPurchasePrice = minPurchasePrice;
            NameAr = nameAr;
            NameEn = nameEn;
            NotUsed = notUsed;
            Price = price;
            Qty = qty;
            QuickItem = quickItem;
            ShortName = shortName;
            VAT = vat;
            WholesalePrice = wholesalePrice;
            ItemTypeID = itemTypeID;
            UseTypeID = useTypeID;
            ItemNote = itemNote;
            BarcodeNo = barcodeNo;
            ColorID = colorID;
            FilePath = filePath;
            ItemPlaceID = itemPlaceID;
            ItemSizeID = itemSizeID;
            UnitCount = unitCount;
        }

        // Insert method to save the Item object into the database
        public bool Insert(string databasePath)
        {
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};Persist Security Info=False;";

            // Queries for tblItem1, tblItemGroup, and tblItemOtherData
            string itemQuery = @"INSERT INTO tblItem1 (CostPrice, ID, ItemGroupID, LastPurchaseDate, LastPurchasePrice, 
                                 MaxPurchasePrice, MinimumPrice, MinPurchasePrice, NameAr, NameEn, NotUsed, Price, 
                                 Qty, QuickItem, ShortName, VAT, WholesalePrice) 
                                 VALUES (@CostPrice, @ID, @ItemGroupID, @LastPurchaseDate, @LastPurchasePrice, 
                                 @MaxPurchasePrice, @MinimumPrice, @MinPurchasePrice, @NameAr, @NameEn, @NotUsed, @Price, 
                                 @Qty, @QuickItem, @ShortName, @VAT, @WholesalePrice)";

            string itemGroupQuery = @"INSERT INTO tblItemGroup (ID, ItemTypeID, NameAr, NameEn, NotUsed, ShortName, VAT, FilePath, ItemNote, UseTypeID) 
                                      VALUES (@ItemGroupID, @ItemTypeID, @NameAr, @NameEn, @NotUsed, @ShortName, @VAT , @FilePath, @ItemNote, @UseTypeID)";

            string itemOtherDataQuery = @"UPDATE tblItemOtherData
                                      SET BarcodeNo = @BarcodeNo, 
                                          ColorID = @ColorID, 
                                          FilePath = @FilePath, 
                                          ItemGroupID = @ItemGroupID, 
                                          ItemNote = @ItemNote, 
                                          ItemPlaceID = @ItemPlaceID, 
                                          ItemSizeID = @ItemSizeID, 
                                          ItemTypeID = @ItemTypeID, 
                                          UnitCount = @UnitCount, 
                                          UseTypeID = @UseTypeID
                                      WHERE ItemID = @ItemID";


            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();


                    
                    // Insert into tblItemGroup
                    using (OleDbCommand itemGroupCommand = new OleDbCommand(itemGroupQuery, connection))
                    {
                        itemGroupCommand.Parameters.AddWithValue("@ID", ID);
                        itemGroupCommand.Parameters.AddWithValue("@ItemTypeID", ItemTypeID);
                        itemGroupCommand.Parameters.AddWithValue("@NameAr", NameAr);
                        itemGroupCommand.Parameters.AddWithValue("@NameEn", NameEn);
                        itemGroupCommand.Parameters.AddWithValue("@NotUsed", NotUsed);
                        itemGroupCommand.Parameters.AddWithValue("@ShortName", ShortName);
                        itemGroupCommand.Parameters.AddWithValue("@VAT", VAT);
                        itemGroupCommand.Parameters.Add(new OleDbParameter("@FilePath", OleDbType.VarChar)).Value = string.IsNullOrEmpty(FilePath) ? (object)DBNull.Value : FilePath;
                        itemGroupCommand.Parameters.Add(new OleDbParameter("@ItemNote", OleDbType.VarChar)).Value = string.IsNullOrEmpty(ItemNote) ? (object)DBNull.Value : ItemNote;
                        itemGroupCommand.Parameters.Add(new OleDbParameter("@UseTypeID", OleDbType.TinyInt)).Value = UseTypeID;

                        itemGroupCommand.ExecuteNonQuery();
                    }

                    // Insert into tblItem1
                    using (OleDbCommand itemCommand = new OleDbCommand(itemQuery, connection))
                    {
                        itemCommand.Parameters.AddWithValue("@CostPrice", Price * VAT);
                        itemCommand.Parameters.AddWithValue("@ID", ID);
                        itemCommand.Parameters.AddWithValue("@ItemGroupID", ID);
                        itemCommand.Parameters.AddWithValue("@LastPurchaseDate", LastPurchaseDate);
                        itemCommand.Parameters.AddWithValue("@LastPurchasePrice", LastPurchasePrice);
                        itemCommand.Parameters.AddWithValue("@MaxPurchasePrice", MaxPurchasePrice);
                        itemCommand.Parameters.AddWithValue("@MinimumPrice", MinimumPrice);
                        itemCommand.Parameters.AddWithValue("@MinPurchasePrice", MinPurchasePrice);
                        itemCommand.Parameters.AddWithValue("@NameAr", NameAr);
                        itemCommand.Parameters.AddWithValue("@NameEn", NameEn);
                        itemCommand.Parameters.AddWithValue("@NotUsed", NotUsed);
                        itemCommand.Parameters.AddWithValue("@Price", Price);
                        itemCommand.Parameters.AddWithValue("@Qty", Qty);
                        itemCommand.Parameters.AddWithValue("@QuickItem", QuickItem);
                        itemCommand.Parameters.AddWithValue("@ShortName", ShortName);
                        itemCommand.Parameters.AddWithValue("@VAT", VAT);
                        itemCommand.Parameters.AddWithValue("@WholesalePrice", WholesalePrice);

                        itemCommand.ExecuteNonQuery();
                    }

                    // TODO: IT should be tblItemGroup not tblItemOtherData. move all the columns from here to the tblItemGroup.
                    // Insert into tblItemOtherData
                    using (OleDbCommand itemOtherDataCommand = new OleDbCommand(itemOtherDataQuery, connection))
                    {

                        //// Define sample data for testing
                        string BarcodeNo3 = "655";
                        byte? ColorID3 = 1;
                        string FilePath3 = @"C:\example\path\file.txt";
                        string ItemNote3 = "This is a test note.";
                        short? ItemPlaceID3 = 1; // Nullable
                        byte? ItemSizeID3 = 1; // Nullable
                        short ItemTypeID3 = 1;
                        float UnitCount3 = 5.5f;
                        byte? UseTypeID3 = 1; // Nullable

                        itemOtherDataCommand.Parameters.AddWithValue("@BarcodeNo", BarcodeNo);
                        itemOtherDataCommand.Parameters.AddWithValue("@ColorID", ColorID3);
                        itemOtherDataCommand.Parameters.AddWithValue("@FilePath", FilePath3);
                        itemOtherDataCommand.Parameters.AddWithValue("@ItemGroupID", ID);
                        itemOtherDataCommand.Parameters.AddWithValue("@ItemID", ID);
                        itemOtherDataCommand.Parameters.AddWithValue("@ItemNote", ItemNote);
                        itemOtherDataCommand.Parameters.AddWithValue("@ItemPlaceID", ItemPlaceID3);
                        itemOtherDataCommand.Parameters.AddWithValue("@ItemSizeID", ItemSizeID3);
                        itemOtherDataCommand.Parameters.AddWithValue("@ItemTypeID", ItemTypeID3);
                        itemOtherDataCommand.Parameters.AddWithValue("@UnitCount", UnitCount3);
                        itemOtherDataCommand.Parameters.AddWithValue("@UseTypeID", UseTypeID3);

                        // print the values with the variable name
                        /*
                        
                        BarcodeNo
                        ColorID
                        FilePath
                        ItemGroupID
                        ItemID
                        ItemNote
                        ItemPlaceID
                        ItemSizeID
                        ItemTypeID
                        UnitCount
                        UseTypeID
                         */
                        Console.WriteLine("BarcodeNo: " + BarcodeNo3);
                        Console.WriteLine("ColorID: " + ColorID3);
                        Console.WriteLine("FilePath: " + FilePath3);
                        Console.WriteLine("ItemGroupID: " + ItemGroupID);
                        Console.WriteLine("ItemID: " + ID);
                        Console.WriteLine("ItemNote: " + ItemNote3);
                        Console.WriteLine("ItemPlaceID: " + ItemPlaceID3);
                        Console.WriteLine("ItemSizeID: " + ItemSizeID3);
                        Console.WriteLine("ItemTypeID: " + ItemTypeID3);
                        Console.WriteLine("UnitCount: " + UnitCount3);
                        Console.WriteLine("UseTypeID: " + UseTypeID3);



                        itemOtherDataCommand.ExecuteNonQuery();
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex);

                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("An error occurred: " + ex.InnerException);

                return false;
            }
        }

    }
}
