using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLite.Net.Attributes;

namespace IntroToSQLite
{
    class Columns
    {

        public class Test
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            [MaxLength(255)]
            public string Title { get; set; }

            [MaxLength(1000)]
            public string Desc { get; set; }
        }


    }
}
