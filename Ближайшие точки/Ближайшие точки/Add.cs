using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ближайшие_точки
{
    public partial class Add : Form
    {
        public List<int> ListPoint = new List<int>();//для записи точек
        public List<int> NumbersList = new List<int>();//для копии первого листа
        public string WhereFile = "";
        public int min, x, y;
        public Add()//главная форма
        {
            InitializeComponent();
            AddNumber.MaxLength = 6;//ограничения на кол-во символов в числе
            openFileDialog1.Filter = "File Input(*.txt)|*.txt";//расширение для файла
        }

        private void AddOldData_Click(object sender, EventArgs e)//добавление существующих точек из файлов
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;//если нажали в окне открытия файла "Отмена"
            WhereFile = openFileDialog1.FileName;//запись пути выбранного файла
            using (StreamReader file = new StreamReader(WhereFile))//открытие выбранного файла для чтения
            {
                string temp = file.ReadLine();//чтение строки
                if (temp == null) //проверка на пустоту
                    { MessageBox.Show("Данные файла не подходят под условия задачи."); return; }
                try
                {
                    int count = Convert.ToInt32(temp);
                    if (count >= 2 && count <= 100000)
                        AddNumber.Text = temp;//добавление данных в форму
                    else
                    { AddNumber.Text = ""; AddPoints.Text = ""; MessageBox.Show("Данные файла не подходят под условия задачи."); return; }
                    temp = file.ReadLine();//строка файла открывается на чтение
                    if (temp == null)//проверка на пустоту
                    { AddNumber.Text = ""; AddPoints.Text = ""; MessageBox.Show("Данные файла не подходят под условия задачи."); return; }
                    else
                    {
                        var array = temp.Split(' ');//запись данных
                        for(int i=0;i<array.Length; i++)//перебор элементов для добавлеия в лист
                        {
                            int x = Convert.ToInt32(array[i]);
                            ListPoint.Add(x);
                        }
                    }
                    temp = "";
                    for (int i = 0; i < ListPoint.Count; i++)
                        temp = temp + " " + ListPoint[i];
                    temp = temp.Trim();//Удаляет пробелы в начале и в конце строки
                    AddPoints.Text = temp;//вывод в форму
                    Res.Enabled = true;
                }
                catch
                { AddNumber.Text = ""; AddPoints.Text = ""; MessageBox.Show("Данные файла не подходят под условия задачи."); }
                if (ListPoint.Count == Convert.ToInt32(AddNumber.Text)) return;
                else
                { Res.Enabled = false; MessageBox.Show("Количество точек не совадает с указанным значением."); }
            }
        }

        private void Res_Click(object sender, EventArgs e)//кнопка для показа результата
        {
            int tempDist = 0;
            NumbersList = ListPoint.ToList();
            ListPoint.Sort();
            min = Int32.MaxValue;
            for (int i = 0; i < ListPoint.Count; i++)
            {
                try
                {
                    tempDist = Math.Abs(ListPoint[i + 1] - ListPoint[i]);
                }
                catch { }
                if (tempDist < min && tempDist != 0)
                {
                    min = tempDist;
                    x = ListPoint[i];
                    y = ListPoint[i + 1];
                }
            }
            if (min == Int32.MaxValue)
                MessageBox.Show("Все точки совпадают, минимальное расстояние равно 0!");
            else
            {
                Result forRes = new Result(this);
                forRes.ShowDialog();
            }
        }

        private void AddNumber_KeyPress(object sender, KeyPressEventArgs e)//нажатие клавиши
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar.Equals((char)13)) AddPoints.Focus();
        }

        private void AddNumber_KeyUp(object sender, KeyEventArgs e)//отжатие клавиши
        {
            if (AddNumber.Text.Length > 0 && AddPoints.Text.Length > 0)//проверка полей для кнопки показа результата
                Res.Enabled = true;
            else Res.Enabled = false;
            try
            {
                if (Convert.ToInt32(AddNumber.Text) < 2) AddNumber.Text = "2";
                if (Convert.ToInt32(AddNumber.Text) > 100000) AddNumber.Text = "100000";
                AddPoints.Enabled = true;
                if (ListPoint.Count == Convert.ToInt32(AddNumber.Text)) Res.Enabled = true;
                else
                    Res.Enabled = false;
            }
            catch { AddPoints.Enabled = false; }
        }

        private void AddPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar.ToString() == " ") && !(e.KeyChar.ToString() == "-"))
                e.Handled = true;
            if (e.KeyChar.Equals((char)13)) Res.Focus();            
        }

        private void AddPoints_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                ListPoint.Clear();
                string temp = AddPoints.Text;
                var array = temp.Split(' ');//запись данных
                for (int i = 0; i < array.Length; i++)//перебор элементов для добавлеия в лист
                {
                    int x = Convert.ToInt32(array[i]);
                    ListPoint.Add(x);
                }
            }
            catch { }
            if (ListPoint.Count == Convert.ToInt32(AddNumber.Text)) Res.Enabled = true;
            else
                Res.Enabled = false;
        }
    }
}
