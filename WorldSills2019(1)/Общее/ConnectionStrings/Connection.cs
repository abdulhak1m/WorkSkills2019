using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSills2019_1_.Общее.ConnectionStrings
{
    public class Connection
    {
        public static string GetString()
        {
            return @"Data Source=DESKTOP-57F7258;Initial Catalog=my_maraphone;Integrated Security=True";
        } 
    }
}
