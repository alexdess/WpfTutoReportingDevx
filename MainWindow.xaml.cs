using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTutoReportingDevx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var mysqlConnection = DatabaseConnection.getDBConnection();
            mysqlConnection.Open();
            var version = mysqlConnection.ServerVersion;
            Console.WriteLine("MySQL version: " + version);
        }

        public static class DatabaseConnection
        {
            static MySqlConnection databaseConnection = null;
            public static MySqlConnection getDBConnection()
            {
                if (databaseConnection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
                    databaseConnection = new MySqlConnection(connectionString);
                }
                return databaseConnection;
            }
        }
    }
}
