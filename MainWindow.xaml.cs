using DevExpress.Xpf.Printing;
using System;
using System.Linq;
using System.Windows;
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintHelper.ShowPrintPreview(null, new XtraReport3());
        }

        private void UseEFExample()
        {
            var person = new Person();
            using (var db = new AdventureWorks2017Entities())
            {
                db.Person.Add(person);

                var q = from p in db.Person
                        orderby p.Title
                        select p;
                foreach (var res in q)
                {
                    Console.WriteLine(res.FirstName);
                }
            }
        }

        private void ButtonEF_Click(object sender, RoutedEventArgs e)
        {
            UseEFExample();
        }
    }
}
