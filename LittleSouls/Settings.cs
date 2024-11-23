using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleSouls
{
    internal static class Settings
    {
        public static string ConnctionString = @"Server=FMSI\SQLEXPRESS;Database=littleSouls;Trusted_Connection=True;";

        private static string nameOfDataSource = @"FMSI\SQLEXPRESS";

        public static string ConnctionStringForEntity = $"metadata=res://*/LSDB.csdl|res://*/LSDB.ssdl|res://*/LSDB.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=FMSI\\SQLEXPRESS;initial catalog=littleSouls;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";
    }
}
