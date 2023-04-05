using DataAccessLibrary.Data;
using DataAccessLibrary.Models;
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

namespace DocumentManageApp.WPF
{
    /// <summary>
    /// Interaction logic for AddDocument.xaml
    /// </summary>
    public partial class AddDocument : Window
    {
        private readonly IDatabaseData _db;
        private readonly DataGrid _dataGrid;
        private readonly int _id;

        public AddDocument(IDatabaseData db, DataGrid dataGrid,int id)
        {
            InitializeComponent();
            _db = db;
            _dataGrid = dataGrid;
            _id = id;
        }
        

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> emptyFields = new List<string>();

            if (string.IsNullOrWhiteSpace(TitleText.Text))
            {
                emptyFields.Add("Title");
            }

            if (string.IsNullOrWhiteSpace(DescriptionText.Text))
            {
                emptyFields.Add("Description");
            }

            if (PublishDate.SelectedDate == null)
            {
                emptyFields.Add("Date");
            }

            if (string.IsNullOrWhiteSpace(FirstNameText.Text))
            {
                emptyFields.Add("First Name");
            }

            if (string.IsNullOrWhiteSpace(LastNameText.Text))
            {
                emptyFields.Add("Last Name");
            }

            if (string.IsNullOrWhiteSpace(PositionText.Text))
            {
                emptyFields.Add("Position");
            }


            if (emptyFields.Count > 0)
            {
                string message = "Please enter the following fields:\n\n";
                message += string.Join("\n", emptyFields);
                MessageBox.Show(message, "Empty Fields", MessageBoxButton.OK,MessageBoxImage.Warning);
                return;
            }

            try
            {
                if (_id.Equals(0))
                {
                    _db.InsertDocument(TitleText.Text,
                                  DescriptionText.Text,
                                  PublishDate.SelectedDate.Value,
                                  FirstNameText.Text,
                                  LastNameText.Text,
                                  PositionText.Text);
                }
                else 
                {
                    _db.UpdateDocument(_id,
                                       TitleText.Text,
                                       DescriptionText.Text,
                                       PublishDate.SelectedDate.Value,
                                       FirstNameText.Text,
                                       LastNameText.Text,
                                       PositionText.Text);
                }

                _dataGrid.ItemsSource = _db.DisplayDocuments();
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error {ex}");
            }
            
            this.Close();
        }
    }
}
