using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskSystem.IO
{

   
    class Program
    {
        //Select from E:\ only txt. files and print from it into console.
        static void ShowTxtFiles()
        {
            try
            {
                string dir = @"E:\rabstol";

                DirectoryInfo dirInf = new DirectoryInfo(dir);
                var txtfiles = dirInf.GetFiles("*.txt", SearchOption.AllDirectories);
                foreach (var txtfile in txtfiles)
                {
                    using (StreamReader strReader = new StreamReader(txtfile.OpenRead()))
                    {
                        string text = null;
                        while ((text= strReader.ReadLine()) !=null)
                        {
                            Console.WriteLine(text);
                        }

                    }

                }
                



            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
           
        }


        //Write into file ‘DirectoryC.txt’ information (name, type, size) about all directories and files from disc C on your computer. Catch appropriative exceptions.
        static void ShowAllDirectoryandFilesDriveC()
        {

            string dir = @"E:\MyCode";
            string target = @"E:\DirectoryC.txt";

            try
            {

                DirectoryInfo dirs = new DirectoryInfo(dir);
                var dirsInfo = dirs.GetDirectories("*", SearchOption.AllDirectories);

                foreach (var d in dirsInfo)
                {
                    using (StreamWriter strWriter = new StreamWriter(target, true))
                    {
                        strWriter.Write(d.Name + "\t");
                        strWriter.Write(d.Attributes + "\n");
                    }

                    var filesInfo = d.GetFiles("*", SearchOption.TopDirectoryOnly);
                    foreach (var f in filesInfo)
                    {
                        using (StreamWriter strWriter = new StreamWriter(target, true))
                        {
                            strWriter.Write(f.Name + "\t");
                            strWriter.Write(f.Length + "\t");
                            strWriter.Write(f.Extension + "\n");
                        }
                    }

                }

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {

            //Read and write all data from data.txt into rez.txt files, by using (Catch appropriative exceptions):

            try
            {
                using (
                    StreamReader stReader = new StreamReader("data.txt"))
                {
                    string str = null;
                    while ((str = stReader.ReadLine()) != null)
                    {
                        using (StreamWriter stWriter = new StreamWriter("rez.txt",true))
                        {
                            stWriter.Write(str+"\n");
                        }
                    }
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message+"\n"+"Фаил не найден или он находиться в другой директории. Проверьте путь к фаилу!");

            }


           
            ShowAllDirectoryandFilesDriveC();
            ShowTxtFiles();


            Console.ReadLine();
        }
    }
}
