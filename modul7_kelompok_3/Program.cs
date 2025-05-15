using modul7_kelompok_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Membaca file JSON dan menampilkan GlossEntry...");
        GlossaryItem_2311104060.ReadJSON();

        Console.WriteLine("\nSelesai.");
        Console.ReadKey(); // Supaya konsol tidak langsung tertutup

        Console.WriteLine("Membaca file JSON dan menampilkan data mahasiswa... ");
        DataMahasiswa_2311104060 mahasiswa = new DataMahasiswa_2311104060();
        mahasiswa.ReadJSON("jurnal7_1_2311104057.json");

        Console.WriteLine("\nSelesai.");
        Console.ReadKey(); // Supaya konsol tidak langsung tertutup

        Console.WriteLine("Membaca file JSON dan menampilkan data anggota kelompok... ");
        TeamMembers_2311104057 team = new TeamMembers_2311104057();
        team.ReadJSON("jurnal7_2_2311104057.json");

        Console.WriteLine("\nSelesai.");
        Console.ReadKey(); // Supaya konsol tidak langsung tertutup

        Console.WriteLine("Membaca file JSON dan menampilkan GlossEntry");
        GlossaryItem_2311104057.ReadJSON();
        Console.WriteLine("\nSelesai.");

    }
}


