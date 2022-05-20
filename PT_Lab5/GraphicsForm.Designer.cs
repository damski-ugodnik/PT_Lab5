namespace PT_Lab5
{
    partial class GraphicsForm
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
            this.showAuthorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showAuthorButton
            // 
            this.showAuthorButton.Location = new System.Drawing.Point(675, 2);
            this.showAuthorButton.Name = "showAuthorButton";
            this.showAuthorButton.Size = new System.Drawing.Size(113, 23);
            this.showAuthorButton.TabIndex = 0;
            this.showAuthorButton.Text = "Show Author";
            this.showAuthorButton.UseVisualStyleBackColor = true;
            this.showAuthorButton.Click += new System.EventHandler(this.showAuthorButton_Click);
            // 
            // GraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showAuthorButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphicsForm";
            this.Text = "GraphicsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GraphicsForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphicsForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private Button showAuthorButton;
    }
}