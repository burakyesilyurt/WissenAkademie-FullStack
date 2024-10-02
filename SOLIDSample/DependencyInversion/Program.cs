// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DependencyInversion;
using DependencyInversion.DIP.ValidUsage.Abstarct;
using DependencyInversion.DIP.ValidUsage.Concrate;

//IDatabase mssql = new MSSQLDatabase();
//ExceptionReporter sqlReporter =new ExceptionReporter(mssql);
//sqlReporter.AddException(new DivideByZeroException("Sıfıra Bölme Hatası"));

//IDatabase elk = new ElasticSearch();
//ExceptionReporter elkReporter = new ExceptionReporter(elk);
//elkReporter.AddException(new FormatException("Belirlenne Formata Uygun Değil"));

List<IUrun> liste = new List<IUrun>();
liste.Add(new Tavuk());
liste.Add(new Et());
liste.Add(new Balik());
Restoran restoran = new Restoran(liste);
restoran.YemekYap();
