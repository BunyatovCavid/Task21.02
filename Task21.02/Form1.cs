using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task21._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StringBuilder metin = new StringBuilder();
                metin.Append(textBox1.Text);
                while (metin.Length > 0)
                {
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < metin.Length; i++)
                    {

                        if (metin[i] == ',')
                        {
                            metin.Remove(0, i + 1);
                            break;
                        }
                        else if (metin.Length - 1 == i)
                        {
                            sb.Append(metin[i]);
                            metin.Remove(0, i + 1);
                            break;
                        }
                        sb.Append(metin[i]);
                    }
                    if (sb.Length!=0)
                    {
                        listBox1.Items.Add(sb);
                    }

                }
                textBox1.Text = "";
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
            }
            catch
            {
                MessageBox.Show("Xeta bas verdi.");
            }
        }
    }
}
