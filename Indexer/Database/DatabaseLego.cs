using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Models.Models;

namespace Indexer.Database
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

            Execute("DROP TABLE IF EXISTS Materials");

            Execute("DROP TABLE IF EXISTS Vendors");

            
            Execute("CREATE TABLE Vendors(id INTEGER PRIMARY KEY, name VARCHAR(30), postalCode INTEGER, address VARCHAR(50), contactPerson VARCHAR(50),ECOFriendly INTEGER)");

            Execute("CREATE TABLE Materials(id INTEGER, name VARCHAR(50), color VARCHAR(50), pricePerUnit INTEGER, currency VARCHAR(50), unit VARCHAR(50), meltingPoint Integer, tempUnit VARCHAR(50), deliveryTimeDays Integer, vendorId INTEGER, "
                  + "FOREIGN KEY (vendorId) REFERENCES Vendors(id))");
        }

        private void Execute(string sql)
        {
            var cmd = _connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void InsertAllVendors(Root root)
        {
            using (var transaction = _connection.BeginTransaction())
            {
                var command = _connection.CreateCommand();
                command.CommandText =
                @"INSERT INTO Vendors(id, name, postalCode, address, contactPerson,ECOFriendly) VALUES(@id,@name,@postalCode,@address,@contactPerson,@ECOFriendly)";

                var paramECOFriendly = command.CreateParameter();
                paramECOFriendly.ParameterName = "ECOFriendly";
                command.Parameters.Add(paramECOFriendly);

                var paramContact = command.CreateParameter();
                paramContact.ParameterName = "contactPerson";
                command.Parameters.Add(paramContact);

                var paramAddress = command.CreateParameter();
                paramAddress.ParameterName = "address";
                command.Parameters.Add(paramAddress);

                var paramPostalCode = command.CreateParameter();
                paramPostalCode.ParameterName = "postalCode";
                command.Parameters.Add(paramPostalCode);

                var paramName = command.CreateParameter();
                paramName.ParameterName = "name";
                command.Parameters.Add(paramName);

                var paramId = command.CreateParameter();
                paramId.ParameterName = "id";
                command.Parameters.Add(paramId);

                // Insert all entries

                foreach (var p in root.Vendors)
                {
                    paramECOFriendly.Value = p.ECOFriendly;
                    paramContact.Value = p.ContactPerson;
                    paramAddress.Value = p.Address;
                    paramPostalCode.Value = p.PostalCode;
                    paramName.Value = p.Name;
                    paramId.Value = p.ID;
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
            }
        }

        internal void InsertAllMaterials(Root root)
        {
            using (var transaction = _connection.BeginTransaction())
            {
                var command = _connection.CreateCommand();
                command.CommandText =
                @"INSERT INTO Materials(id, name, color, pricePerUnit, currency, unit, meltingPoint, tempUnit, deliveryTimeDays, vendorId) VALUES(@id, @name, @color, @pricePerUnit, @currency, @unit, @meltingPoint, @tempUnit, @deliveryTimeDays, @vendorId)";

                var paramVendorId = command.CreateParameter();
                paramVendorId.ParameterName = "vendorId";
                command.Parameters.Add(paramVendorId);

                var paramDelivery = command.CreateParameter();
                paramDelivery.ParameterName = "deliveryTimeDays";
                command.Parameters.Add(paramDelivery);

                var paramTempUnit = command.CreateParameter();
                paramTempUnit.ParameterName = "tempUnit";
                command.Parameters.Add(paramTempUnit);

                var paramMeltingPoint = command.CreateParameter();
                paramMeltingPoint.ParameterName = "meltingPoint";
                command.Parameters.Add(paramMeltingPoint);

                var paramUnit = command.CreateParameter();
                paramUnit.ParameterName = "unit";
                command.Parameters.Add(paramUnit);

                var paramCurrency = command.CreateParameter();
                paramCurrency.ParameterName = "currency";
                command.Parameters.Add(paramCurrency);

                var paramPrice = command.CreateParameter();
                paramPrice.ParameterName = "pricePerUnit";
                command.Parameters.Add(paramPrice);

                var paramColor = command.CreateParameter();
                paramColor.ParameterName = "color";
                command.Parameters.Add(paramColor);

                var paramName = command.CreateParameter();
                paramName.ParameterName = "name";
                command.Parameters.Add(paramName);

                var paramId = command.CreateParameter();
                paramId.ParameterName = "id";
                command.Parameters.Add(paramId);

                foreach (var p in root.Materials)
                {
                    paramVendorId.Value = p.VendorID;
                    paramDelivery.Value = p.DeliveryTimeDays;
                    paramTempUnit.Value = p.TempUnit;
                    paramMeltingPoint.Value = p.MeltingPoint;
                    paramUnit.Value = p.Unit;
                    paramCurrency.Value = p.Currency;
                    paramPrice.Value = p.PricePerUnit;
                    paramColor.Value = p.Color;
                    paramName.Value = p.Name;
                    paramId.Value = p.ID;

                    command.ExecuteNonQuery();
                }

                transaction.Commit();
            }
        }
    }
}
