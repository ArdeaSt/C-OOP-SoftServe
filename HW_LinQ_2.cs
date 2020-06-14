using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInQHW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"E:\shapes.txt";
            List<string> text = new List<string>();
            using (StreamReader sReader = new StreamReader(str))
            {
                string line = null;
                while ((line=sReader.ReadLine()) != null)
                {
                    if (line !=null)
                    {
                        text.Add(line);
                    }
                   
                }
               
            }

            string[] textArray = text.ToArray();

            Console.WriteLine("**************************B1*****************************");
            for (int i = 0; i < textArray.Length; i++)
            {
             Console.WriteLine("Довжина рядка :"+ textArray[i].Length);
            }

            string temp;
            for (int i = 0; i < textArray.Length-1; i++)
            {
                for (int j = i+1; j < textArray.Length; j++)
                {
                    if (textArray[i].Length>textArray[j].Length)
                    {
                        temp = textArray[i];
                        textArray[i] = textArray[j];
                        textArray[j] = temp;
                    }
                }
            }

           
            Console.WriteLine("***************************B2****************************");

            Console.WriteLine(
                $"The shortest line consist {textArray[0].Length} chars, the longest : {textArray[textArray.Length-1].Length}");
            Console.WriteLine("***************************B3****************************");
            var team = from t in textArray where t.Contains("team") select t;
            foreach (var t in team)
            {
                Console.WriteLine(t);
            }
            Console.ReadLine();
        }
    }
}
