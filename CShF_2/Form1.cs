using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShF_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rez_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(X.Text);
                float y = float.Parse(Y.Text);

                if (y > 25 || y < -25 || x > 50 || x < -50)
                    ans.Text = "вне";

                else if (y == 25 && x * x < 2500 || x == 50 && y * y < 625)
                    ans.Text = "на границе";

                else
                    ans.Text = "внутри";
            }

            catch
            {
                ans.Text = "Некоректный ввод данных";
            }
        }
    }
}
