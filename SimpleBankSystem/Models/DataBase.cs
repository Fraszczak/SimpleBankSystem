using SimpleBankSystem.Views;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows;

namespace SimpleBankSystem.Models
{
    public sealed class DataBase
    {
        private static DataBase instance = null;
        private static readonly object padLock = new object();
        private static string _query;
        private static readonly string ConncectionString = SimpleBankSystem.Properties.Settings.Default.SimpleBankSystemDataBaseConnectionString;
        private static Int32 whichAccount;
        private static SqlConnection connection = null;

     

        public static DataBase Instance
        {
            get
            {
                lock (padLock)

                {
                    if (instance == null)
                        instance = new DataBase();

                    return instance;
                }
            }
        }
        /// <summary>
        /// Specifies which account should be login
        /// </summary>
        /// <param name="login", name="password">
        ///     login - user login 
        ///     password - user password
        ///     </param>
        /// <returns>
        /// void method
        /// </returns>
        public void LoginToApp(ref string login, ref string password)
        {
             _query = "SELECT * FROM dbo.LoginTable WHERE UserName=@Login  AND UserPassword=@Password";
            using (SqlConnection connection = new SqlConnection(ConncectionString))
            {
                SqlCommand localCommand = new SqlCommand(_query, connection)
                {
                    CommandType = CommandType.Text
                };
                localCommand.Parameters.AddWithValue("@Login", login);
                localCommand.Parameters.AddWithValue("@Password", password);


                // stworz liste kont, przypisz im numery i podczas logowania zrob analogicznie jak to nizej
                if (login.Equals("admin"))
                    whichAccount = 1;
                else whichAccount = 2;
            
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    
                    int count = Convert.ToInt32(localCommand.ExecuteScalar());

                    if (count == whichAccount)
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login or password is incorect");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public decimal DecimalExecuteQuery(string query)
        {
            _query = query;

            connection = new SqlConnection(ConncectionString);
            object result = null;
            decimal returnValue = 0.0M;

            using (System.Data.SqlClient.SqlCommand command = new SqlCommand(_query, connection))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    result = command.ExecuteScalar();
                    returnValue = Convert.ToDecimal(result);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return Math.Round(returnValue,2);
            }
        }
        public DataView DataViewExecuteQuery(string query)
        {
            _query = query;
            connection = new SqlConnection(ConncectionString);
            //object result = null;

            DataView dataView = null;
            SqlDataAdapter dataAdapter = null;
            DataTable dataTable = null;

            using (System.Data.SqlClient.SqlCommand command = new SqlCommand(_query, connection))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    dataAdapter = new SqlDataAdapter();
                    dataTable = new DataTable();

                    dataAdapter.SelectCommand = new SqlCommand(command.CommandText, connection);
                    dataAdapter.Fill(dataTable);
                    dataView = dataTable.DefaultView;
                   
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return dataView;
            }
        }
        public string StringExecuteQuery(string query)
        {
            _query = query;
            connection = new SqlConnection(ConncectionString);
            object result = null;
            string returnValue = null;

            using (System.Data.SqlClient.SqlCommand command = new SqlCommand(_query, connection))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    result = command.ExecuteScalar();
                    returnValue = Convert.ToString(result);
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                return returnValue;
            }
        }
    }


}
