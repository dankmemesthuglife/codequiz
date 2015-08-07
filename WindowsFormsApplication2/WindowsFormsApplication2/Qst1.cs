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

namespace WindowsFormsApplication2
{
    public partial class Qst1 : Form
    {
        int Ai = 0;
        int nq = 0;
        bool FR = false;


       //creating the arrays
        String[,] arr_QnA = new String[9, 3];
        String[,] arr_Ans = new String[9, 1];

        public void Readfromfile()
        {
            StreamReader reader = new StreamReader("Questions_CSV.csv");

            int i = 0;

            
            while ((reader.Peek() > 0) && (i < 9) )
            {
                
                string line = reader.ReadLine();
                string[] sline = line.Split(',');
                // 0 = questions   1 = yesbutton   2 = nobutton
                arr_QnA[i, 0] = sline[0];
                arr_QnA[i, 1] = sline[1];
                arr_QnA[i, 2] = sline[2];
                i++;
            }

        }

      
        public void yesnohide()
        {
            if (nq == 9)
            {
                Yes_Button.Hide();
                No_Button.Hide();
                Question_Label.Text = "See your result.";
                Result.Show();
                Retry_B.Show();
            }
        }


        public Qst1()
        {
            InitializeComponent();
        }

       private void Qst1_Load(object sender, EventArgs e)
        {
            Readfromfile();
            Question_Label.Text = arr_QnA[nq++,0];
            Result.Hide();
            Retry_B.Hide();
            
        }
       
       private void Qst_Obj_C_Info_Click(object sender, EventArgs e)
        {
            Obj_C_info Objc_C_info = new Obj_C_info();
            Objc_C_info.Show();
        }

       private void Qst1_PHP_Info_Click(object sender, EventArgs e)
        {
            PHP_Info PHP_Info = new PHP_Info();
            PHP_Info.Show();
        }

        private void Qst1_Ruby_Info_Click(object sender, EventArgs e)
        {
            Ruby_Info Ruby_Info = new Ruby_Info();
            Ruby_Info.Show();
        }

        private void Qst1_Csharp_Info_Click(object sender, EventArgs e)
        {
            C_Sharp_Info C_Sharp_Info = new C_Sharp_Info();
            C_Sharp_Info.Show();
        }

        private void Qst1_Cobol_Info_Click(object sender, EventArgs e)
        {
            COBOL_Info COBOL_Info = new COBOL_Info();
            COBOL_Info.Show();
        }

        private void Qst1_CPP_Info_Click(object sender, EventArgs e)
        {
            CPP_Info CPP_Info = new CPP_Info();
            CPP_Info.Show();
          
        }

        private void Qst1_C_Info_Click(object sender, EventArgs e)
        {
            C_Info C_Info = new C_Info();
            C_Info.Show();
        }

        private void Qst1_Java_Info_Click(object sender, EventArgs e)
        {
            Java_Info Java_Info = new Java_Info();
            Java_Info.Show();
        }

        private void Qst1_Python_Info_Click(object sender, EventArgs e)
        {
            Python_Info Python_info = new Python_Info();
            Python_info.Show();
        }

        private void Yes_Button_Click(object sender, EventArgs e)
        {
            yesnohide();

            // record the answer says patch

            arr_Ans[nq - 1, 0] = "1";

            if (nq >= 9)
            {
                return;
            }
            
            
            // get the next question..

            Question_Label.Text = arr_QnA[nq, 0];
            Yes_Button.Text = arr_QnA[nq, 1];
            No_Button.Text = arr_QnA[nq, 2];
            nq++;
        
        }

        
        private void No_Button_Click(object sender, EventArgs e)
        {
            yesnohide();

            // record the answer says KM

            arr_Ans[nq - 1, 0] = "0";

            if (nq >= 9)
            {
                return;
            }


            // get the next question..

            Question_Label.Text = arr_QnA[nq, 0];
            Yes_Button.Text = arr_QnA[nq, 1];
            No_Button.Text = arr_QnA[nq, 2];

            nq++;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public string Readingplayeranswer()
        {
            StreamReader getter = new StreamReader("Player_Answer.txt");
            string PlayerAnswer = getter.ReadLine();
            return PlayerAnswer;
        }

        private void Result_Click(object sender, EventArgs e)
        {
           try
           {
               using (StreamWriter SW = new StreamWriter("Player_Answer.txt"))
               {  
                    for (int i = 0; i < 9; i++)
                    {
                        SW.Write(arr_Ans[i, 0]);    
                    }
                    
                    //SW.Write("Hello World");
               }
           }
           catch( Exception err)
           {
               MessageBox.Show("Failed");
           }

           string PlayerAnswer = Readingplayeranswer();


           StreamReader options = new StreamReader("Answers.txt");
           int j=0;
           bool bFound = false;

            while ((options.Peek() > 0) && (j <= 32))
           {
               string Result = options.ReadLine();
               string Binary = options.ReadLine(); 

               if (Binary.CompareTo(PlayerAnswer)==0)
               {
                   //MessageBox.Show(Result);
                   string answer;
                   answer = Result;
                   bFound = true;
                  switch (answer)
                  {
                      case "Ruby":
                          Ruby_Info Ruby_Info = new Ruby_Info();
                          Ruby_Info.Show();
                          break;

                      case "Python":
                          Python_Info Python_info = new Python_Info();
                          Python_info.Show();
                          break;
                          
                      case "Cobol":
                          COBOL_Info COBOL_Info = new COBOL_Info();
                          COBOL_Info.Show();
                          break;

                      case "C++":
                          CPP_Info CPP_Info = new CPP_Info();
                          CPP_Info.Show();
                          break;

                      case "C#":
                          C_Sharp_Info C_Sharp_Info = new C_Sharp_Info();
                          C_Sharp_Info.Show();
                          break;

                      case "Obj C":
                          Obj_C_info Objc_C_info = new Obj_C_info();
                          Objc_C_info.Show();
                          break;

                      case "PHP":
                          PHP_Info PHP_Info = new PHP_Info();
                          PHP_Info.Show();
                          break;

                      case "Java":
                         Java_Info Java_Info = new Java_Info();
                         Java_Info.Show();
                          break;
                  }
               }
           }
            if (bFound == false)
            {
                Java_Info Java_Info = new Java_Info();
                Java_Info.Show();
                MessageBox.Show("maybe programming isnt for you :(");
            }
        }

        private void Retry_B_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
