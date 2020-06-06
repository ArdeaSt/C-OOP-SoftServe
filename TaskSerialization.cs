using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using  System.Runtime.Serialization.Json;
using System.Text.Json;


namespace Serialize
{
    [Serializable]
    public class Person
    {
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public DateTime birthYear;

        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {
        }

        public Person(string pname, DateTime year)
        {
            name = pname;
            birthYear = year;
        }

        public int Age()
        {
            int a = this.BirthYear.Year;
            int m = DateTime.Today.Year;
            int age = m - a;
            Console.WriteLine($"{Name} is {age} years old.");
            return age;
        }

        public void Input()
        {
            Console.WriteLine("Input Name of person: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Input year of birth : ");
            this.birthYear = DateTime.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            var years = BirthYear.Year;
            return String.Format($"{Name} was born in {years}");
        }

        public void ChangeName(string newname)
        {
            name = newname;
        }

        public static bool operator ==(Person A, Person B)
        {
            return (A.Name == B.Name);
        }

        public static bool operator !=(Person A, Person B)
        {
            return !(A.Name == B.Name);
        }
    }
   

    class Program
    {
        static void SaveasXMLFormat(object obj, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Person));
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlFormat.Serialize(fStream, obj);
            }

            Console.WriteLine("Saved Person in XML format!");
        }
        static void SaveasBinaryFormat(object obj, string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName,FileMode.Create,FileAccess.Write))
            {
                binFormat.Serialize(fStream,obj);
            }

            Console.WriteLine("Saved Person in binary format!");
        }
        static void SaveasJSonFormat(object obj, string fileName)
        {
            
             DataContractJsonSerializer dser = new DataContractJsonSerializer(typeof(Person));
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                dser.WriteObject(fStream,obj);
            }

            Console.WriteLine("Saved Person in JSOn format!");
        }
        static void Main(string[] args)
        {
            Person A = new Person();
            A.Input();

            SaveasJSonFormat(A, "Pers.json");
            SaveasBinaryFormat(A,"Person.dat");
            SaveasXMLFormat(A,"Person.xml");



            //Example deserialization of Person
            XmlSerializer xser = new XmlSerializer(typeof(Person));
            using (Stream fStream = new FileStream("Person.xml",FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                Person A1 = (Person)xser.Deserialize(fStream);
                Console.WriteLine(A1.Name+A1.birthYear);
            }

            

            Console.ReadLine();
        }
    }
}

