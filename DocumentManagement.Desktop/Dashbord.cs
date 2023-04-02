using DataAccessLibrary.Data;
using DataAccessLibrary.Databases;
using DataAccessLibrary.Models;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace DocumentManagement.Desktop
{
    public partial class Dashbord : Form
    {
        private readonly IDatabaseData _db;

        BindingList<DocumentViewModel> documents;
        public Dashbord(IDatabaseData db)
        {
            InitializeComponent();
            _db = db;
            documents = _db.DisplayDocuments();
            listBox1l.DataSource = documents;
        }
        //public void DisplayInUI()
        //{
        //    listView1.Columns.Add("Documnet Id");
        //    listView1.Columns.Add("Title");
        //    listView1.Columns.Add("");

        //    foreach (var document in documents)
        //    {
        //        string[] row = { document.id, document.Title };
        //        var item = new ListViewItem(row);
        //        listView1.Items.Add(item);
        //    }

        //}
    }


}