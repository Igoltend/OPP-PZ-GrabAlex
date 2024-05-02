namespace pz_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cityTextBox = new TextBox();
            countryTextBox = new TextBox();
            saveButton = new Button();
            entriesListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            dateTextBox = new DateTimePicker();
            SuspendLayout();
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(90, 76);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(125, 27);
            cityTextBox.TabIndex = 0;
            cityTextBox.TextChanged += cityTextBox_TextChanged;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(91, 121);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(125, 27);
            countryTextBox.TabIndex = 1;
            countryTextBox.TextChanged += countryTextBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(93, 243);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 3;
            saveButton.Text = "saveButton";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // entriesListView
            // 
            entriesListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            entriesListView.Location = new Point(309, 57);
            entriesListView.Name = "entriesListView";
            entriesListView.Size = new Size(345, 185);
            entriesListView.TabIndex = 4;
            entriesListView.UseCompatibleStateImageBehavior = false;
            entriesListView.View = View.Details;
            entriesListView.SelectedIndexChanged += entriesListView_SelectedIndexChanged;
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(31, 168);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(250, 27);
            dateTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTextBox);
            Controls.Add(entriesListView);
            Controls.Add(saveButton);
            Controls.Add(countryTextBox);
            Controls.Add(cityTextBox);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cityTextBox;
        private TextBox countryTextBox;
        private Button saveButton;
        private ListView entriesListView;
        private DateTimePicker dateTextBox;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
