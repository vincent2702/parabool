using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mysql_test
{
    class DBConnect
    {
        public Lijst lijst = new Lijst();
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

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
            password = "parabool";
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

        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

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

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        
        //Select statement
        public void SelectStart()
        {
            string query = $"SELECT * FROM nameslist INNER JOIN streeplijst ON nameslist.id = streeplijst.id WHERE FirstName LIKE '%' ORDER BY `Bier` DESC LIMIT 10;";
            lijst.people.Clear();
            //List<NameList> people = new List<NameList>();
            //Create a list to store the result

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var id = Int32.Parse(dataReader["id"] + "");
                    var Firstname = dataReader["firstname"] + "";
                    var Lastname = dataReader["lastname"] + "";
                    var bier = Int32.Parse(dataReader["Bier"] + "");
                    lijst.items.Add(new Items { Bier = bier});
                    lijst.people.Add(new NameList { firstName = Firstname + "", lastName = Lastname, ID = id, items = lijst.items[count]});
                    count++;
                }
                //var output = dataReader;
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return people;
            }

            //else
            //    {
            //    return people;
            //}
        }

        public void SearchDB(string name)
        {
            string query = $"SELECT * FROM nameslist INNER JOIN streeplijst ON nameslist.id = streeplijst.id WHERE FirstName LIKE '%' ORDER BY `Bier` DESC LIMIT 10;";
            lijst.people.Clear();

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
                    lijst.people.Add(new NameList { firstName = Firstname + "", lastName = Lastname, ID = id });

                }
                //var output = dataReader;
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

            }
        }
    }
}

