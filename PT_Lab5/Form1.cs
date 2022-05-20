namespace PT_Lab5
{
    public partial class Form1 : Form
    {
        int[]? arr;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ���������� ������� ������ ��������� ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void proceedButton_Click(object sender, EventArgs e)
        {
            int[] cloneArr = (int[])arr.Clone();
            if (sortCheckBox.Checked)// ���� ����������� ������� ���������� �������, �� ��������� ����� ��������� �� ��������������� �������
            {
               Array.Sort(cloneArr);
            }
            GraphicsForm graphicsForm = new GraphicsForm(cloneArr, (TypeOfDiagram)diagramTypeBox.SelectedIndex);// �������� ���������� ����� � ���������� �������� � ����� ���������
            graphicsForm.ShowDialog();// ����� ����� �� ����� � ���� �������
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diagramTypeBox.SelectedIndex = 0;
        }
        /// <summary>
        /// ���������� ��������� ������������ �������� �������
        /// �������� ����������� �������� ���� ������������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minValueBox_ValueChanged(object sender, EventArgs e)
        {
            maxValueBox.Minimum = minValueBox.Value + 1;
        }
        /// <summary>
        /// ���������� ��������� ������������� �������� �������
        /// �������� ������������ �������� ���� ������������ ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maxValueBox_ValueChanged(object sender, EventArgs e)
        {
            minValueBox.Maximum = maxValueBox.Value - 1;
        }
        /// <summary>
        /// ���������� ������� ������ ��������� ������� �� �������� � ����� ���������� � ����� ������� � �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateArrayButton_Click(object sender, EventArgs e)
        {
            proceedButton.Enabled = true;
            arr = new int[(int)arraySizeBox.Value];
           
            Random random = new Random();
            dataGridView.Rows.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                dataGridView.Rows.Add();
                arr[i] = random.Next((int)minValueBox.Value, (int)maxValueBox.Value);
                dataGridView[0, i].Value = i;
                dataGridView[1, i].Value = arr[i];
            }
        }
        /// <summary>
        /// ���������� ��������� �������� ������ �������
        /// ���� ���� ������������, �� ���������� ����� � ����������� ���������
        /// ���� ���� �������� - ���������� ��������������� ������ ������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (arr != null)
                {
                    int temp = arr[e.RowIndex];
                    if (int.TryParse(dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString(), out arr[e.RowIndex]))
                    {
                        ;
                    }
                    else
                    {
                        dataGridView[1, e.RowIndex].Value = temp;
                        arr[e.RowIndex] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// ����� ����� � ����������� �� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAuthorButton_Click(object sender, EventArgs e)
        {
            Form f = new MeForm();
            f.ShowDialog();
        }
    }
    /// <summary>
    /// ������������ ����� ���������
    /// </summary>
    public enum TypeOfDiagram
    {
        Column = 1,
        Circle = 0
    }
}