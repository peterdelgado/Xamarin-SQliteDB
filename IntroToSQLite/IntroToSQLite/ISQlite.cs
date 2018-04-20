using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace IntroToSQLite
{
    interface ISQlite
    {
        
        SQLiteAsyncConnection GetConnection();


    }

    public class SQLiteAsyncConnection
    {
        public SQLiteAsyncConnection(string path)
        {
        }
    }
}
