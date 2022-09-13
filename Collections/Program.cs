using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciler = new string[3]
            {
                "Eyüp","Behlül","Akılbek"
            };
            ogrenciler = new string[4]
            {
                "Eyüp","Behlül","Akılbek","Efe"
            };
            ArrayList students = new ArrayList();// Tüm türleri değiştiriyor.
            students.Add("Eyüp");
            students.Add("Behlül");
            students.Add("Akılbek");
            foreach(object student in students)
            {
                Console.WriteLine(student);
            }
            List<string> studentList = new List<string>(); //Verdiğin tipte tutar.
            studentList.Add("Ali");
            studentList.Add("Veli");

            Sehir city = new Sehir()
            {
                Id = 1,
                Adi = "Antalya"
            };

            List<Sehir> cityList = new List<Sehir>();
            cityList.Add(city);
            cityList.Add(new Sehir() { Adi = "Zonguldak", Id = 2 });
            foreach (var sehir in cityList)
            {
                Console.WriteLine(sehir.Adi+" "+sehir.Id);
            }

            Sehir[] yeniSehirler = new Sehir[2]
            {
                new Sehir()
                {
                    Id=3,
                    Adi="Trabzon"
                },
                new Sehir()
                {
                    Id=4,
                    Adi="Bolu"
                }
            };

            foreach (var yeniSehir in yeniSehirler)
            {
                cityList.Add(yeniSehir);
            }
            foreach (var sehir in cityList)
            {
                Console.WriteLine(sehir.Id+" - "+sehir.Adi);
            }

            IEnumerable<string> isimler = new List<string>()
            {
                "Behlül","Efe"
            };
            List<int> sayilar = new List<int>()
            {
                2,1,3
            };
            sayilar.Sort();
            bool contains = cityList.Contains(new Sehir() { Adi = "Samsun", Id = 4 }); //false
            Sehir s = cityList[3];
            bool varMi = cityList.Contains(s);//true
            int index = cityList.IndexOf(s);//3
            cityList.Insert(0, new Sehir() { Id = -1, Adi = "Seçiniz" });
            cityList.Remove(s);//samsun
            cityList.RemoveAt(0);
            cityList.Clear();
            int cityListCount = cityList.Count;
        }
    }
    class Sehir
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }
    
}