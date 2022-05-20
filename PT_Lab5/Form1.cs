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
        /// Обработчик нажатия кнопки рисования диаграммы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void proceedButton_Click(object sender, EventArgs e)
        {
            int[] cloneArr = (int[])arr.Clone();
            if (sortCheckBox.Checked)// если установлена галочка сортировки массива, то диаграмма будет построена по отсортрованному массиву
            {
               Array.Sort(cloneArr);
            }
            GraphicsForm graphicsForm = new GraphicsForm(cloneArr, (TypeOfDiagram)diagramTypeBox.SelectedIndex);// создание экземпляра формы с переданным массивом и типом диаграммы
            graphicsForm.ShowDialog();// вывод формы на экран в виде диалога
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diagramTypeBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Обработчик изменения минимального значения массива
        /// меняется минимальное значение поля максимального значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minValueBox_ValueChanged(object sender, EventArgs e)
        {
            maxValueBox.Minimum = minValueBox.Value + 1;
        }
        /// <summary>
        /// Обработчик изменения максимального значения массива
        /// меняется максимальное значение поля минимального значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maxValueBox_ValueChanged(object sender, EventArgs e)
        {
            minValueBox.Maximum = maxValueBox.Value - 1;
        }
        /// <summary>
        /// Обработчик нажатия кнопки генерации массива по заданным в полях параметрам и вывод массива в таблицу
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
        /// Обработчик изменения значения ячейки таблицы
        /// если ввод неправильный, то происходит откат к предыдущему состоянию
        /// если ввод успешный - изсеняется соответсвтующая ячейка массива 
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
        /// Вывод формы с информацией об авторе
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
    /// перечсиление типов диаграммы
    /// </summary>
    public enum TypeOfDiagram
    {
        Column = 1,
        Circle = 0
    }
}