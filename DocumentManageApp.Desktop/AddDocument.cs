using DataAccessLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManageApp.Desktop
{
    public partial class AddDocumentForm : Form
    {
        private readonly int _id;
        private readonly IDatabaseData _db;
        private readonly DataGridView _documentDataGridView;

        public AddDocumentForm(int id,IDatabaseData db, DataGridView documentDataGridView)
        {
            InitializeComponent();
            _id = id;
            _db = db;
            _documentDataGridView = documentDataGridView;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
           
            List<string> emptyFields = new List<string>();

            if (string.IsNullOrWhiteSpace(TitleText.Text))
            {
                emptyFields.Add("Title");
            }

            if (string.IsNullOrWhiteSpace(DescriptionRichTextBox.Text))
            {
                emptyFields.Add("Description");
            }

            if (PublishDate.Checked == false)
            {
                emptyFields.Add("Date");
            }

            if (string.IsNullOrWhiteSpace(FirtNameTextBox.Text))
            {
                emptyFields.Add("First Name");
            }

            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                emptyFields.Add("Last Name");
            }

            if (string.IsNullOrWhiteSpace(PositionTextBox.Text))
            {
                emptyFields.Add("Position");
            }


            if (emptyFields.Count > 0)
            {
                string message = "Please enter the following fields:\n\n";
                message += string.Join("\n", emptyFields);
                MessageBox.Show(message, "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            try
            {
                if (_id.Equals(0))
                {
                    _db.InsertDocument(TitleText.Text,
                             DescriptionRichTextBox.Text,
                             PublishDate.Value,
                             FirtNameTextBox.Text,
                             LastNameTextBox.Text,
                             PositionTextBox.Text);
                }
                else
                {
                    _db.UpdateDocument(_id,
                                  TitleText.Text,
                                  DescriptionRichTextBox.Text,
                                  PublishDate.Value,
                                  FirtNameTextBox.Text,
                                  LastNameTextBox.Text,
                                  PositionTextBox.Text);
                }
                _documentDataGridView.DataSource = _db.DisplayDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the data:\n\n" + ex.Message, "Error", MessageBoxButtons.OK);
            }



            this.Close();

        }
    }
}
