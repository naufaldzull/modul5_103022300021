// See https://aka.ms/new-console-template for more information
internal class Program
{
    class PemrosesData
    {
        public T DapatkanNilaiTerbesar<T>(T nim1, T nim2, T nim3)
        {
            dynamic temp = (dynamic)nim1;
            dynamic temp2 = (dynamic)nim2;
            dynamic temp3 = (dynamic)nim3;
            dynamic terbesar = temp;

            if (temp2 > terbesar)
            {
                terbesar = temp2;
            }
            if (temp3 > terbesar)
            {
                terbesar = temp3;
            }
            return terbesar;
        }

        static void Main()
        {
            PemrosesData data = new PemrosesData();
            Console.WriteLine($"Nilai Terbesar adalah : {data.DapatkanNilaiTerbesar(10.00, 30.00, 22.00)}");
        }
    }
}
