//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace WindowsFormsApplication1
//{
//    class HighScoreInfo
//    {
//    }
//}

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Media;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    class HighScoreInfo
    {
       // Bird bird = new Bird();
        Pipe pipe = new Pipe();
   //     public int scoreOfGame = 0;

        public int scoreOfGame = 0;
        public void HighScore()
        {
           
            string FilePath = Environment.CurrentDirectory + "/" + "score.txt";
            string FilePath1 = Environment.CurrentDirectory + "/" + "temp.txt";
            if (File.Exists(FilePath))
            {
                StreamReader sr = new StreamReader(FilePath);
                System.IO.StreamReader contents = new System.IO.StreamReader(FilePath);
                string N = contents.ReadToEnd();
                contents.Close();
                sr.Close();

                StreamReader sr1 = new StreamReader(FilePath1);
                System.IO.StreamReader contents1 = new System.IO.StreamReader(FilePath1);
                string N1 = contents1.ReadToEnd();
                contents1.Close();
                sr1.Close();
                //MessageBox.Show(N);
              //  int high = int.Parse(N);
             //   if (scoreOfGame > high)
                if(int.Parse(N1) > int.Parse(N))
                {
                  //  MessageBox.Show("a");
                    N = scoreOfGame.ToString();
                    StreamWriter sw = new StreamWriter(FilePath);
                    sw.Write(N1);
                    sw.Close();
                    
                }

            }
            else
            {
                using (StreamWriter sw = File.AppendText(FilePath))
                {
                    sw.Write("0");
                    sw.Close();
                }

            }

        }
        //    public void CountScore(Control high)
        //{
        //        if ((bird.X_Bird >= pipe.X_pipePairs1 + pipe.picBoxPipeAbove1.Width && bird.X_Bird - 3 <= pipe.X_pipePairs1 + pipe.picBoxPipeAbove1.Width)
        //           || (bird.X_Bird >= pipe.X_pipePairs2 + pipe.picBoxPipeAbove1.Width && bird.X_Bird - 3  <= pipe.X_pipePairs2 + pipe.picBoxPipeAbove1.Width))
        //    //if ( pipe.X_pipePairs1 <= 0 || pipe.X_pipePairs2 <= 0)
        //    {
        //        MessageBox.Show("a");
        //        scoreOfGame++;   
        //        high.Text = scoreOfGame.ToString();
        //    }
           
        //}

            public string Read(string textInFile, string filePath)
            {   
                StreamReader sr = new StreamReader(filePath);
                System.IO.StreamReader contents = new System.IO.StreamReader(filePath);
                textInFile = contents.ReadToEnd();
                contents.Close();
                sr.Close();
                return textInFile;
            }

            public void Write(string textToWrite, string filePath)
            {
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write(textToWrite);
                sw.Close();
            }
        
    }
}



