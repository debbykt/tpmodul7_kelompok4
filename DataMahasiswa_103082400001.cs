using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class DataMahasiswa_103082400001
{
    public List<Mahasiswa> mahasiswa { get; set; }

    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }
    }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_1_103082400001.json");

        DataMahasiswa_103082400001 data =
            JsonSerializer.Deserialize<DataMahasiswa_103082400001>(jsonString);

        foreach (var mhs in data.mahasiswa)
        {
            Console.WriteLine($"Nama {mhs.firstName} {mhs.lastName} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
        }
    }
}

