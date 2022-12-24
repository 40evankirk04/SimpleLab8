using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLab8
{
    public class Task_1
    {
        static void DrawScreen()
        {
            
        }

        static void ShowSubtitles()
        {
            foreach (string line in File.ReadLines(@"Subtitles.txt"))
            {
                
            }
        }

        public static void Main()
        {
            ShowSubtitles();
        }
    }
}
