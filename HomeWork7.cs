using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            try
            {
                string[] lines = File.ReadAllLines("phones.txt");
                if (lines != null)
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] temp = lines[i].Split(' ');


                        PhoneBook.Add(temp[0], temp[1]);
                    }

                    Console.WriteLine("Write into phonebook is done!");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message+"Check path");
                
            }
           
           


            using (StreamWriter strWriter = File.CreateText("Phones1.txt"))
            {
                foreach (var phone in PhoneBook)
                {
                    strWriter.WriteLine(phone.Value);
                }

                Console.WriteLine("Phone Numbers writed on new file!");
            }

            using (StreamWriter writer= File.CreateText("new.txt"))
            {
                foreach (var phone in PhoneBook)
                {
                    writer.WriteLine("+3"+phone.Value);
                }

                Console.WriteLine("Phone numbers changed by model +380");
            }

            Console.ReadLine();
        }
    }
}