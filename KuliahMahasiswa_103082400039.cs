using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_4
{
    public class MataKuliah
    {

        public string kode_matakuliah { get; set; }
        public string nama_matakuliah { get; set; }
    }
    internal class KuliahMahasiswa_103082400039
    {

        public static void ReadJSON()
        {
            try
            {
                string filePath = "tp7_2_103082400039.json";
                string jsonString = File.ReadAllText(filePath);

                List<MataKuliah> data = JsonSerializer.Deserialize<List<MataKuliah>>(jsonString);

                Console.WriteLine("Daftar mata kuliah yang diambil:");

                int i = 1;
                foreach (var mk in data)
                {
                    Console.WriteLine($"MK {i} {mk.kode_matakuliah} - {mk.nama_matakuliah}");
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error: " + e.Message);
            }
        }
    }
}
