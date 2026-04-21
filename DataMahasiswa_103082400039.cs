using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    internal class DataMahasiswa_103082400039
    {
        public string nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }

        public void ReadJSON()
        {
            try
            {
                string filePath = "tp_1_103082400039.json";
                string jsonString = File.ReadAllText(filePath);

                DataMahasiswa_103082400039 data = JsonSerializer.Deserialize<DataMahasiswa_103082400039>(jsonString);

                Console.WriteLine($"Nama {data.nama} dengan nim {data.nim} dari fakultas {data.fakultas}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error: " + e.Message);
            }
        }
    }
}
