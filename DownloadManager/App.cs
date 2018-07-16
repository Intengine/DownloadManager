using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DownloadManager
{
    static class App
    {
        static Database database;

        public static Database DB()
        {
            get {
                if (database == null)
                    database = new Database();
                return database;
            }
        }
    }
}