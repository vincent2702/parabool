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
        private string port;
        public Lijst lijst = new Lijst();
        public Lijst lijst2 = new Lijst();
        public Lijst teams_bier = new Lijst();
        public Lijst Names = new Lijst();
        public streeplijst_library.PriceList price = new PriceList();
        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            port = "3306";
            database = "parabool";
            uid = "root";
            password = "admin";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + port+ ";" + "DATABASE=" +
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
            string query = $"SELECT * FROM nameslist INNER JOIN streeplijst ON nameslist.id = streeplijst.id" +
                           $" INNER JOIN streeplijst_total ON nameslist.id = streeplijst_total.id" +
                           $"  WHERE FirstName LIKE '{name}%'";
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
                    var AA = Int32.Parse(dataReader["AA"] + "");
                    var Bier2 = Int32.Parse(dataReader["Bier2"] + "");
                    var Fris2 = Int32.Parse(dataReader["Fris2"] + "");
                    var Wijn2 = Int32.Parse(dataReader["Wijn2"] + "");
                    var Snoep2 = Int32.Parse(dataReader["Snoep2"] + "");
                    var AA2 = Int32.Parse(dataReader["AA"] + "");

                    lijst.Items.Add(new Item { ItemCountTotalBier = Bier, ItemCountTotalFris = Fris, ItemCountTotalWijn = Wijn, ItemCountTotalSnoep = Snoep, ItemCountTotalAA = AA, Id = id,
                                                ItemCountTotalBier2 = Bier2, ItemCountTotalFris2 = Fris2, ItemCountTotalSnoep2 = Snoep2, ItemCountTotalWijn2 = Wijn2, ItemCountTotalAA2 = AA2});
                    lijst.Leden.Add(new Lid { Firstname = Firstname + "", Lastname = Lastname, Number = id, Items = lijst.Items[i] });
                    i++;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
                lijst.Leden.Sort((x, y) => y.Items.ItemCountTotalBier2.CompareTo(x.Items.ItemCountTotalBier2));
            }
        }

        public void nameslist()
        {
            string query = $"SELECT * FROM parabool.nameslist;";
            Names.Leden.Clear();


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
                    var id = dataReader["id"] + "";

                    Names.Leden.Add(new Lid { Firstname = Firstname + "", Lastname = Lastname, Number = Convert.ToInt16(id) });

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string tabel, int bier, int fris, int wijn, int snoep, int AA, int id)
        {
            if (tabel == "streeplijst")
            {
                string query = $"UPDATE {tabel} SET Bier={bier}, Fris={fris}, Wijn={wijn}, Snoep={snoep}, AA={AA} WHERE id={id}";
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
            else if (tabel == "streeplijst_total")
            {
                var query = $"UPDATE {tabel} SET Bier2={bier}, Fris2={fris}, Wijn2={wijn}, Snoep2={snoep}, AA2={AA} WHERE id={id}";
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
        }
        public void Update(string tabel,int id, int team, int Commissie)
        {
            MySqlCommand cmd = new MySqlCommand();
           
                var query = $"UPDATE {tabel} SET teams_idteams = {team}, commisie_id = {Commissie}  WHERE nameslist_id={id}";
                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    //MySqlCommand cmd = new MySqlCommand();
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
            string query = $"SELECT FirstName, LastName, Bier2, teams_idteams, commisie_id FROM parabool.nameslist " +
                           $"INNER JOIN parabool.streeplijst_total ON parabool.nameslist.id = parabool.streeplijst_total.id " +
                           $"INNER JOIN parabool.teams_has_nameslist ON parabool.nameslist.id = parabool.teams_has_nameslist.nameslist_id;";
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
                    var Bier = Int32.Parse(dataReader["Bier2"] + "");
                    var Team = dataReader["teams_idteams"] + "";
                    var Commissie = dataReader["commisie_id"] + "";

                    lijst2.Items.Add(new Item { ItemCountTotalBier2 = Bier });
                    lijst2.Leden.Add(new Lid { Firstname = Firstname + "", Lastname = Lastname, Items = lijst2.Items[i], Team = Team , Commissies = Commissie});
                    i++;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
                lijst2.Leden.Sort((x, y) => y.Items.ItemCountTotalBier2.CompareTo(x.Items.ItemCountTotalBier2));
            }
        }

        public void addPerson(string firstName, string lastName)
        {
            string query = $"INSERT INTO parabool.nameslist (FirstName, LastName) values ('{firstName}', '{lastName}'); ;";
            
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();
                
            }
        }

        public void addStreeplijstData(string firstName, int team, int commisie)
        {
            string query = $"select id FROM nameslist WHERE FirstName = '{firstName}' ;";
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                var id = "";
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                   id = dataReader["id"] + "";
                }
                //close Data Reader
                dataReader.Close();

                query = $"INSERT INTO streeplijst (Bier, Fris, Wijn, Snoep, AA, id) values (0,0,0,0,0,{id});";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"INSERT INTO streeplijst_total (Bier2, Fris2, Wijn2, Snoep2, AA2, id) values (0,0,0,0,0,{id});";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"INSERT INTO parabool.teams_has_nameslist (teams_idteams, nameslist_id, commisie_id) values ({team}, {id}, {commisie});";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }
            
        }

        public void priceList()
        {
            string query = $"SELECT * FROM parabool.price;";
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
                    var bier_price = dataReader["Bier_price"] + "";
                    var fris_price = dataReader["Fris_price"] + "";
                    var wijn_price = Int32.Parse(dataReader["Wijn_price"] + "");
                    var snoep_price = dataReader["Snoep_price"] + "";
                    var aa_price = dataReader["AA_price"] + "";
                    //var Team = dataReader["teams_name" + ""];
                    price.AA_price = Convert.ToDouble(aa_price);
                    price.Snoep_price = Convert.ToDouble(snoep_price);
                    price.Wijn_price = Convert.ToDouble(wijn_price);
                    price.Fris_price = Convert.ToDouble(fris_price);
                    price.Bier_price = Convert.ToDouble(bier_price);
                    i++;
                }
                
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
        }

        public void UpdatePriceList(Double bier, Double fris, Double wijn, Double snoep, Double AA)
        {
            string query = $"UPDATE price SET Bier_price={bier}, Fris_price={fris}, Wijn_price={wijn}, Snoep_price={snoep}, AA_price={AA}";
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

        public void DeletPerson(String firstName, String lastName)
        {
            string query = $"select id FROM nameslist WHERE FirstName = '{firstName}' AND Lastname = '{lastName}' ;";
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                var id = "";
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    id = dataReader["id"] + "";
                }
                //close Data Reader
                dataReader.Close();
                
                query = $"DELETE FROM parabool.streeplijst WHERE id = {id};";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"DELETE FROM parabool.streeplijst_total WHERE id = {id};";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"DELETE FROM parabool.teams_has_nameslist WHERE nameslist_id = {id};";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"DELETE FROM parabool.nameslist WHERE id = {id};";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }

        }

        public void addBietToTeams(int bier_total, int Team, String tabel, String Collum)
        {
            string query = $"Update {tabel} SET Bier_count = {bier_total} WHERE {Collum} = {Team};";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }
        }

        public void topTeams()
        {
            string query = $"select * FROM parabool.teams;";
            teams_bier.Teams.Clear();
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var teams_name = dataReader["teams_name"] + "";
                    var bier_count = Int32.Parse(dataReader["Bier_count"] + "");
                    teams_bier.Teams.Add(new Teams{ Team = teams_name, Bier_count = bier_count});
                }


                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();

                teams_bier.Teams.Sort((x, y) => y.Bier_count.CompareTo(x.Bier_count));

            }
        }

        public void topCommissies()
        {
            string query = $"select * FROM parabool.commissies;";
            teams_bier.Teams.Clear();
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var Commissie = dataReader["commisieName"] + "";
                    var bier_count = Int32.Parse(dataReader["Bier_count"] + "");
                    teams_bier.Teams.Add(new Teams { Commissie = Commissie, Bier_count = bier_count });
                }


                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();

                teams_bier.Teams.Sort((x, y) => y.Bier_count.CompareTo(x.Bier_count));

            }
        }

        public void UpdateStock(int bier, int fris, int snoep, int wijn, int AA)
        {
            string query = $"UPDATE stock SET Bier_Sold = Bier_Sold +{bier}, Fris_Sold = Fris_Sold+{fris}, Snoep_Sold = Snoep_Sold +{snoep}, Wijn_Sold = Wijn_Sold+{wijn}, AA_Sold = AA_Sold+{AA};";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }
        }

        public String[] PersonData(String name)
        {
            String firstName = name.Substring(0, name.IndexOf(" "));
            String lastName = name.Substring(name.IndexOf(" ") + 1);
            String[] data = new String[9];
            string query = $"SELECT FirstName, LastName, nameslist.id, Bier, Fris, Wijn, Snoep, AA, Bier2, Fris2, Wijn2, Snoep2, AA2, teams_idteams, commisie_id" +
                           $" FROM nameslist INNER JOIN streeplijst ON nameslist.id = streeplijst.id " +
                           $"INNER JOIN streeplijst_total ON nameslist.id = streeplijst_total.id " +
                           $"INNER JOIN teams_has_nameslist ON nameslist.id = teams_has_nameslist.nameslist_id " +
                           $"WHERE FirstName = '{firstName}' AND LastName = '{lastName}'; ";
            teams_bier.Teams.Clear();
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var firstname = dataReader["FirstName"] + "";
                    var lasttname = dataReader["LastName"] + "";
                    var Bier = dataReader["Bier"] + "";
                    var Fris = dataReader["Fris"] + "";
                    var Wijn = dataReader["Wijn"] + "";
                    var Snoep = dataReader["Snoep"] + "";
                    var AA = dataReader["AA"] + "";
                    var Team = dataReader["teams_idteams"] + "";
                    var Commissie = dataReader["commisie_id"] + "";
                    var Id = dataReader["id"] + "";
                    var Bier2 = dataReader["Bier2"] + "";
                    var Fris2 = dataReader["Fris2"] + "";
                    var Snoep2 = dataReader["Snoep2"] + "";
                    var Wijn2 = dataReader["Wijn2"] + "";
                    var AA2 = dataReader["AA2"] + "";


                    data = new String[] {firstname, lasttname, Bier, Fris, Wijn, Snoep, AA, Team, Commissie, Id, Bier2, Fris2, Snoep2, Wijn2, AA2};

                }


                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();

            }
            return data;
        }
    }
}
