using System;
using System.Text;
using System.Text.Json;

namespace tpmodul7_kelompok_4
{
        public class MataKuliah
        {
            public string kode_matakuliah { get; set; }
            public string nama_matakuliah { get; set; }
        }

        public class KuliahMahasiswa_103082400009
        {
            public void ReadJSON()
            {
                string filePath = "tp7_2_103082400009.json";

                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    List<MataKuliah> listMatkul = JsonSerializer.Deserialize<List<MataKuliah>>(jsonString);

                    Console.WriteLine("Daftar mata kuliah yang diambil:");

                    if (listMatkul != null)
                    {
                        for (int i = 0; i < listMatkul.Count; i++)
                        {
                            Console.WriteLine($"MK {i + 1} {listMatkul[i].kode_matakuliah} - {listMatkul[i].nama_matakuliah}");
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"[Error] File {filePath} tidak ditemukan. Pastikan properti 'Copy to Output Directory' sudah diatur.");
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"[Error] Gagal memproses format JSON: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error] Terjadi kegagalan sistem: {ex.Message}");
                }
            }
        }
}
