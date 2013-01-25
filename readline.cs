using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type filename and press [enter]");
            Console.WriteLine();
            string filen = Console.ReadLine();

            if (filen != "")
            {
                using (StreamReader sr = new StreamReader(@filen))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string title = line.Substring(11, 40).Trim();
                        string artist = line.Substring(52, 33).Trim();
                        string cat = line.Substring(85, 1).Trim();
                        string filename = line.Substring(88, 12).Trim();
                        string refno = line.Substring(119, 17).Trim();
                        string date = line.Substring(145, 13).Trim();

                        DateTime pvm = DateTime.Parse(date);
                        String dateInString = pvm.ToString("dd-MM-yyyy");

                        Console.WriteLine("{0}:{1}:{2}:{3}:{4}:{5}", title, artist, cat, filename, refno, dateInString);
                        /*
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\lines.txt", true))
                        {
                            file.WriteLine("{0}:{1}:{2}:{3}:{4}:{5}", title, artist, cat, filename, refno, date);
                        }  
                        */
                    }
                }
                Console.WriteLine("Press [enter] to exit...");
                Console.ReadLine();
            }
        }
    }
}
