using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AgendaTelefonica.Data
{
   public class Constants
    {
        public const string DatabaseFilename = "ContactSQLite.db3";



        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }
}
