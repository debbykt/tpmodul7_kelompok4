using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    public class MahasiswaInfo
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }
    }

    public class MahasiswaWrapper
    {
        public List<MahasiswaInfo> mahasiswa { get; set; }
    }
    internal class DataMahasiswa_103082400039
    {

        public void ReadJSON()
        {
            try
            {
                string filePath = "tp_1_103082400039.json";
                string jsonString = File.ReadAllText(filePath);

                MahasiswaWrapper data = JsonSerializer.Deserialize<MahasiswaWrapper>(jsonString);
                if (data != null && data.mahasiswa != null)
                {
                    foreach (var mhs in data.mahasiswa)
                    {
                        Console.WriteLine($"Nama : {mhs.firstName} {mhs.lastName} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
                    }
                }
                //Console.WriteLine($"Nama {data.nama} dengan nim {data.nim} dari fakultas {data.fakultas}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error: " + e.Message);
            }
        }
    }
}
