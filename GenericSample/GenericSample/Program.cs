// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using GenericSample;

//GenericOlmayanSinif obj = new GenericOlmayanSinif();
//obj.EkranaYaz(12502);
//Console.ReadLine();
//obj.EkranaYaz<int>((int)300.00);
//Console.ReadLine();
//obj.EkranaYaz<string>("Hello World!!!!");
//Console.ReadLine();
//obj.EkranaYaz("Merhaba Dünya!!!");
//Console.ReadLine();
////obj.EkranaYaz<int>(int.Parse(false.ToString()));
///

//GenericSinif<int> ogrenci = new GenericSinif<int>();
//ogrenci.ID = 1001;
//ogrenci.Name = "John";
//ogrenci.SirName = "Doe";
//Console.WriteLine(ogrenci.ToString());

//GenericSinif<Guid> ogretmen = new GenericSinif<Guid>();
////ogretmen.ID = 100;
//ogretmen.ID = Guid.NewGuid();
//ogretmen.Name = "Jeyn";
//ogretmen.SirName = "Doe";
//Console.WriteLine(ogretmen.ToString());

//AnahtarDegerIkilisi<int, string> kullanici = new AnahtarDegerIkilisi<int, string>();
//kullanici.ID = 1;
//kullanici.Name = "John Doe";
//kullanici.BirthDate = new DateTime(1989, 5, 16);
//Console.WriteLine(kullanici.ToString());

//AnahtarDegerIkilisi<Guid, string> user = new AnahtarDegerIkilisi<Guid, string>();
//user.ID = Guid.NewGuid();
//user.Name = "Jeyn Doe";
//user.BirthDate = DateTime.Now.AddYears(-26);
//Console.WriteLine(user.ToString());

//GenericField<int> field = new GenericField<int>();
//field.id = 12;
//Console.WriteLine($"Field : {field.id}");

GenericMetot<string> teams = new GenericMetot<string>();
teams.ElemanEkle(0, "Galatasaray");
teams.ElemanEkle(1, "Fenerbahçe");
teams.ElemanEkle(2, "Beşiktaş");
teams.ElemanEkle(3, "TrabzonSpor");
teams.ElemanEkle(4, "Başakşehir");

for (int i = 0; i < teams.dizi.Length; i++)
{
    Console.WriteLine($"Index : {i} : Eleman : {teams.VeriAl(i)}");
}
Console.ReadLine();

GenericMetot<int> ages = new GenericMetot<int>();
Random rand = new Random();

for (int i = 0; i < 5; i++)
{
    ages.ElemanEkle(i, rand.Next(0, 100));
}

for (int i = 0; i < ages.dizi.Length; i++)
{
    Console.WriteLine($"Index : {i} : Eleman : {ages.VeriAl(i)}");
}