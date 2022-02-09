using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram__unofficial_version_
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program has nothing to do with the official version\nand it is not the official version\nand any purchase or sale of this program is not allowed. . .\n\nThis software uses the official services of\nInstagram and the official version...\n\nThis App Create By Asef Qorbani\nCall me for programming and website ...\n\n0902-928-1914  ---  09118706626  ---  01133682823 \nInstagram : asef9081\nGmail : asefg482@gmail.com\nasefg69@gmail.com\n\n                              This App Copy Right ©\n                                    Asef Qorbani","Aboute",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Your UserName\nAnd\nPassword\nGoto Your Accuont\nAnd\nUse Instagram . . .","Help",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            bool Ch = S_S.Default.TopMost;
            checkBox1.Checked = Ch;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                S_S.Default.TopMost = true;
                S_S.Default.Save();
            }
            else
            {
                S_S.Default.TopMost = false;
                S_S.Default.Save();
            }
        }
    }
}
