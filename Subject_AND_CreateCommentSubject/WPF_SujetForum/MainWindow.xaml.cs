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

            //ConfigurationManager.AppSettings["..."] provient du fichier "app.config"
            daoConnection = new DAO(ConfigurationManager.AppSettings["serveur"], ConfigurationManager.AppSettings["dbName"], ConfigurationManager.AppSettings["dbUser"], ConfigurationManager.AppSettings["dbPassword"]);
            RefreshListBox();

            /*
             Est normalement effectué par le login
             */
            User.IdUser = "3";
            User.Username = "test";
            User.IsAdmin = true;
        }

        /// <summary>
        /// Lorsque l'on clique sur le bouton "btnCreateSujet"
        /// </summary>
        /// <param name="sender">Objet de provenance</param>
        /// <param name="e">Evénements</param>
        private void btnCreateSujet_Click(object sender, RoutedEventArgs e)
        {
            if (tbxCreateSujet.Text != "")
            {
                daoConnection.InsertSubject(tbxCreateSujet.Text);
                RefreshListBox();
            }
        }

        /// <summary>
        /// Lorsque l'on clique sur le bouton "btnDeleteSujet"
        /// </summary>
        /// <param name="sender">Objet de provenance</param>
        /// <param name="e">Evénements</param>
        private void btnDeleteSujet_Click(object sender, RoutedEventArgs e)
        {
            if (lsbSujets.SelectedItem != null)
            {
                daoConnection.DeleteByIdSubject(lsbSujets.SelectedItem.ToString().Split('.')[0]);
                RefreshListBox();
            }
        }

        /// <summary>
        /// Efface et réinsère toutes les données.
        /// </summary>
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

        /// <summary>
        /// Lorsque l'on clique sur le bouton "btnCreateCommentaire"
        /// </summary>
        /// <param name="sender">Objet de provenance</param>
        /// <param name="e">Evénements</param>
        private void btnCreateCommentaire_Click(object sender, RoutedEventArgs e)
        {
            if (lsbSujets.SelectedItem != null && tbxComments.Text != "")
            {
                daoConnection.InsertComment(tbxComments.Text, lsbSujets.SelectedItem.ToString().Split('.')[0], User.IdUser);
            }
        }

        private void buttonDown_Click(object sender, RoutedEventArgs e)
        {
        }

        private void buttonUp_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            lsbListComment.Items.Clear();
            foreach (KeyValuePair<string, string> item in daoConnection.SelectCommentaire())
            {
                lsbListComment.Items.Add(item.Key + ":" + item.Value);
            }
        }
    }
}
