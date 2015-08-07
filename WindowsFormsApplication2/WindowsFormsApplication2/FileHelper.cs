using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication2
{
    class FileHelper
    {
        String[,] arr_QnA = new String[9, 2];

        public void Readfromfile()
        {
            StreamReader reader = new StreamReader("Questions.txt");

            int i = 0;

            while ((reader.Peek() > 0) && (i < 9))
            {
                arr_QnA[i++, 0] = reader.ReadLine();
            }
        }
    }
}
