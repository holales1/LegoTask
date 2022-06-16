using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Models.Models;

namespace LegoExerciseForm.Database
{
    public class DatabaseLego
    {
        private SqliteConnection _connection;
        public DatabaseLego()
        {

            var connectionStringBuilder = new SqliteConnectionStringBuilder();

            connectionStringBuilder.Mode = SqliteOpenMode.ReadWriteCreate;

            connectionStringBuilder.DataSource = "../../../../LegoDB.db";


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
            
            var selectCmd = _connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM Vendors";

            using (var reader = selectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Vendor vendor = new Vendor();
                    vendor.ID = reader.GetInt32(0);
                    vendor.Name = reader.GetString(1);
                    vendor.PostalCode = reader.GetInt32(2);
                    vendor.Address = reader.GetString(3);
                    vendor.ContactPerson = reader.GetString(4);
                    vendor.ECOFriendly = Convert.ToBoolean(reader.GetInt32(5));

                    vendors.Add(vendor);
                }
            }
            return vendors;
        }

        public List<Material> GetAllMaterials()
        {
            List<Material> materials = new List<Material>();
            
            var selectCmd = _connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM Materials";

            using (var reader = selectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Material material = new Material();
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

        public List<VendorDeliveryDays> GetCheapestMaterial()
        {
            List<VendorDeliveryDays> vendorDeliveryDays = new List<VendorDeliveryDays>();

            var selectCmd = _connection.CreateCommand();
            selectCmd.CommandText = "SELECT Vendors.*, Materials.name, min(Materials.pricePerUnit), Materials.deliveryTimeDays " +
                "from Materials left join Vendors on Materials.vendorId=Vendors.id GROUP by Materials.name;";

            using (var reader = selectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    VendorDeliveryDays vendorDelivery = new VendorDeliveryDays();
                    vendorDelivery.ID = reader.GetInt32(0);
                    vendorDelivery.Name = reader.GetString(1);
                    vendorDelivery.PostalCode = reader.GetInt32(2);
                    vendorDelivery.Address = reader.GetString(3);
                    vendorDelivery.ContactPerson = reader.GetString(4);
                    vendorDelivery.ECOFriendly = Convert.ToBoolean(reader.GetInt32(5));
                    vendorDelivery.MaterialName = reader.GetString(6);
                    vendorDelivery.MaterialPrice = reader.GetInt32(7);
                    vendorDelivery.DeliveryTimeDays = reader.GetInt32(8);

                    vendorDeliveryDays.Add(vendorDelivery);
                }
            }
            return vendorDeliveryDays;
        }

        public List<MaterialEco> FindBestOption()
        {
            List<MaterialEco> materials = new List<MaterialEco>();

            var selectCmd = _connection.CreateCommand();
            selectCmd.CommandText = "SELECT Materials.*, Vendors.ECOFriendly from Materials left join Vendors on Materials.vendorId=Vendors.id " +
                "WHERE Materials.name = \"Polymethyl Methacrylate (PMMA)\" AND Materials.meltingPoint BETWEEN 200 and 300 ORDER by Materials.pricePerUnit; ";

            using (var reader = selectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    MaterialEco material = new MaterialEco();
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
                    material.ECOFriendly = Convert.ToBoolean(reader.GetInt32(10));

                    materials.Add(material);
                }
            }
            return materials;
        }
    }
}
