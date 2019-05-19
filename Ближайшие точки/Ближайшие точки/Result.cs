using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Ближайшие_точки
{
    public partial class Result : Form
    {
        Add add;
        public string WhereFile = "";//путь для хранения файла
        public int min, x, y;
        public List<int> ListPoint = new List<int>();

        public Result(Add znach)
        {
            add = znach;
            InitializeComponent();
            Icon icon = new Icon("dist.ico");
            this.Icon = icon;
            saveFileDialog1.Filter = "File Output(*.txt)|*.txt";//расширение для файла
            WhereFile = add.WhereFile;
            ListPoint = add.NumbersList;
            min = add.min;
            x = add.x;
            y = add.y;
            minDist.Text = Convert.ToString(min);
            ResPoints.Text = Convert.ToString(x) + " " + Convert.ToString(y);
            ResNumbPoints.Text = Convert.ToString(ListPoint.IndexOf(x)+1) + " " + Convert.ToString(ListPoint.IndexOf(y)+1);
        }

        private void SavePoints_Click(object sender, EventArgs e)//сохранение введенных точек в файл
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;//если нажали в окне сохранения файла "Отмена"
            WhereFile = saveFileDialog1.FileName;//запись пути выбранного файла
            var array = WhereFile.Split('\\');
            string input, output, way="", name="";
            for(int i=0;i<array.Length-1;i++)
                way = way + array[i] + "\\";
            name = array[array.Length-1];
            name = name.TrimEnd('t');
            name = name.TrimEnd('x');
            name = name.TrimEnd('t');
            name = name.TrimEnd('.');
            input = way + name + "_Input.txt";
            output = way + name + "_Output.txt";
            using (StreamWriter file = new StreamWriter(output))
            {
                file.WriteLine(min);
                string temp = Convert.ToString(ListPoint.IndexOf(x) + 1) + " " + Convert.ToString(ListPoint.IndexOf(y) + 1);
                file.Write(temp);
            }
            using (StreamWriter file = new StreamWriter(input))
            {
                file.WriteLine(ListPoint.Count);
                string temp = "";
                for(int i=0; i<ListPoint.Count;i++)
                    temp = temp + Convert.ToString(ListPoint.ElementAt(i))+" ";
                file.Write(temp);
            }
        }
    }
}
