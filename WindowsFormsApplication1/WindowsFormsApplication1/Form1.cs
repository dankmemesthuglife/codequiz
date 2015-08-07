using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Array being made
        string line;

        StreamReader reader = new StreamReader("Questions.txt");
	   
        String[,] arr_QnA = new String[9, 2];
        int nq = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* for (int i = 0; i < 2; i++)
            {
                arr_QnA[i, 1] = "0";
            }*/ 
            arr_QnA[3, 1] = "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            //while ( reader.Peek() > 0)
            //{
               //int i = 0;

                //line = reader.ReadLine();
               // arr_QnA[i, 0] = line;

                /*for (int i = 0; i < 10; i++)
                 {
                    line = reader.ReadLine();
                    arr_QnA[i, 0] = line;
                 }
                  */
          // }
        }
        public void Test()
        {
            if (arr_QnA[0,1] == "0")
            {
                MessageBox.Show("It worked");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* for (int i = 0; i < 9; i++)
            { 
                arr_QnA[i, 1] = "1";
            }*/
             //arr_QnA[0, 1] = "0";

            while (reader.Peek() > 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    arr_QnA[i, 0] = reader.ReadLine();
                }
            }
            if (nq < 9)
            {
                label1.Text = arr_QnA[nq++, 0];
            }
            
        }
    }
}
