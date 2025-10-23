using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Configuration
{
    public static class ConnectorFactory
    {
        public static IDataConnector GetConnector(string type)
        {
            return type switch
            {
                "sql" => new SqlConnector(),
                "text" => new TextConnector(),
                _ => throw new ArgumentException("Unknown connector type")
            };
        }
    }

}
