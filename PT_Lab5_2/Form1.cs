using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PT_Lab5_2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// массивы чисел и индексов
        /// </summary>
        int[] arr1, arr2, indices;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Процесс загрузки формы и вывода её на экран
        /// установка местоположения элементов для полноэкранного режима
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            chart1.Height = this.Height - 100;
            chart1.Width = this.Width - groupBox1.Width - 40;
            groupBox1.Height = this.Height;
            dataGridView2.Height = dataGridView1.Height;
            dataGridView2.Location = new Point(dataGridView1.Left, dataGridView1.Bottom + 120);
            label1.Location = new Point(dataGridView1.Left, dataGridView1.Top - label1.Height - 10);
            label2.Location = new Point(dataGridView2.Left, dataGridView2.Top - label2.Height - 10);
            GenerateButton.Location = new Point(dataGridView1.Left, dataGridView1.Bottom + 10);
            SizeLabel.Location = new Point(GenerateButton.Right + 10, dataGridView1.Bottom + 10);
            sizeUpDown.Location = new Point(SizeLabel.Right, dataGridView1.Bottom + 10);
            minUpDown.Location = new Point(sizeUpDown.Left, sizeUpDown.Bottom + 5);
            MinLabel.Location = new Point(SizeLabel.Left, minUpDown.Top);
            maxUpDown.Location = new Point(minUpDown.Left, minUpDown.Bottom + 5);
            MaxLabel.Location = new Point(SizeLabel.Left, maxUpDown.Top);
            groupBox1.Location = new Point(chart1.Right, chart1.Top);
            comboBox1.Location = new Point(label1.Right, label1.Top);
            comboBox2.Location = new Point(label2.Right, label2.Top);
            mergeButton.Location = new Point(chart1.Right - mergeButton.Width - 10, chart1.Height / 2-30);
            mergeButton.Enabled = false;
        }
        /// <summary>
        /// Установка максимального числа в массиве
        /// в этом случае, макимальное вводимое значение поля минимального числа в массиве, меньше заданного максимума на 1 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maxUpDown_ValueChanged(object sender, EventArgs e)
        {
            minUpDown.Maximum = maxUpDown.Value - 1;
        }
        /// <summary>
        /// Установка минимального числа в массиве
        /// в этом случае, минимальное вводимое значение поля максимального числа в массиве, больше заданного минимума на 1 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minUpDown_ValueChanged(object sender, EventArgs e)
        {
            maxUpDown.Minimum = minUpDown.Value + 1;
        }
        /// <summary>
        /// Обработчик нажатия кнопки генерации массива
        /// Генерируются массивы по заданным параметрам, массивы выводятся в две независимые таблицы на два графика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            arr1 = arr2 = new int[(int)sizeUpDown.Value];
            indices = new int[(int)sizeUpDown.Value];
            Random r = new Random();
            dataGridView1.Enabled = dataGridView2.Enabled = true;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            for (int i = 0; i < arr1.Length; i++)
            {
                indices[i] = i;
                arr1[i] = arr2[i] = r.Next((int)minUpDown.Value, (int)maxUpDown.Value);
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();
                dataGridView1[0, i].Value = dataGridView2[0, i].Value = i;
                dataGridView1[1, i].Value = dataGridView2[1, i].Value = arr1[i];
            }
            chart1.Series[0].Points.DataBindXY(indices, arr1);
            chart1.Series[1].Points.DataBindXY(indices, arr2);
            mergeButton.Enabled = true;
        }
        /// <summary>
        /// Обработчик изменения значения в ячейке таблицы
        /// привязанный к таблице график изменяется в соответствии с изменениями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (arr1!= null&&arr2!=null)// если массив сущестует, то будет проивходить обработка
            {
                DataGridView d = sender as DataGridView;
                if (e.ColumnIndex == 1)
                {
                    if (d == dataGridView1)
                    {
                        arr1[e.RowIndex] = Convert.ToInt32(d[e.ColumnIndex, e.RowIndex].Value);
                        chart1.Series[0].Points.DataBindXY(indices, arr1);
                    }
                    if (d == dataGridView2)
                    {
                        arr2[e.RowIndex] = Convert.ToInt32(d[e.ColumnIndex, e.RowIndex].Value);
                        chart1.Series[1].Points.DataBindXY(indices, arr2);
                    }
                }
              
            }
        }
        /// <summary>
        /// обработчик события изменения типа графика
        /// установка типа графика в соответствии с полем, в котором происходило изменение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType type = default;// переменная типа графика
            ComboBox c = sender as ComboBox;
            switch (c.SelectedIndex)// в зависимости от игдекса в поле, выбор нужного режима
            {
                case 0:
                    type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 1:
                    {
                        if (!chart1.ChartAreas[1].Visible)
                        {
                            c.SelectedIndex = 0;
                            type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                            break;
                        }
                        type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    }
                    break;
                case 2:
                    {
                        if (!chart1.ChartAreas[1].Visible)
                        {
                            c.SelectedIndex = 0;
                            type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                            break;
                        }
                        type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
                    }
                    break;
                case 3:
                    type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
                    break;
                case 4:
                    if (!chart1.ChartAreas[1].Visible)
                    {
                        c.SelectedIndex = 0;
                        type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        break;
                    }
                    type = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
                    break;
            }

                if (sender == comboBox1)// если выбор происходил в верхнем поле, то тип устанавливается для верхнего графика
                {
                    chart1.Series[0].ChartType = type;
                }
                else chart1.Series[1].ChartType = type;// иначе, для нижнего
        }
        /// <summary>
        /// Событие нажатия на пункт Sort контекстного меню первой таблицы
        /// происходит сортировка массива привязанного к таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Array.Sort(arr1);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1[1, i].Value = arr1[i];
            }

        }
        /// <summary>
        /// Аналогично с контекстным меню первой таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            Array.Sort(arr2);
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2[1, i].Value = arr2[i];
            }
        }
        /// <summary>
        /// Обработчик события валидации ввода в ячейку таблицы
        /// при неправильном вводе (не целое число), происходит откат к предыдущему значению
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int i;

            if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
            {

                (sender as DataGridView).CancelEdit();
            }
            else
            {
                (sender as DataGridView)[e.ColumnIndex, e.RowIndex].Value = i;
            }
        }
        /// <summary>
        /// Кнопка объединения графиков в одно поле и разделения на два в зависимости от состояния
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mergeButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            if (chart1.ChartAreas[1].Visible)
            {
                chart1.ChartAreas[1].Visible = !chart1.ChartAreas[1].Visible;
                chart1.Series[1].ChartArea = chart1.ChartAreas[0].Name;
            }
            else
            {
                chart1.ChartAreas[1].Visible = !chart1.ChartAreas[1].Visible;
                chart1.Series[1].ChartArea = chart1.ChartAreas[1].Name;
            }
        }
    }
}
