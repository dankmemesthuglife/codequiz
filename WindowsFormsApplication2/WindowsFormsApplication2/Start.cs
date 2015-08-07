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
    public partial class FormQuiz : Form
    {
        public FormQuiz()
        {
            InitializeComponent();
            
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            label1.Show();
            
        }
        
        
        private void Start_Button_Click(object sender, EventArgs e)
        {
            Qst1 Qst1 = new Qst1();
            Qst1.Show();
            this.Hide();
        }

        private void Welcome_Label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ObjC_Button_Click(object sender, EventArgs e)
        {
            Obj_C_info Obj_C_info = new Obj_C_info();
            Obj_C_info.Show(); 
        }

        private void PHP_Button_Click(object sender, EventArgs e)
        {
            PHP_Info PHP_Info = new PHP_Info();
            PHP_Info.Show();
        }

        private void Ruby_Button_Click(object sender, EventArgs e)
        {
            Ruby_Info Ruby_Info = new Ruby_Info();
            Ruby_Info.Show();
        }

        private void CSharp_Button_Click(object sender, EventArgs e)
        {
            C_Sharp_Info C_Sharp_Info = new C_Sharp_Info();
            C_Sharp_Info.Show();
        }

        private void COBOL_Button_Click(object sender, EventArgs e)
        {
            COBOL_Info COBOL_Info = new COBOL_Info();
            COBOL_Info.Show();
        }

        private void CPP_Button_Click(object sender, EventArgs e)
        {
            CPP_Info CPP_Info = new CPP_Info();
            CPP_Info.Show();
        }

        private void C_Button_Click(object sender, EventArgs e)
        {
            C_Info C_Info = new C_Info();
            C_Info.Show();
        }

        private void Java_Button_Click(object sender, EventArgs e)
        {
            Java_Info Java_Info = new Java_Info();
            Java_Info.Show();
        }

        private void Python_Button_Click(object sender, EventArgs e)
        {
            Python_Info Python_Info = new Python_Info();
            Python_Info.Show();
        }
        
    }
}
