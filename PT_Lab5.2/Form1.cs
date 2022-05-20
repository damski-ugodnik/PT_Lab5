namespace PT_Lab5
{
    public partial class Form1 : Form
    {
        int[]? arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
           
            GraphicsForm graphicsForm = new GraphicsForm(arr, (TypeOfDiagram)diagramTypeBox.SelectedIndex);
            graphicsForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diagramTypeBox.SelectedIndex = 0;
        }

        private void minValueBox_ValueChanged(object sender, EventArgs e)
        {
            maxValueBox.Minimum = minValueBox.Value + 1;
        }

        private void maxValueBox_ValueChanged(object sender, EventArgs e)
        {
            minValueBox.Maximum = maxValueBox.Value - 1;
        }

        private void generateArrayButton_Click(object sender, EventArgs e)
        {
            arr = new int[(int)arraySizeBox.Value];
            dataGridView.RowCount = arr.Length;
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next((int)minValueBox.Value, (int)maxValueBox.Value);
                dataGridView[1, i].Value = arr[i];
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            arr[e.RowIndex] = (int)dataGridView[e.ColumnIndex, e.RowIndex].Value;
        }
    }

    public enum TypeOfDiagram
    {
        Column = 1,
        Circle = 0
    }
}