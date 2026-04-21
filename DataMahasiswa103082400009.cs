using System;
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

    public class DataMahasiswa_103082400009
    {
        public void ReadJSON()
        {
            string filePath = "tp7_1_103082400009.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                MahasiswaWrapper data = JsonSerializer.Deserialize<MahasiswaWrapper>(jsonString);

                if (data != null && data.mahasiswa != null)
                {
                    foreach (var mhs in data.mahasiswa)
                    {
                        Console.WriteLine($"Nama {mhs.firstName} {mhs.lastName} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"[Error] File {filePath} tidak ditemukan.");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"[Error] Kegagalan parsing JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] : {ex.Message}");
            }
        }
    }
}
