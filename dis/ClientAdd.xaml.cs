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
using System.Windows.Shapes;

namespace dis
{
    /// <summary>
    /// Логика взаимодействия для ClientAdd.xaml
    /// </summary>
    public partial class ClientAdd : Window
    {
        fEntities context;
        public ClientAdd()
        {
            InitializeComponent();
            context = new fEntities();
            ShowTable();
        }

        private void ShowTable()
        {
            DataGridClient.ItemsSource = context.Client.ToList();
        }

       

        private void BtnAddData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddClient_Click_1(object sender, RoutedEventArgs e)
        {
            var currentRental = DataGridClient.SelectedItem as Client;
            if (currentRental == null)
            {
                MessageBox.Show("Выберите строку!");
                return;

            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удадить эту строку?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.Client.Remove(currentRental);
                context.SaveChanges();
                ShowTable();
            }
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddData_Click_1(object sender, RoutedEventArgs e)
        {
            var NewRental = new Client();
            context.Client.Add(NewRental);
            var addRentalWindow = new BtnAddClient(context, NewRental);
            addRentalWindow.ShowDialog();
        }

        private void BtnEditData_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddTables(object sender, RoutedEventArgs e)
        {
            var RentalSelect = new Tables();
            RentalSelect.ShowDialog();
        }

        private void DataGridClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
