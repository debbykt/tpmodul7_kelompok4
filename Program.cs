using tpmodul7_kelompok_4;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_103082400009 dataMahasiswa = new DataMahasiswa_103082400009();
        KuliahMahasiswa103082400009 kuliahMahasiswa = new KuliahMahasiswa103082400009();

        dataMahasiswa.ReadJSON();
        kuliahMahasiswa.ReadJSON();
    }
}