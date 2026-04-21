using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class KuliahMahasiswa103082400001
{
    public class MataKuliah
    {
        public string kode_matakuliah { get; set; }
        public string nama_matakuliah { get; set; }
    }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_2_103082400001.json");

        List<MataKuliah> data =
            JsonSerializer.Deserialize<List<MataKuliah>>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil:");

        int i = 1;
        foreach (var mk in data)
        {
            Console.WriteLine($"MK {i} {mk.kode_matakuliah} - {mk.nama_matakuliah}");
            i++;
        }
    }
}