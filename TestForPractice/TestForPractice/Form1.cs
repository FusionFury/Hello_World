using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Result = "";
            Echo e1 = new Echo();
            Echo e2 = e1;
            int x = 0;
            while(x<4)
            {
                Result=Result+e1.Hello()+"\n";
                e1.count=e1.count+1;
                if(x==3)
                {
                    e2.count=e2.count+1;
                }
                if(x>0)
                {
                    e2.count=e2.count+e1.count;
                }
                x=x+1;
            }
            MessageBox.Show(Result + "Count:" + e2.count);
        }
    }
    public class Echo
    {
        public int count = 0;
        public string Hello()
        {
            return "Helloooo.....";
        }
    }
}
