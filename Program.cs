class Program
{
    static void Main(string[] args)
    {
        // alvan
        DataMahasiswa_103082400009 dataMahasiswa = new DataMahasiswa_103082400009();
        KuliahMahasiswa_103082400009 kuliahMahasiswa = new KuliahMahasiswa_103082400009();

        Console.WriteLine("===DataMahasiswa===");
        dataMahasiswa.ReadJSON();
        Console.WriteLine();
        Console.WriteLine("===KuliahMahasiswa===");
        kuliahMahasiswa.ReadJSON();
        // mira
        DataMahasiswa103082400001.ReadJSON();
        KuliahMahasiswa103082400001.ReadJSON(); 

        // debby
        DataMahasiswa103082400029.ReadJSON();
        KuliahMahasiswa103082400029.ReadJSON();
    }
}

