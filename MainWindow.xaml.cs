using System;
using System.Collections.Generic;
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

namespace PPECerfal
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MaBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                //  if (sqlCon.State == ConnectionState.Closed)
                //   sqlCon.Open();
                // String query = "SELECT COUNT(1) FROM tblUser WHERE Username=@Username AND Password=@Password";
                // SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                //sqlCmd.CommandType = CommandType.Text;
                // sqlCmd.Parameters.AddWithValue("@Username",txtUsername.Text);
                //sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                //int count = Convert.ToInt32(sqlCmd.ExecuteScalar());


                //if (count == 1)
                if (txtUsername.Text == "vallade")
                {
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // sqlCon.Close();
            }
        }

    }
}
