using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_3
{
    class GlossaryItem_2311104057
    {
        public Glossary glossary { get; set; }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_3_2311104057.json");
            var data = JsonConvert.DeserializeObject<GlossaryItem_2311104060>(json);

            var glossEntry = data?.glossary?.GlossDiv?.GlossList?.GlossEntry;

            if (glossEntry != null)
            {
                Console.WriteLine("GlossEntry:");
                Console.WriteLine($"ID: {glossEntry.ID}");
                Console.WriteLine($"GlossTerm: {glossEntry.GlossTerm}");
                Console.WriteLine($"Acronym: {glossEntry.Acronym}");
                Console.WriteLine($"Abbrev: {glossEntry.Abbrev}");
                Console.WriteLine($"GlossDef.Para: {glossEntry.GlossDef.para}");
            }
        }
    }

    public class Glossary_Reyner
    {
        public string title { get; set; }
        public GlossDiv_Reyner GlossDiv { get; set; }
    }

    public class GlossDiv_Reyner
    {
        public string title { get; set; }
        public GlossList_Reyner GlossList { get; set; }
    }

    public class GlossList_Reyner
    {
        public GlossEntry_Reyner GlossEntry { get; set; }
    }

    public class GlossEntry_Reyner
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef_Reyner GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossDef_Reyner
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }
}
