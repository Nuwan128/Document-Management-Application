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
    public partial class ViewDocument : Form
    {
        private readonly IDatabaseData _db;
        private readonly int _id;

        public ViewDocument(IDatabaseData db, int id)
        {
            _db = db;
            _id = id;
            InitializeComponent();

            DisplayDocument(_id);


        }
        public void DisplayDocument(int id)
        {
            var document = _db.ViewDocumentById(id);
            DocumentId.Text = document.Id.ToString();
            PublishDate.Text = document.PublishDate.ToString("yyyy-MM-dd");
            MentorName.Text = document.FirstName + " " + document.LastName;
            MentorPosition.Text = document.Position.ToString();
            DescriptionRichTextBox.Text = document.Description;
            HeadingLabel.Text = document.Title;
            DescriptionRichTextBox.ReadOnly = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
