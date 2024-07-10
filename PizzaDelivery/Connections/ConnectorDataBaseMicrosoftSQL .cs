using Microsoft.Data.SqlClient;

namespace PizzaDelivery
{
    internal class ConnectorDataBaseMicrosoftSQL
    {
        private static ConnectorDataBaseMicrosoftSQL instance;
        public SqlConnection SqlConnection { get; private set; }

        private ConnectorDataBaseMicrosoftSQL()
        {
            SqlConnection = new SqlConnection("Server=localhost\\SQLEXPRESS; Database=Pizza_Delivery;" +
                                              "Integrated Security=true; TrustServerCertificate=true");
        }

        public static ConnectorDataBaseMicrosoftSQL StartConnection()
        {
            if (instance == null)
            {
                instance = new ConnectorDataBaseMicrosoftSQL();
            }

            return instance;
        }

        public static void EndConnection()
        {
            instance = null;
        }

        public static ConnectorDataBaseMicrosoftSQL GetConnection()
        {
            return instance;
        }
    }
}
