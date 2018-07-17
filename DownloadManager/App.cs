namespace DownloadManager
{
    static class App
    {
        static Database database;

        public static Database DB
        {
            get
            {
                if (database == null)
                    database = new Database();
                return database;
            }
        }
    }
}