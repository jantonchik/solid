using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    internal class SqlConnectionManager : IConnectionManager
    {
        private readonly string connectionString;
        private DbConnection dbConnection;

        public SqlConnectionManager(string connectionString)
        {
            this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public void Close()
        {
            if (this.dbConnection is null)
            {
                throw new ArgumentNullException("Create connection before close");
            }

            this.dbConnection.Close();
        }

        public void CreateConnection()
        {
            if (this.dbConnection is null)
            {
                this.dbConnection = new SqlConnection(this.connectionString);
            }
        }

        public async Task OpenAsync()
        {
            if(this.dbConnection is null)
            {
                throw new ArgumentNullException("Create connection before open");
            }

            await this.dbConnection.OpenAsync();
        }
    }
}
