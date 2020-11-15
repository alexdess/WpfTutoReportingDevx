using DevExpress.XtraReports.UI;
using DevExpress.Xpf.Printing;
using System.Windows;
using System;

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
            //var mysqlConnection = DatabaseConnection.getDBConnection();
            //mysqlConnection.Open();
            //var version = mysqlConnection.ServerVersion;
            //Console.WriteLine("MySQL version: " + version);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintHelper.ShowPrintPreview(null, new XtraReport3());
        }

        //public static class DatabaseConnection
        //{
        //    static MySqlConnection databaseConnection = null;
        //    public static MySqlConnection getDBConnection()
        //    {
        //        if (databaseConnection == null)
        //        {
        //            string connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
        //            databaseConnection = new MySqlConnection(connectionString);
        //        }
        //        return databaseConnection;
        //    }

    }
}
