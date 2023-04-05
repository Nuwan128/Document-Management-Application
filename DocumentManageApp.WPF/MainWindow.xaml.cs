using DataAccessLibrary.Data;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DocumentManageApp.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDatabaseData _db;
        public MainWindow(IDatabaseData db)
        {
            InitializeComponent();
            _db = db;

            documentsDataGrid.ItemsSource = _db.DisplayDocuments(); 
            
        }

        private void SerchButton_Click(object sender, RoutedEventArgs e)
        {
            string title = serchText.Text;
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Enter Title", "Empty Field", MessageBoxButton.OK, MessageBoxImage.Warning);
                serchText.Text = "";
                documentsDataGrid.ItemsSource = _db.DisplayDocuments();
            }
            else
            {
                documentsDataGrid.ItemsSource = _db.SearchDocument(title);  
            }
        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to View this document",
                                                 "View Field Confirmation",
                                                 MessageBoxButton.YesNo,
                                                 MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                DocumentViewModel document = (DocumentViewModel)documentsDataGrid.SelectedItem;

                ViewDocument viewDocument = new ViewDocument(document);
                viewDocument.ShowDialog();
            }

            
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to Update this document",
                                                  "Update Field Confirmation",
                                                  MessageBoxButton.YesNo,
                                                  MessageBoxImage.Warning);

            DocumentViewModel document = (DocumentViewModel)documentsDataGrid.SelectedItem;

            if (result == MessageBoxResult.Yes)
            {
                AddDocument updateDocument = new AddDocument(_db, documentsDataGrid, document.Id);
                updateDocument.ShowDialog();
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Do you want to remove this document",
                                                  "Remove Field Confirmation",
                                                  MessageBoxButton.YesNo,
                                                  MessageBoxImage.Warning);

            DocumentViewModel document = (DocumentViewModel)documentsDataGrid.SelectedItem;
         
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    _db.RemoveDocumentById(document.Id);
                    documentsDataGrid.ItemsSource = _db.DisplayDocuments();
                }
                catch (Exception)
                {
                    throw new Exception();
                }

            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            AddDocument document = new AddDocument(_db,documentsDataGrid,0);
            document.ShowDialog();

        }
    }
}
