using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using streeplijst_library;

namespace streeplijst
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public Lijst lijst = new Lijst();
        public Lijst lijst2 = new Lijst();
        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "test";
            uid = "root";
            password = "admin";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //// Startup data
        //public void SelectStart()
        //{
        //    string query = "SELECT * FROM nameslist INNER JOIN streeplijst ON nameslist.id = streeplijst.id";
        //    //Create a list to store the result
        //    int i = 0;
        //    //Open connection
        //    if (this.OpenConnection() == true)
        //    {
        //        //Create Command
        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //        //Create a data reader and Execute the command
        //        MySqlDataReader dataReader = cmd.ExecuteReader();
                
        //        //Read the data and store them in the list
        //        while (dataReader.Read())
        //        {
        //            var id = Int32.Parse(dataReader["id"] + "");
        //            var Firstname = dataReader["firstname"] + "";
        //            var Lastname = dataReader["lastname"] + "";
        //            var Bier = Int32.Parse(dataReader["Bier"] + "");
        //            var Fris = Int32.Parse(dataReader["Fris"] + "");
        //            var Wijn = Int32.Parse(dataReader["Wijn"] + "");
        //            var Snoep = Int32.Parse(dataReader["Snoep"] + "");

        //            lijst.Items.Add(new Item {ItemCountBier = Bier, ItemCountFris = Fris, ItemCountWijn = Wijn, ItemCountSnoep = Snoep});
        //            lijst.Leden.Add(new Lid{ Firstname = Firstname + "", Lastname = Lastname, Number = id, Items = lijst.Items[i] });
        //            i++;
        //        }
        //        //var output = dataReader;
        //        //close Data Reader
        //        dataReader.Close();

        //        //close Connection
        //        this.CloseConnection();

        //    }
        //}

        // Search function

        public void SearchDB(string name)
        {
            string query = "SELECT * FROM nameslist INNER JOIN streeplijst ON nameslist.id = streeplijst.id WHERE FirstName LIKE '"+ name + "%'";
            lijst.Leden.Clear();
            lijst.Items.Clear();
            int i = 0;
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var id = Int32.Parse(dataReader["id"] + "");
                    var Firstname = dataReader["firstname"] + "";
                    var Lastname = dataReader["lastname"] + "";
                    var Bier = Int32.Parse(dataReader["Bier"] + "");
                    var Fris = Int32.Parse(dataReader["Fris"] + "");
                    var Wijn = Int32.Parse(dataReader["Wijn"] + "");
                    var Snoep = Int32.Parse(dataReader["Snoep"] + "");

                    lijst.Items.Add(new Item { ItemCountTotalBier = Bier, ItemCountTotalFris = Fris, ItemCountTotalWijn = Wijn, ItemCountTotalSnoep = Snoep, Id = id });
                    lijst.Leden.Add(new Lid { Firstname = Firstname + "", Lastname = Lastname, Number = id, Items = lijst.Items[i] });
                    i++;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
                lijst.Leden.Sort((x, y) => y.Items.ItemCountTotalBier.CompareTo(x.Items.ItemCountTotalBier));
            }
        }

        //Update statement
        public void Update(int bier, int fris, int wijn, int snoep, int id)
        {

            string query = "UPDATE streeplijst SET Bier="+ bier+ ", Fris=" + fris + ", Wijn=" + wijn + ", Snoep=" + snoep + " WHERE id=" + id;
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void Top10()
        {
            string query = "SELECT FirstName, LastName, Bier FROM nameslist INNER JOIN streeplijst ON nameslist.id = streeplijst.id WHERE FirstName LIKE '%' ORDER BY `Bier` DESC LIMIT 10";
            lijst2.Leden.Clear();
            lijst2.Items.Clear();
            int i = 0;
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var Firstname = dataReader["firstname"] + "";
                    var Lastname = dataReader["lastname"] + "";
                    var Bier = Int32.Parse(dataReader["Bier"] + "");

                    lijst2.Items.Add(new Item { ItemCountTotalBier = Bier });
                    lijst2.Leden.Add(new Lid { Firstname = Firstname + "", Lastname = Lastname, Items = lijst2.Items[i] });
                    i++;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
        }
    }
}
