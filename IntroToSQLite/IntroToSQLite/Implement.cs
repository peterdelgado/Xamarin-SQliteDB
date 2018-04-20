using System;
using SQLite;
using System.IO;
using Xamarin.Forms;
using IntroToSQLite;

[assembly: Dependency(typeof(SQLiteDb))]

namespace IntroToSQLite
{
    public class SQLiteDb : ISQlite
    {
        public IntroToSQLite.SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }




}