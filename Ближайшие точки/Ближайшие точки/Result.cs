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

        public Result(Add znach)
        {
            add = znach;
            InitializeComponent();
        }

        private void SavePoints_Click(object sender, EventArgs e)//сохранение введенных точек в файл
        {
            using (StreamReader file = new StreamReader(WhereFile))//открытие выбранного файла для чтения
            {

            }
        }
    }
}
