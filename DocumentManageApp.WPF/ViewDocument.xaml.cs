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
    /// Interaction logic for ViewDocument.xaml
    /// </summary>
    public partial class ViewDocument : Window
    {
        private readonly DocumentViewModel _document;

        public ViewDocument(DocumentViewModel document)
        {
            InitializeComponent();
            _document = document;

            IdTextBlock.Text = document.Id.ToString();
            PublishDateTextBlock.Text = document.PublishDate.ToString("yyyy-mm-dd");
            NameTxtxBlock.Text = document.FirstName +" "+ document.LastName; ;
            PositionTextBlock.Text = document.Position;
            DescriptionTextBlock.Text = document.Description;

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
