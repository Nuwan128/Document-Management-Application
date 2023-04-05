namespace DocumentManageApp.Desktop
{
    partial class UpdateDocument
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
            HeadingLabel = new Label();
            UpdateButton = new Button();
            DescriptionRichTextBox = new RichTextBox();
            PublishDate = new DateTimePicker();
            FirtNameTextBox = new TextBox();
            PositionTextBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            TitleText = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            LastNameTextBox = new TextBox();
            TitleLabel = new Label();
            SuspendLayout();
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            HeadingLabel.Location = new Point(203, 13);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(252, 37);
            HeadingLabel.TabIndex = 22;
            HeadingLabel.Text = "Update Document";
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(150, 421);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(358, 30);
            UpdateButton.TabIndex = 21;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Location = new Point(150, 100);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(358, 174);
            DescriptionRichTextBox.TabIndex = 16;
            DescriptionRichTextBox.Text = "";
            // 
            // PublishDate
            // 
            PublishDate.Location = new Point(150, 285);
            PublishDate.Name = "PublishDate";
            PublishDate.Size = new Size(358, 23);
            PublishDate.TabIndex = 17;
            // 
            // FirtNameTextBox
            // 
            FirtNameTextBox.Location = new Point(150, 319);
            FirtNameTextBox.Name = "FirtNameTextBox";
            FirtNameTextBox.Size = new Size(358, 23);
            FirtNameTextBox.TabIndex = 18;
            // 
            // PositionTextBox
            // 
            PositionTextBox.Location = new Point(150, 387);
            PositionTextBox.Name = "PositionTextBox";
            PositionTextBox.Size = new Size(358, 23);
            PositionTextBox.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 322);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 9;
            label4.Text = "Mentor First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 288);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 10;
            label2.Text = "Publish Date";
            // 
            // TitleText
            // 
            TitleText.Location = new Point(150, 66);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(358, 23);
            TitleText.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 390);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 11;
            label1.Text = "Mentor Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 95);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 12;
            label5.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 66);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 13;
            label3.Text = "Title";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(150, 353);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(358, 23);
            LastNameTextBox.TabIndex = 19;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(29, 356);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(105, 15);
            TitleLabel.TabIndex = 14;
            TitleLabel.Text = "Mentor Last Name";
            // 
            // UpdateDocument
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 466);
            Controls.Add(HeadingLabel);
            Controls.Add(UpdateButton);
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
            Name = "UpdateDocument";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDocument";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeadingLabel;
        private Button UpdateButton;
        private RichTextBox DescriptionRichTextBox;
        private DateTimePicker PublishDate;
        private TextBox FirtNameTextBox;
        private TextBox PositionTextBox;
        private Label label4;
        private Label label2;
        private TextBox TitleText;
        private Label label1;
        private Label label5;
        private Label label3;
        private TextBox LastNameTextBox;
        private Label TitleLabel;
    }
}