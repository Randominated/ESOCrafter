using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ESOCrafter
{
    /// <summary>
    /// Non-GUI code for ESOCrafter, including database I/O logic for SQLite.
    /// </summary>
    class Logic
    {
        public string DBFileLocation { get; private set; }
        private SQLiteConnection DBConnection;

        public Logic()
        {
            Console.WriteLine("Logic initiated"); //Debug
            //TODO load metadata file. Meta file contains path(s) to database files.
        }

        private int CreateDBFile(string path, string filename)
        {
            //TODO let user select whether to create database file or keep it in memory?
            //TODO unsure what variables can be gotten from new file dialog. Adapt accordingly!
            return -1;
        }

        private void initDBConnection(string file)
        {
            //TODO BAD PRACTICE DO
            DBConnection = new SQLiteConnection("data source=" + file);
            //TODO check where to call this method. Must be after successful load of metadata.
            //TODO SQLiteConnection constructor sets up several things. Check conditions, maybe load from metadata.
        }


        public string TEMPCreateDB()
        {
            //TODO needs total refactor, this revision is only for testing segmentation of the SQLite example used to learn from.
            //TODO: This string is supposed to load from a packaged SQL file. Packaged/zipped to make sure that the SQL corresponds to the .db3 file. Package includes .meta file.
            string createTableQuery = @"-- tables
                                        -- Table: characters
                                        CREATE TABLE characters (
                                            char_id integer NOT NULL  PRIMARY KEY AUTOINCREMENT,
                                            char_type integer NOT NULL,
                                            char_name varchar(255) NOT NULL,
                                            inventory_size integer NOT NULL,
                                            isMule boolean NOT NULL,
                                            isBank boolean NOT NULL
                                        );
                                        -- Table: equips
                                        CREATE TABLE equips (
                                            equip_id integer NOT NULL  PRIMARY KEY AUTOINCREMENT,
                                            type varchar(255) NOT NULL,
                                            attribute_val integer NOT NULL,
                                            item_level integer NOT NULL,
                                            coin_val integer NOT NULL,
                                            ench_type varchar(255) NOT NULL,
                                            ench_val integer NOT NULL,
                                            trait_type varchar(255) NOT NULL,
                                            trait_val integer NOT NULL,
                                            characters_char_id integer NOT NULL,
                                            FOREIGN KEY (characters_char_id) REFERENCES characters (char_id)
                                        );
                                        -- Table: researches
                                        CREATE TABLE researches (
                                            res_id integer NOT NULL  PRIMARY KEY AUTOINCREMENT,
                                            trait varchar(255) NOT NULL,
                                            bench_type integer NOT NULL,
                                            time_start datetime NOT NULL,
                                            time_end datetime NOT NULL,
                                            init_equip_id integer NOT NULL,
                                            characters_char_id integer NOT NULL,
                                            FOREIGN KEY (characters_char_id) REFERENCES characters (char_id)
                                        );
                                        -- views
                                        -- View: v_char_inventory
                                        CREATE VIEW v_char_inventory AS
                                        SELECT * FROM equips;
                                        -- End of file.";

            DBFileLocation = "testDB.db3";
            initDBConnection(DBFileLocation);
            using (DBConnection) {

            }

            return "";
        }

        public string SQLiteTest()
        {
            string popupContents = "";
            // This is the query which will create a new table in our database file with three columns.
            // An auto increment column called "ID", and two NVARCHAR type columns with the names "Key" and "Value"
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS [MyTable] (
                                      [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                      [Key] NVARCHAR(2048)  NULL,
                                      [Value] VARCHAR(2048)  NULL
                                      )";

            // Create the file which will be hosting our database
            //System.Data.SQLite.SQLiteConnection.CreateFile("databaseFile.db3");
            using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection("data source=databaseFile.db3"))
            {
                using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                {
                    con.Open();                             // Open the connection to the database
 
                    com.CommandText = createTableQuery;     // Set CommandText to our query that will create the table
                    com.ExecuteNonQuery();                  // Execute the query

                    // Add the first entry into our database 
                    com.CommandText = "INSERT INTO MyTable (Key,Value) Values ('key one','value one')";
                    // Execute the query
                    com.ExecuteNonQuery();
                    // Add another entry into our database
                    com.CommandText = "INSERT INTO MyTable (Key,Value) Values ('key two','value value')";
                    // Execute the query
                    com.ExecuteNonQuery();

                    // Select all rows from our database table
                    com.CommandText = "Select * FROM MyTable";      
 
                    using (System.Data.SQLite.SQLiteDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Display the value of the key and value column for every row
                            Console.WriteLine(reader["ID"] + " - " + reader["Key"] + " : " + reader["Value"]);
                            popupContents = popupContents + reader["ID"] + " - " + reader["Key"] + " : " + reader["Value"] + "\n";
                        }
                    }
                    // Close the connection to the database
                    con.Close();
                }
            }
            return popupContents;
        }

        private void CheckDBFileCompatibility()
        {
            //TODO needs a way to check loaded db3 file for compatibility with get methods. If incompatible block only reads until tables are made?
        }

        public void ClrDb()
        {
            System.Data.SQLite.SQLiteConnection.CreateFile("databaseFile.db3");
            //TODO rewrite, silent newfile is asshole move. New file or delete button?
        }

        public string Eq_test()
        {
            //testing internal methods for Equippable class. Only debug use. Cleanup after.
            Equippable e = new Equippable("dagger", 1337, 666, 9999, "Murder damage", 9000, "Perfect", 7, 0);
            return "" + e;
        }
    }
}
