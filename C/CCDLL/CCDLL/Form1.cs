using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class CCode
        {
            [DllImport("libCCDLL.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
            //[DllImport("libCCPLUSDLL.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
            public static extern int Add(int a, int b);
            [DllImport("libCCDLL.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
            //[DllImport("libCCPLUSDLL.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
            public static extern int Minus(int a, int b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = CCode.Add(a, b);
            textBox3.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = CCode.Minus(a, b);
            textBox3.Text = c.ToString();
        }
    }
}
