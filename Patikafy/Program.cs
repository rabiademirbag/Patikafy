using Patikafy;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        List<Singer> singers = new List<Singer>();

        singers.Add(new Singer { NameSurname="Ajda Pekkan",Genre="Pop" ,Year=1986, Selling="Yaklaşık 20 Milyon"});
        singers.Add(new Singer { NameSurname = "Sezen Aksu", Genre = "Türk Halk Müziği/Pop", Year = 1971, Selling = "Yaklaşık 10 Milyon" });
        singers.Add(new Singer { NameSurname = "Funda Arar", Genre = "Pop", Year = 1999, Selling = "Yaklaşık 3 Milyon" });
        singers.Add(new Singer { NameSurname = "Sertab Erener", Genre = "Pop", Year = 1994, Selling = "Yaklaşık 5 Milyon" });
        singers.Add(new Singer { NameSurname = "Sıla", Genre = "Pop", Year = 2009, Selling = "Yaklaşık 3 Milyon" });
        singers.Add(new Singer { NameSurname = "Serdar Ortaç", Genre = "Pop", Year = 1994, Selling = "Yaklaşık 10 Milyon" });
        singers.Add(new Singer { NameSurname = "Tarkan", Genre = "Pop", Year = 1992, Selling = "Yaklaşık 40 Milyon" });
        singers.Add(new Singer { NameSurname = "Hande Yener", Genre = "Pop", Year = 1999, Selling = "Yaklaşık 7 Milyon" });
        singers.Add(new Singer { NameSurname = "Hadise", Genre = "Pop", Year = 2005, Selling = "Yaklaşık 5 Milyon" });
        singers.Add(new Singer { NameSurname = "Gülben Ergen", Genre = "Türk Halk Müziği/Pop", Year = 1997, Selling = "Yaklaşık 10 Milyon" });
        singers.Add(new Singer { NameSurname = "Neşet Ertaş", Genre = "Türk Halk Müziği/Pop", Year = 1960, Selling = "Yaklaşık 2 Milyon" });

        var startsWihtA = singers.Where(singer => singer.NameSurname.StartsWith("S"));
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar");
        foreach(var singer in startsWihtA)
        {
            Console.WriteLine(singer.NameSurname);
        }
        Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar");
        var over10Million = singers
        .Where(s =>
        int.TryParse(new string(s.Selling.Where(char.IsDigit).ToArray()), out int selling) && selling > 10
        );

        foreach (var singer in over10Million)
        {
            Console.WriteLine($"- {singer.NameSurname} ({singer.Selling})");
        }

        Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar.");
        var ordered = singers.Where(singer => singer.Genre.ToLower() == "pop" && singer.Year < 2000).
                                               GroupBy(singer => singer.Year);
        foreach(var group in ordered)
        {
            Console.WriteLine(group.Key);
            foreach(var singer in group.OrderBy(s=>s.NameSurname))
            {
                Console.WriteLine(singer.NameSurname);
            }
        }

        Console.WriteLine("En çok albüm satan şarkıcı");

        var mostSelling = singers
        .Select(s => new
        {
            Singer=s,
            sellingValue = int.TryParse(new string(s.Selling.Where(char.IsDigit).ToArray()), out int num)?num:0

        }).OrderByDescending(s=>s.sellingValue).FirstOrDefault();

        if (mostSelling != null)
        
            Console.WriteLine(mostSelling.Singer.NameSurname);
      

        Console.WriteLine("En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı");


        /*var newest = singers.OrderByDescending(singer => singer.Year).FirstOrDefault();
        var oldest = singers.OrderBy(singer => singer.Year).FirstOrDefault();
        */

        int minYear = singers.Min(singer => singer.Year);
        int maxYear = singers.Max(singer => singer.Year);

        var oldestSinger = singers.Where(singer => singer.Year == minYear);
        var youngestSinger = singers.Where(singer => singer.Year == maxYear);

       foreach(var singer in oldestSinger)
        {
            Console.WriteLine("En eski çıkış yapan sanatçı: "+ singer.NameSurname);
        }

        foreach (var singer in youngestSinger)
        {
            Console.WriteLine("En eski çıkış yapan sanatçı: " + singer.NameSurname);
        }


    }
}