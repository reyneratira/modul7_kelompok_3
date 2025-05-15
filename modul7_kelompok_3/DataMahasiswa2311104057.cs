using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace modul7_kelompok_3
{
    class Address_Reyner
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    class Course_Reyner
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address_Reyner address { get; set; }
        public List<Course_Reyner> courses { get; set; }
    }
    class DataMahasiswa2311104057
    {
        public void ReadJSON()
        {
            string path = "jurnal7_1_2311104057.json";
            string jsonString = File.ReadAllText(path);
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine("=====Data Mahasiswa=====");
            Console.WriteLine("Nama : " + data.firstName + " " + data.lastName);
            Console.WriteLine("Jenis Kelamin : " + data.gender);
            Console.WriteLine("Umur : " + data.age);
            Console.WriteLine("Alamat : " + data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);
            Console.WriteLine("Daftar Mata Kuliah : ");
            foreach (var course in data.courses)
            {
                Console.WriteLine(course.code + " - " + course.name);
            }

        }
    }
}
