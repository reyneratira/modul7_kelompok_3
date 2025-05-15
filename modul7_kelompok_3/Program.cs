using modul7_kelompok_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Membaca file JSON dan menampilkan GlossEntry...");
        GlossaryItem_2311104060.ReadJSON();

        Console.WriteLine("\nSelesai.");
        Console.ReadKey(); // Supaya konsol tidak langsung tertutup
    }
}


