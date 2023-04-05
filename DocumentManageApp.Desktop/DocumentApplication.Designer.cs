namespace DocumentManageApp.Desktop
{
    partial class DocumentApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AddButton = new Button();
            SearchButton = new Button();
            SearchTextBox = new TextBox();
            HeadingLabel = new Label();
            DocumentsDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PublishDate = new DataGridViewTextBoxColumn();
            documentViewModelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)DocumentsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(657, 109);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(271, 109);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(72, 109);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(178, 23);
            SearchTextBox.TabIndex = 7;
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            HeadingLabel.Location = new Point(321, 22);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(162, 37);
            HeadingLabel.TabIndex = 6;
            HeadingLabel.Text = "Documents";
            // 
            // DocumentsDataGridView
            // 
            DocumentsDataGridView.AllowUserToAddRows = false;
            DocumentsDataGridView.AllowUserToDeleteRows = false;
            DocumentsDataGridView.AutoGenerateColumns = false;
            DocumentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DocumentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, titleDataGridViewTextBoxColumn, PublishDate });
            DocumentsDataGridView.DataSource = documentViewModelBindingSource;
            DocumentsDataGridView.Location = new Point(72, 159);
            DocumentsDataGridView.Name = "DocumentsDataGridView";
            DocumentsDataGridView.ReadOnly = true;
            DocumentsDataGridView.RowTemplate.Height = 25;
            DocumentsDataGridView.Size = new Size(660, 316);
            DocumentsDataGridView.TabIndex = 10;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PublishDate
            // 
            PublishDate.DataPropertyName = "PublishDate";
            PublishDate.HeaderText = "PublishDate";
            PublishDate.Name = "PublishDate";
            PublishDate.ReadOnly = true;
            // 
            // documentViewModelBindingSource
            // 
            documentViewModelBindingSource.DataSource = typeof(DataAccessLibrary.Models.DocumentViewModel);
            // 
            // DocumentApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 519);
            Controls.Add(DocumentsDataGridView);
            Controls.Add(AddButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(HeadingLabel);
            MaximumSize = new Size(836, 558);
            MinimumSize = new Size(836, 558);
            Name = "DocumentApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Document Application";
            ((System.ComponentModel.ISupportInitialize)DocumentsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button SearchButton;
        private TextBox SearchTextBox;
        private Label HeadingLabel;
        private DataGridView DocumentsDataGridView;
        private BindingSource documentViewModelBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PublishDate;
    }
}