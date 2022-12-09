using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Auditory__09._12._22_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Вопрос 31:
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            labelCursorPoint.Text = Cursor.Position.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] subs = textBox1.Text.Split('.');
            string s = subs[0] + " " + int.Parse(subs[1]) + " руб";
            listBoxShopList.Items.Add(s);
            int sum = int.Parse(subs[1]) + int.Parse(labelSum.Text);
            labelSum.Text = sum.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBoxShopList.Items.Remove(listBoxShopList.Items[listBoxShopList.Items.Count-1]);
        }

        private void buttonDeleteList_Click(object sender, EventArgs e)
        {
            listBoxShopList.Items.Clear();
        }

        private void buttonSetLimit_Click(object sender, EventArgs e)
        {
            labelLimit.Text = textBox2.Text;
        }

        private void buttonShowMessage_Click(object sender, EventArgs e)
        {
            if(int.Parse(labelSum.Text) <= int.Parse(labelLimit.Text))
            {
                MessageBox.Show("Вы уложились в лимит");
            }
            else
            {
                MessageBox.Show("Вы не уложились в лимит");
            }
        }
    }
}
