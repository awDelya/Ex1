using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ближайшие_точки
{
    public partial class Add : Form
    {
        public Add()//главная форма
        {
            InitializeComponent();
            AddNumber.MaxLength = 6;
        }

        private void AddOldData_Click(object sender, EventArgs e)//добавление существующих точек из файлов
        {

        }

        private void Res_Click(object sender, EventArgs e)//кнопка для показа результата
        {

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
            if (AddNumber.Text == "") AddNumber.Text = "2";
            if (Convert.ToInt32(AddNumber.Text) < 2) AddNumber.Text = "2";
            if (Convert.ToInt32(AddNumber.Text) > 100000) AddNumber.Text = "100000";
        }

        private void AddPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar.ToString()==" "))
                e.Handled = true;
            if (e.KeyChar.Equals((char)13)) Res.Focus();
        }

        private void AddPoints_KeyUp(object sender, KeyEventArgs e)
        {
            if (AddNumber.Text.Length > 0 && AddPoints.Text.Length > 0)
                Res.Enabled = true;
            else Res.Enabled = false;
        }
    }
}
