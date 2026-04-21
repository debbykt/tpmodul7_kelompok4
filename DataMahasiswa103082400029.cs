using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class Mahasiswa
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }
}

public class DataMahasiswa103082400029
{
    public List<Mahasiswa> mahasiswa { get; set; }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_1_103082400029.json");

        DataMahasiswa103082400029 data =
            JsonSerializer.Deserialize<DataMahasiswa103082400029>(jsonString);

        foreach (var mhs in data.mahasiswa)
        {
            Console.WriteLine(
                "Nama " + mhs.firstName + " " + mhs.lastName +
                " dengan nim " + mhs.nim +
                " dari fakultas " + mhs.fakultas
            );
        }
    }
}