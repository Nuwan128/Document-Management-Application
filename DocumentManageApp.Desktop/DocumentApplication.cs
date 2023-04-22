using DataAccessLibrary.Data;
using DataAccessLibrary.Models;
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
    public partial class DocumentApplication : Form
    {
        private readonly IDatabaseData _db;
        //public List<DocumentViewModel> documents;

        public DocumentApplication(IDatabaseData db)
        {
            _db = db;
            InitializeComponent();
            SetDataGridViewSettings();
            DocumentsDataGridView.DataSource = _db.DisplayDocuments();
        }


        public void SetDataGridViewSettings()
        {
            var viewButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "View",
                Name = "View",
                Text = "View",
                UseColumnTextForButtonValue = true

            };
            var updateButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Update",
                Name = "Update",
                Text = "Update",
                UseColumnTextForButtonValue = true

            };
            var RemoveButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Remove",
                Name = "Remove",
                Text = "Remove",
                UseColumnTextForButtonValue = true
            };

            DocumentsDataGridView.Columns.Add(viewButtonColumn);
            DocumentsDataGridView.Columns.Add(updateButtonColumn);
            DocumentsDataGridView.Columns.Add(RemoveButtonColumn);
            DocumentsDataGridView.CellContentClick += DocumentsDataGridView_CellContentClick;


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string title = SearchTextBox.Text;
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please Enter Title", "Empty Feild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SearchTextBox.Text = "";

                DocumentsDataGridView.DataSource = _db.DisplayDocuments();

            }
            else
            {
                DocumentsDataGridView.DataSource = _db.SearchDocument(title);
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddDocumentForm addDocument = new AddDocumentForm(0,_db, DocumentsDataGridView);
            //AddDocumentForm.
            addDocument.ShowDialog();
        }

        private void DocumentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(DocumentsDataGridView.Rows[e.RowIndex].Cells["Id"].Value);


            if (e.ColumnIndex == DocumentsDataGridView.Columns["View"].Index && e.RowIndex >= 0)
            {


                DialogResult result = MessageBox.Show("Do you want to view this document",
                                                      "View Field Confirmation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ViewDocument viewDocument = new ViewDocument(_db, id);
                        viewDocument.ShowDialog();
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                }
            }

            if (e.ColumnIndex == DocumentsDataGridView.Columns["Update"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to update this document",
                                                      "View Field Confirmation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        AddDocumentForm updateDocument = new AddDocumentForm(id, _db, DocumentsDataGridView);
                        updateDocument.ShowDialog();
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                }
            }

            if (e.ColumnIndex == DocumentsDataGridView.Columns["Remove"].Index && e.RowIndex >= 0)
            {

                //string title = DocumentsDataGridView.Rows[e.RowIndex].Cells["Title"].Value.ToString();

                DialogResult result = MessageBox.Show("Do you want to remove this document",
                                                      "Delete Field Confirmation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _db.RemoveDocumentById(id);
                        DocumentsDataGridView.DataSource = _db.DisplayDocuments();
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                }
            }


        }

    }
}
