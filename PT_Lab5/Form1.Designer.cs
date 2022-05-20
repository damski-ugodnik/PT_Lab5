namespace PT_Lab5
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
            this.proceedButton = new System.Windows.Forms.Button();
            this.diagramTypeBox = new System.Windows.Forms.ComboBox();
            this.arraySizeBox = new System.Windows.Forms.NumericUpDown();
            this.minValueBox = new System.Windows.Forms.NumericUpDown();
            this.maxValueBox = new System.Windows.Forms.NumericUpDown();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateArrayButton = new System.Windows.Forms.Button();
            this.sortCheckBox = new System.Windows.Forms.CheckBox();
            this.showAuthorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // proceedButton
            // 
            this.proceedButton.Enabled = false;
            this.proceedButton.Location = new System.Drawing.Point(525, 120);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 1;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // diagramTypeBox
            // 
            this.diagramTypeBox.FormattingEnabled = true;
            this.diagramTypeBox.Items.AddRange(new object[] {
            "Circle Diagram",
            "Column Diagram"});
            this.diagramTypeBox.Location = new System.Drawing.Point(38, 82);
            this.diagramTypeBox.Name = "diagramTypeBox";
            this.diagramTypeBox.Size = new System.Drawing.Size(121, 23);
            this.diagramTypeBox.TabIndex = 2;
            // 
            // arraySizeBox
            // 
            this.arraySizeBox.Location = new System.Drawing.Point(228, 82);
            this.arraySizeBox.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.arraySizeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.arraySizeBox.Name = "arraySizeBox";
            this.arraySizeBox.Size = new System.Drawing.Size(120, 23);
            this.arraySizeBox.TabIndex = 3;
            this.arraySizeBox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // minValueBox
            // 
            this.minValueBox.Location = new System.Drawing.Point(354, 82);
            this.minValueBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minValueBox.Name = "minValueBox";
            this.minValueBox.Size = new System.Drawing.Size(120, 23);
            this.minValueBox.TabIndex = 4;
            this.minValueBox.ValueChanged += new System.EventHandler(this.minValueBox_ValueChanged);
            // 
            // maxValueBox
            // 
            this.maxValueBox.Location = new System.Drawing.Point(480, 82);
            this.maxValueBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maxValueBox.Name = "maxValueBox";
            this.maxValueBox.Size = new System.Drawing.Size(120, 23);
            this.maxValueBox.TabIndex = 5;
            this.maxValueBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maxValueBox.ValueChanged += new System.EventHandler(this.maxValueBox_ValueChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iColumn,
            this.ContentColumn});
            this.dataGridView.Location = new System.Drawing.Point(38, 120);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(240, 199);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // iColumn
            // 
            this.iColumn.HeaderText = "i";
            this.iColumn.Name = "iColumn";
            this.iColumn.ReadOnly = true;
            this.iColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ContentColumn
            // 
            this.ContentColumn.HeaderText = "array[i]";
            this.ContentColumn.Name = "ContentColumn";
            // 
            // generateArrayButton
            // 
            this.generateArrayButton.Location = new System.Drawing.Point(371, 120);
            this.generateArrayButton.Name = "generateArrayButton";
            this.generateArrayButton.Size = new System.Drawing.Size(148, 23);
            this.generateArrayButton.TabIndex = 7;
            this.generateArrayButton.Text = "Generate Array";
            this.generateArrayButton.UseVisualStyleBackColor = true;
            this.generateArrayButton.Click += new System.EventHandler(this.generateArrayButton_Click);
            // 
            // sortCheckBox
            // 
            this.sortCheckBox.AutoSize = true;
            this.sortCheckBox.Location = new System.Drawing.Point(525, 149);
            this.sortCheckBox.Name = "sortCheckBox";
            this.sortCheckBox.Size = new System.Drawing.Size(47, 19);
            this.sortCheckBox.TabIndex = 8;
            this.sortCheckBox.Text = "Sort";
            this.sortCheckBox.UseVisualStyleBackColor = true;
            // 
            // showAuthorButton
            // 
            this.showAuthorButton.Location = new System.Drawing.Point(675, 12);
            this.showAuthorButton.Name = "showAuthorButton";
            this.showAuthorButton.Size = new System.Drawing.Size(113, 23);
            this.showAuthorButton.TabIndex = 9;
            this.showAuthorButton.Text = "Show Author";
            this.showAuthorButton.UseVisualStyleBackColor = true;
            this.showAuthorButton.Click += new System.EventHandler(this.showAuthorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showAuthorButton);
            this.Controls.Add(this.sortCheckBox);
            this.Controls.Add(this.generateArrayButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.maxValueBox);
            this.Controls.Add(this.minValueBox);
            this.Controls.Add(this.arraySizeBox);
            this.Controls.Add(this.diagramTypeBox);
            this.Controls.Add(this.proceedButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button proceedButton;
        private ComboBox diagramTypeBox;
        private NumericUpDown arraySizeBox;
        private NumericUpDown minValueBox;
        private NumericUpDown maxValueBox;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn iColumn;
        private DataGridViewTextBoxColumn ContentColumn;
        private Button generateArrayButton;
        private CheckBox sortCheckBox;
        private Button showAuthorButton;
    }
}