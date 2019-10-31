using System;
using System.Collections.Generic;
using System.Text;

namespace vr_db_interaction
{
    class main
    {
        static void Main(string[] args)
        {
            DBConnection currDBConnection = new DBConnection();
            currDBConnection.printYeet();
            currDBConnection.open();
        }
    }
}
