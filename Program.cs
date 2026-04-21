class Program
{
    static void Main(string[] args)
    {
        // alvan
        DataMahasiswa_103082400009 dataMahasiswa = new DataMahasiswa_103082400009();
        KuliahMahasiswa103082400009 kuliahMahasiswa = new KuliahMahasiswa103082400009();

        dataMahasiswa.ReadJSON();
        kuliahMahasiswa.ReadJSON();
        // mira
        DataMahasiswa103082400001.ReadJSON();
        KuliahMahasiswa103082400001.ReadJSON();
        // debby
        DataMahasiswa103082400029.ReadJSON();
        KuliahMahasiswa103082400029.ReadJSON();
    }
}

