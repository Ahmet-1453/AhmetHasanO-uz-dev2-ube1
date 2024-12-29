namespace AhmetHasanOğuzÖdev2Şube1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç öğrenci girmek istiyorsunuz");
            int ogrencis = int.Parse(Console.ReadLine());
            string[,] ogrencib = new string[ogrencis, 7];

            double sınıfOrt = 0;
            double endusuknotvize = 101;
            double enyukseknotvize = -1;
            double endusuknotfinal = 101;
            double enyukseknotfinal = -1;

            for (int i = 0; i < ogrencis; i++)
            {
                Console.Write("Öğrenci numarası: ");
                ogrencib[i, 0] = Console.ReadLine();

                Console.Write("Öğrenci adını giriniz: ");
                ogrencib[i, 1] = Console.ReadLine();

                Console.Write("Öğrenci soyadını giriniz: ");
                ogrencib[i, 2] = Console.ReadLine();

                double vize;
                while (true)
                {
                    Console.Write("Öğrenci vize notunu giriniz (0-100): ");
                    vize = double.Parse(Console.ReadLine());
                    if (vize >= 0 && vize <= 100) break;
                    Console.WriteLine("Hatalı giriş. Lütfen 0 ile 100 arasında bir değer giriniz.");
                }
                ogrencib[i, 3] = vize.ToString();

                double final;
                while (true)
                {
                    Console.Write("Öğrenci final notunu giriniz (0-100): ");
                    final = double.Parse(Console.ReadLine());
                    if (final >= 0 && final <= 100) break;
                    Console.WriteLine("Hatalı giriş. Lütfen 0 ile 100 arasında bir değer giriniz.");
                }
                ogrencib[i, 4] = final.ToString();

                double ortalama = (vize * 40 / 100) + (final * 60 / 100);
                ogrencib[i, 5] = ortalama.ToString("F2");

                if (ortalama >= 85) ogrencib[i, 6] = "AA";
                else if (ortalama >= 75) ogrencib[i, 6] = "BA";
                else if (ortalama >= 60) ogrencib[i, 6] = "BB";
                else if (ortalama >= 50) ogrencib[i, 6] = "CB";
                else if (ortalama >= 40) ogrencib[i, 6] = "CC";
                else if (ortalama >= 30) ogrencib[i, 6] = "DC";
                else if (ortalama >= 20) ogrencib[i, 6] = "DD";
                else if (ortalama >= 10) ogrencib[i, 6] = "FD";
                else ogrencib[i, 6] = "FF";

                sınıfOrt += ortalama;


                if (vize < endusuknotvize) endusuknotvize = vize;
                if (vize > enyukseknotvize) enyukseknotvize = vize;
                if (final < endusuknotfinal) endusuknotfinal = final;
                if (final > enyukseknotfinal) enyukseknotfinal = final;
            }

            sınıfOrt /= ogrencis;

            Console.WriteLine(new string('-', 125));
            Console.WriteLine($"{"NO",-10}{"AD",-30}{"SOYAD",-30}{"VİZE",-15}{"FİNAL",-15}{"ORTALAMA",-15}{"HARF NOTU",-10}");
            Console.WriteLine(new string('-', 125));

            for (int i = 0; i < ogrencis; i++)
            {
                Console.WriteLine($"{ogrencib[i, 0],-10}{ogrencib[i, 1],-30}{ogrencib[i, 2],-30}{ogrencib[i, 3],-15}{ogrencib[i, 4],-15}{ogrencib[i, 5],-15}{ogrencib[i, 6],-10}");
            }

            Console.WriteLine($"\nSınıf Ortalaması: {sınıfOrt:F2}");
            Console.WriteLine($"En düşük vize notu: {endusuknotvize}");
            Console.WriteLine($"En yüksek vize notu: {enyukseknotvize}");
            Console.WriteLine($"En düşük final notu: {endusuknotfinal}");
            Console.WriteLine($"En yüksek final notu: {enyukseknotfinal}");
        }
    }
}
