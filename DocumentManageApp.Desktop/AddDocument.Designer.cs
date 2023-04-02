namespace DocumentManageApp.Desktop
{
    partial class AddDocumentForm
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
            TitleLabel = new Label();
            LastNameTextBox = new TextBox();
            label1 = new Label();
            PositionTextBox = new TextBox();
            PublishDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            TitleText = new TextBox();
            label4 = new Label();
            FirtNameTextBox = new TextBox();
            DescriptionRichTextBox = new RichTextBox();
            label5 = new Label();
            SaveButton = new Button();
            HeadingLabel = new Label();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(34, 352);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(105, 15);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Mentor Last Name";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(155, 349);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(358, 23);
            LastNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 386);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Mentor Position";
            // 
            // PositionTextBox
            // 
            PositionTextBox.Location = new Point(155, 383);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(358, 23);
            PositionTextBox.TabIndex = 6;
            // 
            // PublishDate
            // 
            PublishDate.Location = new Point(155, 281);
            PublishDate.Name = "PublishDate";
            PublishDate.Size = new Size(358, 23);
            PublishDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 284);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Publish Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 62);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 0;
            label3.Text = "Title";
            // 
            // TitleText
            // 
            TitleText.Location = new Point(155, 62);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(358, 23);
            TitleText.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 318);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 0;
            label4.Text = "Mentor First Name";
            // 
            // FirtNameTextBox
            // 
            FirtNameTextBox.Location = new Point(155, 315);
            FirtNameTextBox.Name = "FirtNameTextBox";
            FirtNameTextBox.Size = new Size(358, 23);
            FirtNameTextBox.TabIndex = 4;
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(155, 96);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(358, 174);
            DescriptionRichTextBox.TabIndex = 2;
            DescriptionRichTextBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 91);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 0;
            label5.Text = "Description";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(155, 417);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(358, 30);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            HeadingLabel.Location = new Point(253, 9);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(150, 37);
            HeadingLabel.TabIndex = 8;
            HeadingLabel.Text = "Document";
            // 
            // AddDocumentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 466);
            Controls.Add(HeadingLabel);
            Controls.Add(SaveButton);
            Controls.Add(DescriptionRichTextBox);
            Controls.Add(PublishDate);
            Controls.Add(FirtNameTextBox);
            Controls.Add(PositionTextBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(TitleText);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(LastNameTextBox);
            Controls.Add(TitleLabel);
            MaximumSize = new Size(635, 505);
            MinimumSize = new Size(635, 505);
            Name = "AddDocumentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Document";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private TextBox LastNameTextBox;
        private Label label1;
        private TextBox PositionTextBox;
        private DateTimePicker PublishDate;
        private Label label2;
        private Label label3;
        private TextBox TitleText;
        private Label label4;
        private TextBox FirtNameTextBox;
        private RichTextBox DescriptionRichTextBox;
        private Label label5;
        private Button SaveButton;
        private Label HeadingLabel;
    }
}