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
        public decimal LastPurchasePrice { get; set; }
        public decimal MaxPurchasePrice { get; set; }
        public decimal MinimumPrice { get; set; }
        public decimal MinPurchasePrice { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public bool NotUsed { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public bool QuickItem { get; set; }
        public string ShortName { get; set; }
        public decimal VAT { get; set; }
        public decimal WholesalePrice { get; set; }

        // Constructor to initialize the Item object
        public Item(int id, int itemGroupID, decimal costPrice, DateTime lastPurchaseDate, decimal lastPurchasePrice,
                    decimal maxPurchasePrice, decimal minimumPrice, decimal minPurchasePrice, string nameAr,
                    string nameEn, bool notUsed, decimal price, int qty, bool quickItem, string shortName,
                    decimal vat, decimal wholesalePrice)
        {
            ID = id;
            ItemGroupID = itemGroupID;
            CostPrice = costPrice;
            LastPurchaseDate = lastPurchaseDate;
            LastPurchasePrice = lastPurchasePrice;
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
        }

        // Insert method to save the Item object into the database
        public void Insert(string databasePath)
        {
            // Connection string for Access database
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};";

            // SQL Insert query
            string query = @"INSERT INTO tblItem1 (CostPrice, ID, ItemGroupID, LastPurchaseDate, LastPurchasePrice, 
                         MaxPurchasePrice, MinimumPrice, MinPurchasePrice, NameAr, NameEn, NotUsed, Price, 
                         Qty, QuickItem, ShortName, VAT, WholesalePrice) 
                         VALUES (@CostPrice, @ID, @ItemGroupID, @LastPurchaseDate, @LastPurchasePrice, 
                         @MaxPurchasePrice, @MinimumPrice, @MinPurchasePrice, @NameAr, @NameEn, @NotUsed, @Price, 
                         @Qty, @QuickItem, @ShortName, @VAT, @WholesalePrice)";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@CostPrice", CostPrice);
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@ItemGroupID", ItemGroupID);
                        command.Parameters.AddWithValue("@LastPurchaseDate", LastPurchaseDate);
                        command.Parameters.AddWithValue("@LastPurchasePrice", LastPurchasePrice);
                        command.Parameters.AddWithValue("@MaxPurchasePrice", MaxPurchasePrice);
                        command.Parameters.AddWithValue("@MinimumPrice", MinimumPrice);
                        command.Parameters.AddWithValue("@MinPurchasePrice", MinPurchasePrice);
                        command.Parameters.AddWithValue("@NameAr", NameAr);
                        command.Parameters.AddWithValue("@NameEn", NameEn);
                        command.Parameters.AddWithValue("@NotUsed", NotUsed);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@Qty", Qty);
                        command.Parameters.AddWithValue("@QuickItem", QuickItem);
                        command.Parameters.AddWithValue("@ShortName", ShortName);
                        command.Parameters.AddWithValue("@VAT", VAT);
                        command.Parameters.AddWithValue("@WholesalePrice", WholesalePrice);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

}

