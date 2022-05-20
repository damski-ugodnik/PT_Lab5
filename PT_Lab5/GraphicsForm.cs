namespace PT_Lab5
{
    public partial class GraphicsForm : Form
    {
        /// <summary>
        /// Тип диаграммы
        /// </summary>
        TypeOfDiagram type;
        /// <summary>
        /// Массив чисел
        /// </summary>
        int[] array;
        /// <summary>
        /// конструктор формы
        /// инициализация масива и типа диаграммы
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="type"></param>
        public GraphicsForm(int[] arr, TypeOfDiagram type)
        {
            this.type = type;
            array = arr;
            InitializeComponent();
        }
        /// <summary>
        /// установка положения кнопки показа автора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GraphicsForm_Load(object sender, EventArgs e)
        {
            showAuthorButton.Location = new Point(Right-showAuthorButton.Width-10, Top+10);
        }
        /// <summary>
        /// Событие рисования на форме, в зависимости от типа, происходит рисование соответствующей диаграммы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GraphicsForm_Paint(object sender, PaintEventArgs e)
        {
            switch (type)
            {
                case TypeOfDiagram.Column:
                    DrawColumnDiagram(e.Graphics);
                    break;
                case TypeOfDiagram.Circle:
                    DrawCircleDiagram(e.Graphics);
                    break;
            }
        }
        /// <summary>
        /// Метод рисования столбчиковой диаграммы
        /// </summary>
        /// <param name="g"></param>
        private void DrawColumnDiagram(Graphics g)
        {
            Random r = new Random();
            Point p1 = new Point(10, 20); Point p2 = new Point(p1.X, Size.Height - 150); Point p3 = new Point(Size.Width - 50, p2.Y);// задание точек для рисования координатных прямых
            Pen pen = new Pen(Color.Black);
            int columnWidth = (p3.X - p2.X)/array.Length-40;// задание ширины столбика в зависимости от количества элементов массива
            g.DrawLine(pen, p1, p2);// рисование вертикальной оси
            g.DrawLine(pen, p2, p3);// рисование горизонтальной оси
            Rectangle[] rectangles = new Rectangle[array.Length];// создание массива прямоугольников, каждый соответсвует элементу массива
            int step = 20;// первоначальный отступ от границы формы
            int scale = (p2.Y-p1.Y)/array.Max();// масштаб высоты столбиков в зависимости от максимального элемента (максимальная высота/максимальное значение в массиве)
            int columnHeight;// перменная высоты столбика
            Brush brushForText = new SolidBrush(Color.Black);   
            for(int i = 0; i < array.Length; i++)
            {
                Brush brush = new SolidBrush(Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0));// создание кисти для рисования столбиков со случайным цветом 
                columnHeight = array[i] * scale;// высота столбика равна произведению значения элемента массива на вычисленный масштаб
                rectangles[i] = new Rectangle(step, p2.Y - columnHeight, columnWidth, columnHeight);// инициализация элементов массива прямоугольника в зависимости от текщего отступа и высоты строки
                g.FillRectangle(brush, rectangles[i]);// рисование прямоугольника
                string val = array[i].ToString();// значение массива в виде строки
                g.DrawString(val, Font, brushForText, step + columnWidth / 2 - g.MeasureString(val, Font).Width / 2, p2.Y + 5);// вывод на экран значения массива под столбиком посередине него
                step += columnWidth + 20;// увеличение отступа на ширину колонки и шаг между ними
            }
        }
        /// <summary>
        /// Метод рисования круговой диагарммы
        /// </summary>
        /// <param name="g"></param>
        private void DrawCircleDiagram(Graphics g)
        {
            Random r = new Random();
           
            Rectangle rectangle = new Rectangle(0,0,Size.Height-100,Size.Height-100);// создание прямоугольника стороны которого равны высоте формы - 100

            float prevAngle = 0;// значение пройденного угла
            for(int i = 0; i < array.Length; i++)
            {
                float angle = ((float)array[i] / array.Sum()) * 360;// угол сектора диаграммы равен частному значения массива на сумму элементов умноженному на 360
                Brush brush = new SolidBrush(Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0));// создание ксити со случайным цветом
                g.FillPie(brush, rectangle, (float)prevAngle,angle);// рисование сектора по текущему пройденному углу и углу текщего сектора
                prevAngle += angle;// добавление к пройденному углу, угол текущего сектора
            }
        }

        /// <summary>
        /// Обработчик кнокпи показа автора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAuthorButton_Click(object sender, EventArgs e)
        {
            Form f = new MeForm();
            f.ShowDialog();
        }
    }
}
