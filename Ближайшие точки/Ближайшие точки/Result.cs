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
            using (StreamReader file = new StreamReader(WhereFile))//открытие выбранного файла для чтения
            {

            }
        }
    }
}
