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

namespace WPF_SujetForum
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DAO daoConnection;

        public MainWindow()
        {
            InitializeComponent();
            daoConnection = new DAO(ConfigurationManager.AppSettings["serveur"], ConfigurationManager.AppSettings["dbName"], ConfigurationManager.AppSettings["dbUser"], ConfigurationManager.AppSettings["dbPassword"]);
            RefreshListBox();

            /*
             Est normalement effectué par le login
             */
            User.IdUser = "2";
            User.Username = "User";
            User.IsAdmin = true;
        }

        private void btnCreateSujet_Click(object sender, RoutedEventArgs e)
        {
            if (tbxCreateSujet.Text != "")
            {
                daoConnection.InsertSubject(tbxCreateSujet.Text);
                RefreshListBox();
            }
        }

        private void btnDeleteSujet_Click(object sender, RoutedEventArgs e)
        {
            if (lsbSujets.SelectedItem != null)
            {
                daoConnection.DeleteById(lsbSujets.SelectedItem.ToString().Split('.')[0]);
                RefreshListBox();
            }
        }

        private void RefreshListBox()
        {
            lsbSujets.Items.Clear();
            Dictionary<string, string> tempDictionnaire = daoConnection.SelectAllSubject();
            List<string> listKeys = tempDictionnaire.Keys.ToList();
            List<string> listValues = tempDictionnaire.Values.ToList();
            for (int i = 0; i < listKeys.Count; i++)
            {
                lsbSujets.Items.Add(listKeys[i] + "." + listValues[i]);
            }
        }

        private void btnCreateCommentaire_Click(object sender, RoutedEventArgs e)
        {
            if (lsbSujets.SelectedItem != null && tbxComments.Text != "")
            {
                daoConnection.InsertComment(tbxComments.Text, lsbSujets.SelectedItem.ToString().Split('.')[0], "1");
            }
        }
    }
}
