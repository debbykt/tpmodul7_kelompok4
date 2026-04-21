using System;

namespace tpmodul7_kelompok_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103082400039 data = new DataMahasiswa_103082400039();
            data.ReadJSON();

            KuliahMahasiswa_103082400039.ReadJSON();
        }
    }
}