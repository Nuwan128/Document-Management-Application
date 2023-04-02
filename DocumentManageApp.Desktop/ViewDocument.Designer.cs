namespace DocumentManageApp.Desktop
{
    partial class ViewDocument
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
            DescriptionRichTextBox = new RichTextBox();
            label1 = new Label();
            Date = new Label();
            DocumentId = new Label();
            PublishDate = new Label();
            MentorNameLabel = new Label();
            Position = new Label();
            MentorName = new Label();
            MentorPosition = new Label();
            BackButton = new Button();
            HeadingLabel = new Label();
            SuspendLayout();
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(69, 138);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(612, 432);
            DescriptionRichTextBox.TabIndex = 0;
            DescriptionRichTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 59);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Documnet No :";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(69, 90);
            Date.Name = "Date";
            Date.Size = new Size(79, 15);
            Date.TabIndex = 1;
            Date.Text = "Publish Date :";
            // 
            // DocumentId
            // 
            DocumentId.AutoSize = true;
            DocumentId.Location = new Point(175, 59);
            DocumentId.Name = "DocumentId";
            DocumentId.Size = new Size(17, 15);
            DocumentId.TabIndex = 1;
            DocumentId.Text = "Id";
            // 
            // PublishDate
            // 
            PublishDate.AutoSize = true;
            PublishDate.Location = new Point(161, 90);
            PublishDate.Name = "PublishDate";
            PublishDate.Size = new Size(31, 15);
            PublishDate.TabIndex = 1;
            PublishDate.Text = "Date";
            // 
            // MentorNameLabel
            // 
            MentorNameLabel.AutoSize = true;
            MentorNameLabel.Location = new Point(526, 59);
            MentorNameLabel.Name = "MentorNameLabel";
            MentorNameLabel.Size = new Size(87, 15);
            MentorNameLabel.TabIndex = 1;
            MentorNameLabel.Text = "Mentor Name :";
            // 
            // Position
            // 
            Position.AutoSize = true;
            Position.Location = new Point(526, 90);
            Position.Name = "Position";
            Position.Size = new Size(98, 15);
            Position.TabIndex = 1;
            Position.Text = "Mentor Position :";
            // 
            // MentorName
            // 
            MentorName.AutoSize = true;
            MentorName.Location = new Point(630, 59);
            MentorName.Name = "MentorName";
            MentorName.Size = new Size(38, 15);
            MentorName.TabIndex = 1;
            MentorName.Text = "label1";
            // 
            // MentorPosition
            // 
            MentorPosition.AutoSize = true;
            MentorPosition.Location = new Point(630, 90);
            MentorPosition.Name = "MentorPosition";
            MentorPosition.Size = new Size(38, 15);
            MentorPosition.TabIndex = 1;
            MentorPosition.Text = "label1";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(338, 584);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 2;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            HeadingLabel.Location = new Point(300, 9);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(150, 37);
            HeadingLabel.TabIndex = 9;
            HeadingLabel.Text = "Document";
            // 
            // ViewDocument
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 621);
            Controls.Add(HeadingLabel);
            Controls.Add(BackButton);
            Controls.Add(MentorPosition);
            Controls.Add(MentorName);
            Controls.Add(PublishDate);
            Controls.Add(Position);
            Controls.Add(DocumentId);
            Controls.Add(MentorNameLabel);
            Controls.Add(Date);
            Controls.Add(label1);
            Controls.Add(DescriptionRichTextBox);
            MaximumSize = new Size(754, 660);
            MinimumSize = new Size(754, 660);
            Name = "ViewDocument";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewDocument";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox DescriptionRichTextBox;
        private Label label1;
        private Label Date;
        private Label DocumentId;
        private Label PublishDate;
        private Label MentorNameLabel;
        private Label Position;
        private Label MentorName;
        private Label MentorPosition;
        private Button BackButton;
        private Label HeadingLabel;
    }
}