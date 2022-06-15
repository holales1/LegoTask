using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Models.Models;

namespace LegoForm.Database
{
    public class DatabaseLego
    {
        private SqliteConnection _connection;
        public DatabaseLego()
        {

            var connectionStringBuilder = new SqliteConnectionStringBuilder();

            connectionStringBuilder.Mode = SqliteOpenMode.ReadWriteCreate;

            connectionStringBuilder.DataSource = "./LegoDB.db";


            _connection = new SqliteConnection(connectionStringBuilder.ConnectionString);

            _connection.Open();
        }

        private void Execute(string sql)
        {
            var cmd = _connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public List<Vendor> GetAllVendors()
        {
            List<Vendor> vendors = new List<Vendor>();
            Vendor vendor = new Vendor();
            var selectCmd = _connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM Vendors";

            using (var reader = selectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    vendor.ID = reader.GetInt32(0);
                    vendor.Name = reader.GetString(1);
                    vendor.PostalCode = reader.GetInt32(2);
                    vendor.Address = reader.GetString(3);
                    vendor.ECOFriendly = Convert.ToBoolean(reader.GetInt32(4));

                    vendors.Add(vendor);
                }
            }
            return vendors;
        }

        public List<Material> GetAllMaterials()
        {
            List<Material> materials = new List<Material>();
            Material material = new Material();
            var selectCmd = _connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM Materials";

            using (var reader = selectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    material.ID = reader.GetInt32(0);
                    material.Name = reader.GetString(1);
                    material.Color = reader.GetString(2);
                    material.PricePerUnit = reader.GetInt32(3);
                    material.Currency = reader.GetString(4);
                    material.Unit = reader.GetString(5);
                    material.MeltingPoint = reader.GetInt32(6);
                    material.TempUnit = reader.GetString(7);
                    material.DeliveryTimeDays = reader.GetInt32(8);
                    material.VendorID = reader.GetInt32(9);

                    materials.Add(material);
                }
            }
            return materials;
        }
    }
}
